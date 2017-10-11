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
    public partial class bookAddForm : MetroFramework.Forms.MetroForm
    {

        private mainMenuForm mainForm = null;
        public bookAddForm(MetroFramework.Forms.MetroForm callingForm)
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

        private void getData_Click(object sender, EventArgs e)
        {
            //checks to see condition of book from 4 bool options
            string cond_ = "";

            if (condNew.Checked)
                cond_ = "New";
            else if (condGood.Checked)
                cond_ = "Good";
            else if (condFair.Checked)
                cond_ = "Fair";
            else if (condPoor.Checked)
                cond_ = "Poor";
            else
                cond_ = "";

            string constring = "datasource = " + db_type.db_hostname + ";port = " + db_type.db_port + "; Initial Catalog = '" + db_type.db_database + "'; username = " + db_type.db_username + "; password = " + db_type.db_pw;

            string Query = "";

            if (comboBookVsDvd.SelectedIndex == 0) //adding a book
            {
                Query = "INSERT INTO " + db_type.db_database + ".books (title,author,ISBN,genre,pageCount,location,bookCondition) values('" + check.sanitize(this.bookTitle.Text) + "','" + check.sanitize(this.author.Text) + "','" + check.sanitize(this.ISBN.Text) + "','" + check.sanitize(this.genre.Text) + "','" + check.sanitize(this.pageCount.Text) + "','" + check.sanitize(this.bookLocation.Text) + "','" + cond_ + "') ;";
            }

            else if (comboBookVsDvd.SelectedIndex == 1) //adding a dvd
            {
                Query = "INSERT INTO " + db_type.db_database + ".dvd (title,genre,year,rating,director,actors,location,dvdCondition) values('" + check.sanitize(this.dvdTitle.Text) + "','" + check.sanitize(this.dvdGenre.Text) + "','" + check.sanitize(this.dvdYear.Text) + "','" + check.sanitize(this.rating.Text) + "','" + check.sanitize(this.dvdDirector.Text) + "','" + check.sanitize(this.actors.Text) + "','" + check.sanitize(this.dvdLocation.Text) + "','" + cond_ + "') ;";
            }

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                if (comboBookVsDvd.SelectedIndex == 0)
                {
                    MessageBox.Show("Book Saved: \n" + "Title: " + check.sanitize(this.bookTitle.Text) +
                "\nAuthor: " + check.sanitize(this.author.Text) +
                "\nISBN: " + check.sanitize(this.ISBN.Text) +
                "\nGenre: " + check.sanitize(this.genre.Text) +
                "\nPage Count: " + check.sanitize(this.pageCount.Text) +
                "\nLocation: " + check.sanitize(this.bookLocation.Text) +
                "\nCondition: " + cond_
                );
                }

                else if (comboBookVsDvd.SelectedIndex == 1)
                {
                    MessageBox.Show("DVD Saved: \n" + "Title: " + check.sanitize(this.dvdTitle.Text) +
                "\nGenre: " + check.sanitize(this.dvdGenre.Text) +
                "\nYear: " + check.sanitize(this.dvdYear.Text) +
                "\nRating: " + check.sanitize(this.rating.Text) +
                "\nDirector: " + check.sanitize(this.dvdDirector.Text) +
                "\nActors: " + check.sanitize(this.actors.Text) + 
                "\nLocation: " + check.sanitize(this.dvdLocation.Text) +
                "\nCondition: " + cond_
                );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookTitle_TextChanged(object sender, EventArgs e)
        {
            string title = bookTitle.Text;
        }

        private void bookAddForm_Load(object sender, EventArgs e)
        {
            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();

            this.comboBookVsDvd.SelectedIndex = Properties.Settings.Default.addChoice;

            toolTip1.AutoPopDelay = 20000;

        }

        private void comboBookVsDvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();

            if (comboBookVsDvd.SelectedIndex == 0)
            {
                addBookPanel.Show();
            }
            else if (comboBookVsDvd.SelectedIndex == 1)
            {
                addDvdPanel.Show();
            }
        }
    }
}
