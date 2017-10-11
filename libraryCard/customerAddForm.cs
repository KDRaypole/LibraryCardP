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
    public partial class customerAddForm : MetroFramework.Forms.MetroForm
    {

        private mainMenuForm mainForm = null;
        public customerAddForm(MetroFramework.Forms.MetroForm callingForm)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string address = check.sanitize(this.stAddress.Text) + " " + check.sanitize(this.city.Text) + ", " + check.sanitize(this.state.Text) + " " + check.sanitize(this.zip.Text);
            string birthDate = check.sanitize(this.month.Text) + "/" + check.sanitize(this.day.Text) + "/" + check.sanitize(this.year.Text);

            string constring = "datasource = " + db_type.db_hostname + ";port = " + db_type.db_port + "; Initial Catalog = '" + db_type.db_database + "'; username = " + db_type.db_username + "; password = " + db_type.db_pw;
            string Query = "INSERT INTO " + db_type.db_database + ".customers (FName,LName,phone,address,birthdate,notes) values('" + check.sanitize(this.fname.Text) + "','" + check.sanitize(this.lname.Text) + "','" + check.sanitize(this.phoneNum.Text) + "','" + address + "','" + birthDate + "','" + "" + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Customer Saved");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
