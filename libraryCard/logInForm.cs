using System;
using System.IO;
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
    public partial class logInForm : MetroFramework.Forms.MetroForm
    {
        public logInForm()
        {
            InitializeComponent();
            textBox4.UseSystemPasswordChar = true;

            if (File.Exists("db_log.txt") && (new FileInfo("db_log.txt").Length != 0))
            {
                if (!string.IsNullOrEmpty(File.ReadLines("db_log.txt").ElementAtOrDefault(0)))
                {
                    string line1 = File.ReadLines("db_log.txt").Skip(0).Take(1).First();
                    textBox1.Text = line1;
                }
                if (!string.IsNullOrEmpty(File.ReadLines("db_log.txt").ElementAtOrDefault(1)))
                {
                    string line2 = File.ReadLines("db_log.txt").Skip(1).Take(1).First();
                    textBox2.Text = line2;
                }
                if (!string.IsNullOrEmpty(File.ReadLines("db_log.txt").ElementAtOrDefault(2)))
                {
                    string line3 = File.ReadLines("db_log.txt").Skip(2).Take(1).First();
                    textBox5.Text = line3;
                }
            }

            if (textBox1.Text == "")
                textBox1.Select();
            else if (textBox2.Text == "")
                textBox2.Select();
            else if (textBox3.Text == "")
                textBox3.Select();
            else if (textBox4.Text == "")
                textBox4.Select();
            else if (textBox5.Text == "")
                textBox5.Select();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                MessageBox.Show("Missing fields.");

            else if (int.TryParse(textBox2.Text, out n))
            {
                //set database variables
                db_type.db_hostname = textBox1.Text;
                db_type.db_port = textBox2.Text;
                db_type.db_username = textBox3.Text;
                db_type.db_pw = textBox4.Text;
                db_type.db_database = check.sanitize(textBox5.Text);

                //connect to database
                string connect = "datasource = " + db_type.db_hostname + ";port = " + db_type.db_port + "; Initial Catalog = '" + db_type.db_database + "'; username = " + db_type.db_username + "; password = " + db_type.db_pw;

                //check for the required tables
                string Query = "SELECT * FROM books,dvd,customers,checkout WHERE checkout.checkoutID LIKE '%" + "test" + "%'";
                MySqlConnection conDataBase = new MySqlConnection(connect);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                try
                {
                    conDataBase.Open();

                    myReader = cmdDataBase.ExecuteReader();

                    string write = textBox1.Text + "\r\n" + textBox2.Text + "\r\n" + check.sanitize(textBox5.Text) + Environment.NewLine;
                    File.WriteAllText("db_log.txt", write);

                    mainMenuForm menu = new mainMenuForm();
                    menu.Show();
                    this.Hide();
                }

                catch (Exception ex)
                {
                    string passCheck = ex.Message.ToString();
                    passCheck = passCheck.Substring(0, 23) + passCheck.Substring(passCheck.Length - 21, 21);
                    if (passCheck == "Access denied for user (using password: YES)")
                        MessageBox.Show("Wrong username or password.");
                    else
                        MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Wrong port.");

        }
    }
}
