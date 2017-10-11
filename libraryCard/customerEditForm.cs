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
    public partial class customerEditForm : MetroFramework.Forms.MetroForm
    {
        string field_, edit_;

        private mainMenuForm mainForm = null;
        public customerEditForm(MetroFramework.Forms.MetroForm callingForm)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control lbl in Controls.OfType<GroupBox>())
                lbl.Hide();

            if (id.Enabled == false)
                id.Enabled = true;

            if (comboBox1.SelectedIndex == 0)
                fNameBox.Show();
            else if (comboBox1.SelectedIndex == 1)
                lNameBox.Show();
            else if (comboBox1.SelectedIndex == 2)
                phoneBox.Show();
            else if (comboBox1.SelectedIndex == 3)
                addressBox.Show();
            else if (comboBox1.SelectedIndex == 4)
                DateOfBirthBox.Show();
            else if (comboBox1.SelectedIndex == 5)
            {
                if (this.id.Text != "")
                {
                    string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
                    string Query = "SELECT notes FROM " + db_type.db_database + ".customers WHERE customerID=" + check.sanitize(this.id.Text) + " ;";

                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        myReader.Read();
                        notes.Text = myReader.GetString(0);

                        notesBox.Show();
                        id.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + Environment.NewLine + "Make sure the customer ID is valid.");
                    }

                }
                else
                {
                    MessageBox.Show("To select notes you have to specify ID first.");
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Control lbl in Controls.OfType<GroupBox>())
                lbl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                switch (this.comboBox1.Text) //converts English table options to database names
                {
                    case "First Name":
                        field_ = "FName";
                        edit_ = check.sanitize(fName.Text);
                        break;
                    case "Last Name":
                        field_ = "LName";
                        edit_ = check.sanitize(lName.Text);
                        break;
                    case "Phone":
                        field_ = "phone";
                        edit_ = check.sanitize(phoneNum.Text);
                        break;
                    case "Address":
                        field_ = "address";
                        edit_ = check.sanitize(this.stAd.Text) + " " + check.sanitize(this.city.Text) + ", " + check.sanitize(this.state.Text) + " " + check.sanitize(this.zip.Text);
                        break;
                    case "Date of Birth":
                        field_ = "birthdate";
                        edit_ = check.sanitize(this.month.Text) + "/" + check.sanitize(this.day.Text) + "/" + check.sanitize(this.year.Text);
                        break;
                    case "Notes":
                        field_ = "notes";
                        edit_ = check.sanitize(this.notes.Text);
                        break;
                    case "":
                        field_ = "errorInFieldSwitch";
                        break;
                }

                string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
                string Query = "USE " + db_type.db_database + "; UPDATE customers SET " + field_ + "=\"" + edit_ + "\" WHERE customerID=" + check.sanitize(this.id.Text) + " ;";
                
                //              UPDATE customers SET     FName     ='     text                   '  WHERE customerID=    1;
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                /*
                int affected = cmdDataBase.ExecuteNonQuery();
                if (affected == 0)
                {
                    MessageBox.Show("No rows affected.");
                }
                else
                {
                    MessageBox.Show("Customer edited.");
                }
                */

                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    //MySqlCommand comm;
                    MessageBox.Show("Customer edited.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Make sure the customer ID is valid.");
                }
            }
            else
            {
                MessageBox.Show("Enter a customer ID.");
            }
            
        }
    }
}
