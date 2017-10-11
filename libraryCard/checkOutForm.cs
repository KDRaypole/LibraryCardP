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
    public partial class checkOutForm : MetroFramework.Forms.MetroForm
    {

        private mainMenuForm mainForm = null;
        public checkOutForm(MetroFramework.Forms.MetroForm callingForm)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string outDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            string constring = "datasource = " + db_type.db_hostname + ";port = " + db_type.db_port + "; Initial Catalog = '" + db_type.db_database + "'; username = " + db_type.db_username + "; password = " + db_type.db_pw;

            string Query = "";

            if (comboBoxID_ISBN.SelectedIndex == 0) //Book using ISBN
            {
                if (!repeatedIDs.Enabled) //if user doesn't need to choose bookID from dropdown menu
                {
                    List<string> idshit = new List<string>(); //stores bookIDs

                    string Query2 = "SELECT bookID FROM " + db_type.db_database + ".books WHERE ISBN = '" + this.bookISBN.Text + "';"; //get bookIDs with given ISBN
                    MySqlConnection conDataBase2 = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase2 = new MySqlCommand(Query2, conDataBase2);
                    MySqlDataReader myReader2;

                    try
                    {
                        conDataBase2.Open(); //open connection

                        myReader2 = cmdDataBase2.ExecuteReader(); //start data reader

                        cmdDataBase2.CommandType = CommandType.Text; //set data to text

                        for (int i = 0; myReader2.Read(); i++) //add duplicate bookID's to list
                        {
                            idshit.Add(myReader2.GetString(0));

                            if (!check.checkedOut(idshit[i], "book")) //if the book isn't already checked out
                            {
                                repeatedIDs.Items.Add(idshit[i]); //add book to dropdown list
                            }
                        }

                        myReader2.Close();

                        if (repeatedIDs.Items.Count == 0) //if no books are available for checkout
                        {
                            if (idshit.Count > 0) //if books were found
                            {
                                MessageBox.Show("No books available for checkout.");
                            }
                            else //isbn doesn't exist
                            {
                                MessageBox.Show("ISBN not found.");
                            }
                            return;
                        }
                        else if (repeatedIDs.Items.Count == 1) //if only one book is available
                        {
                            repeatedIDs.Enabled = true;
                            this.repeatedIDs.SelectedIndex = 0;
                            //Query = "INSERT INTO " + db_type.db_database + ".checkout (customerID,bookID,outDate) values('" + check.sanitize(this.customerID_2.Text) + "','" + idshit[0] + "','" + outDate +
                            //    "') ; UPDATE books SET status=\"out\" WHERE bookID=" + idshit[0] + ";";
                            Query = "INSERT INTO " + db_type.db_database + ".checkout (customerID,bookID,outDate) values('" + check.sanitize(this.customerID_2.Text) + "','" + this.repeatedIDs.Text + "','" + outDate +
                                "') ; UPDATE books SET status=\"out\" WHERE bookID=" + this.repeatedIDs.Text + ";";
                            repeatedIDs.Items.Clear();
                            repeatedIDs.Enabled = false;
                        }
                        else //multiple books are available
                        {
                            repeatedIDs.Enabled = true;
                            this.repeatedIDs.SelectedIndex = 0;
                            MessageBox.Show("Select the Book ID.");

                            return;
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else //bookID from dropdown list has been selected
                {
                    Query = "INSERT INTO " + db_type.db_database + ".checkout (customerID,bookID,outDate) values('" + check.sanitize(this.customerID_2.Text) + "','" + this.repeatedIDs.Text + "','" + outDate +
                        "') ; UPDATE books SET status=\"out\" WHERE bookID=" + this.repeatedIDs.Text + ";";
                    repeatedIDs.Items.Clear();
                    repeatedIDs.Enabled = false;
                }
            }
            else if (comboBoxID_ISBN.SelectedIndex == 1) //Book using ID
            {
                if (!check.checkedOut(this.bookID.Text, "book")) //if the book isn't already checked out
                {
                    Query = "INSERT INTO " + db_type.db_database + ".checkout (customerID,bookID,outDate) values('" + check.sanitize(this.customerID.Text) + "','" + check.sanitize(this.bookID.Text) + "','" + outDate +
                        "') ; UPDATE books SET status=\"out\" WHERE bookID=" + check.sanitize(this.bookID.Text) + ";";

                }
                else
                {
                    MessageBox.Show("Cannot checkout: Book is already checked out.");
                    return;
                }

            }
            else if (comboBoxID_ISBN.SelectedIndex == 2) //DVD using ID
            {
                if (!check.checkedOut(this.dvdID.Text, "dvd")) //if the book isn't already checked out
                {
                    Query = "INSERT INTO " + db_type.db_database + ".checkout (customerID,dvdID,outDate) values('" + check.sanitize(this.customerID_3.Text) + "','" + check.sanitize(this.dvdID.Text) + "','" + outDate +
                        "') ; UPDATE dvd SET status=\"out\" WHERE dvdID=" + check.sanitize(this.dvdID.Text) + ";";
                }
                else
                {
                    MessageBox.Show("Cannot checkout: DVD is already checked out.");
                    return;
                }
            }

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (comboBoxID_ISBN.SelectedIndex == 2) //DVD using ID
                {
                    MessageBox.Show("DVD checked out.");
                }
                else
                {
                    MessageBox.Show("Book checked out.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Make sure entered IDs are valid.");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            foreach (Control gBoxes in Controls.OfType<GroupBox>())
                gBoxes.Hide();

            this.comboBoxID_ISBN.SelectedIndex = Properties.Settings.Default.checkOutChoice;
        }

        private void comboBoxID_ISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control gBoxes in Controls.OfType<GroupBox>())
                gBoxes.Hide();

            if (comboBoxID_ISBN.SelectedIndex == 0)
                bookIsbnBox.Show();
            else if (comboBoxID_ISBN.SelectedIndex == 1)
                bookIdBox.Show();
            else if (comboBoxID_ISBN.SelectedIndex == 2)
                dvdIdBox.Show();

        }

        private void bookISBN_TextChanged(object sender, EventArgs e)
        {
            if (repeatedIDs.Enabled)
            {
                repeatedIDs.Items.Clear();
                repeatedIDs.Enabled = false;

            }
        }
    }
}
