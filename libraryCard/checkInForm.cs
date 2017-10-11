using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace libraryCard
{
    public partial class checkInForm : MetroFramework.Forms.MetroForm
    {

        private mainMenuForm mainForm = null;
        public checkInForm(MetroFramework.Forms.MetroForm callingForm)
        {
            mainForm = callingForm as mainMenuForm;
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.mainForm.Focus();
            this.mainForm.menuStrip1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string datediff, customerId, lName, fName, product = "";
            string inDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            string constring = "datasource = " + db_type.db_hostname + ";port = " + db_type.db_port + "; Initial Catalog = '" + db_type.db_database + "'; username = " + db_type.db_username + "; password = " + db_type.db_pw;
            string Query = "";

            if (check.sanitize(this.idField.Text) != "")
            {
                if (comboBoxCheckIn.SelectedIndex == 0) //Book ID
                {
                    if (!check.checkedOut(this.idField.Text, "book"))
                    {
                        MessageBox.Show("Book already checked in.");
                        return;
                    }
                    else
                    {
                        product = "Book";

                        Query = "USE " + db_type.db_database +
                            "; UPDATE checkout SET " + "inDate" + "=\"" + inDate + "\" WHERE bookID=" + check.sanitize(this.idField.Text) + " AND (bookStatus!=\"complete\" OR bookStatus IS NULL);" +
                            "SELECT DATEDIFF(inDate,outDate) AS DiffDate FROM " + db_type.db_database + ".checkout WHERE bookID = " + check.sanitize(this.idField.Text) + " AND (bookStatus!=\"complete\" OR bookStatus IS NULL);" +
                            "SELECT customerID, fName, lName FROM " + db_type.db_database + ".customers WHERE customerID = (SELECT customerID FROM " + db_type.db_database + ".checkout WHERE bookID = " + check.sanitize(this.idField.Text) + " AND (bookStatus!=\"complete\" OR bookStatus IS NULL));" +
                            "UPDATE checkout SET bookStatus=\"complete\" WHERE bookID=" + check.sanitize(this.idField.Text) + " AND (bookStatus!=\"complete\" OR bookStatus IS NULL);" +
                            "UPDATE books SET status =\"\" WHERE bookID=" + check.sanitize(this.idField.Text) + ";";
                    }
                }
                else if (comboBoxCheckIn.SelectedIndex == 1) //DVD ID
                {
                    if (!check.checkedOut(this.idField.Text, "dvd"))
                    {
                        MessageBox.Show("DVD already checked in.");
                        return;
                    }
                    else
                    {
                        product = "DVD";

                        Query = "USE " + db_type.db_database +
                           "; UPDATE checkout SET " + "inDate" + "=\"" + inDate + "\" WHERE dvdID=" + check.sanitize(this.idField.Text) + " AND (bookStatus!=\"complete\" OR bookStatus IS NULL);" +
                           "SELECT DATEDIFF(inDate,outDate) AS DiffDate FROM " + db_type.db_database + ".checkout WHERE dvdID = " + check.sanitize(this.idField.Text) + " AND (bookStatus!=\"complete\" OR bookStatus IS NULL);" +
                           "SELECT customerID, fName, lName FROM " + db_type.db_database + ".customers WHERE customerID = (SELECT customerID FROM " + db_type.db_database + ".checkout WHERE dvdID = " + check.sanitize(this.idField.Text) + " AND (bookStatus!=\"complete\" OR bookStatus IS NULL));" +
                           "UPDATE checkout SET bookStatus=\"complete\" WHERE dvdID=" + check.sanitize(this.idField.Text) + " AND (bookStatus!=\"complete\" OR bookStatus IS NULL);" +
                           "UPDATE dvd SET status =\"\" WHERE dvdID=" + check.sanitize(this.idField.Text) + ";";
                    }
                }

                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                try
                {                           //need to add datediff stuff. IM ON IT!! *THEME SONG MUSIC* 

                    conDataBase.Open();

                    myReader = cmdDataBase.ExecuteReader();
                    myReader.Read();
                    datediff = myReader.GetString(0);

                    myReader.NextResult();

                    myReader.Read();
                    customerId = myReader["customerId"].ToString();

                    myReader.Read();
                    lName = myReader["lName"].ToString();

                    myReader.Read();
                    fName = myReader["fName"].ToString();

                    decimal rate = 0;
                    if (comboBoxCheckIn.SelectedIndex == 0) //if book checked in
                    {
                        rate = Properties.Settings.Default.overdueBookCostPerDay;
                    }
                    else if (comboBoxCheckIn.SelectedIndex == 1) //if dvd checked in
                    {
                        rate = Properties.Settings.Default.overdueDvdCostPerDay;
                    }
                    int daysLate = Convert.ToInt32(datediff) - Properties.Settings.Default.daysUntilOverdue; //how many days late
                    decimal amountDue = daysLate * rate; //calculates the amount due

                    if (Convert.ToInt32(datediff) > Properties.Settings.Default.daysUntilOverdue)    //checks to see if book is late
                    {

                        overdueOption overdue = new overdueOption(daysLate, amountDue, this.idField.Text, (fName + " " + lName), customerId, product);
                        overdue.ShowDialog();

                    }
                    else
                        MessageBox.Show("Checked in.\n" + fName + " " + lName + " (" + customerId + ")\nNo late fee.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Make sure entered ID is valid.");
                }
            }
            else
            {
                MessageBox.Show("Enter ID.");
            }
        }

        private void comboBoxCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control labels in panelForLabels.Controls.OfType<Label>())
                labels.Hide();
            
            if (comboBoxCheckIn.SelectedIndex == 0)
                bookIdLabel.Show();
            else if (comboBoxCheckIn.SelectedIndex == 1)
                dvdIdLabel.Show();
        }

        private void checkInForm_Load(object sender, EventArgs e)
        {
            foreach (Control labels in panelForLabels.Controls.OfType<Label>())
                labels.Hide();

            this.comboBoxCheckIn.SelectedIndex = Properties.Settings.Default.checkInChoice;
        }
    }
}
