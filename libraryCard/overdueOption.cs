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
    public partial class overdueOption : MetroFramework.Forms.MetroForm
    {
        public overdueOption(int days, decimal money, string productID, string name, string customerID, string product)
        {
            InitializeComponent();

            daysLabel.Text = days.ToString();
            moneyLabel.Text = money.ToString();
            productIdLabel.Text = productID;
            nameLabel.Text = name;
            customerIdLabel.Text = customerID;
            if (product == "Book")
                productNameLabel.Text = "Book ID:";
            else if (product == "DVD")
                productNameLabel.Text = "DVD ID:";
            else
                productNameLabel.Text = "ERROR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inDate = DateTime.Now.ToString(" MM.dd.yyyy HH.mm.ss ");
            string constring = "datasource = " + db_type.db_hostname + ";port = " + db_type.db_port + "; Initial Catalog = '" + db_type.db_database + "'; username = " + db_type.db_username + "; password = " + db_type.db_pw;
            string edit_ = nameLabel.Text + " owes " + moneyLabel.Text + " dollars for the " + productNameLabel.Text.Substring(0, productNameLabel.Text.Length - 4).Replace('B', 'b') + " with ID num " + productIdLabel.Text + ". " + inDate + Environment.NewLine;
            string Query = "USE " + db_type.db_database + "; UPDATE customers SET notes = concat(notes, \"" + edit_ + "\") WHERE customerID=" + customerIdLabel.Text + " ;";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                MessageBox.Show("Note added.");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void overdueOption_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
