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
    public partial class bookEditForm : MetroFramework.Forms.MetroForm
    {
        string field_, edit_, table_, column_;

        private mainMenuForm mainForm = null;
        public bookEditForm(MetroFramework.Forms.MetroForm callingForm)
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
            foreach (Control lbl in bigEditPanelBook.Controls.OfType<GroupBox>())
                lbl.Hide();

            if (comboBox1.SelectedIndex == 0)
                isbnBox.Show();
            else if (comboBox1.SelectedIndex == 1)
                titleBox.Show();
            else if (comboBox1.SelectedIndex == 2)
                authorBox.Show();
            else if (comboBox1.SelectedIndex == 3)
                genreBox.Show();
            else if (comboBox1.SelectedIndex == 4)
                pageBox.Show();
            else if (comboBox1.SelectedIndex == 5)
                conditionBox.Show();
            else if (comboBox1.SelectedIndex == 6)
                bookLocationBox.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();
            foreach (Control lbl in bigEditPanelBook.Controls.OfType<GroupBox>())
                lbl.Hide();
            foreach (Control lbl in bigEditPanelDvd.Controls.OfType<GroupBox>())
                lbl.Hide();

            this.comboBookVsDvd.SelectedIndex = Properties.Settings.Default.editChoice;
        }

        private void comboBookVsDvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control gPanels in Controls.OfType<Panel>())
                gPanels.Hide();

            if (comboBookVsDvd.SelectedIndex == 0)
            {
                bigEditPanelBook.Show();
                foreach (Control lbl in bigEditPanelBook.Controls.OfType<GroupBox>())
                    lbl.Hide();
            }
            else if (comboBookVsDvd.SelectedIndex == 1)
            {
                bigEditPanelDvd.Show();
                foreach (Control lbl in bigEditPanelDvd.Controls.OfType<GroupBox>())
                    lbl.Hide();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control lbl in bigEditPanelDvd.Controls.OfType<GroupBox>())
                lbl.Hide();

            if (comboBox2.SelectedIndex == 0)
                dvdTitleBox.Show();
            else if (comboBox2.SelectedIndex == 1)
                directorBox.Show();
            else if (comboBox2.SelectedIndex == 2)
                actorsBox.Show();
            else if (comboBox2.SelectedIndex == 3)
                dvdGenreBox.Show();
            else if (comboBox2.SelectedIndex == 4)
                dvdYearBox.Show();
            else if (comboBox2.SelectedIndex == 5)
                ratingBox.Show();
            else if (comboBox2.SelectedIndex == 6)
                dvdConditionBox.Show();
            else if (comboBox2.SelectedIndex == 7)
                dvdLocationBox.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                if (comboBookVsDvd.SelectedIndex == 0)
                {
                    table_ = "books";
                    column_ = "bookID";
                    field_ = "";
                    edit_ = "";

                    switch (this.comboBox1.Text) //converts table options to database field names
                    {
                        //Books
                        case "Title":
                            field_ = "title";
                            edit_ = titleNum.Text;
                            break;
                        case "Author":
                            field_ = "author";
                            edit_ = author.Text;
                            break;
                        case "Genre":
                            field_ = "genre";
                            edit_ = genre.Text;
                            break;
                        case "ISBN":
                            field_ = "isbn";
                            edit_ = isbn.Text;
                            break;
                        case "Page Count":
                            field_ = "pageCount";
                            edit_ = page.Text;
                            break;
                        case "Location":
                            field_ = "location";
                            edit_ = bookLocation.Text;
                            break;
                        case "Condition":
                            field_ = "bookCondition";
                            if (condNew.Checked)
                                edit_ = "New";
                            else if (condGood.Checked)
                                edit_ = "Good";
                            else if (condFair.Checked)
                                edit_ = "Fair";
                            else if (condPoor.Checked)
                                edit_ = "Poor";
                            else
                                edit_ = "";
                            break;
                        case "":
                            field_ = "errorInFieldSwitch";
                            break;
                    }
                }

                else if (comboBookVsDvd.SelectedIndex == 1)
                {
                    table_ = "dvd";
                    column_ = "dvdID";

                    switch (this.comboBox2.Text) //converts English table options to database names
                    {
                        //DVDs
                        case "Title":
                            field_ = "title";
                            edit_ = dvdTitleNum.Text;
                            break;
                        case "Actors":
                            field_ = "actors";
                            edit_ = dvdActors.Text;
                            break;
                        case "Director":
                            field_ = "director";
                            edit_ = director.Text;
                            break;
                        case "Genre":
                            field_ = "genre";
                            edit_ = dvdGenre.Text;
                            break;
                        case "Year":
                            field_ = "year";
                            edit_ = dvdYear.Text;
                            break;
                        case "Rating":
                            field_ = "rating";
                            edit_ = rating.Text;
                            break;
                        case "Location":
                            field_ = "location";
                            edit_ = dvdLocation.Text;
                            break;
                        case "Condition":
                            field_ = "dvdCondition";
                            if (dvdCondNew.Checked)
                                edit_ = "New";
                            else if (dvdCondGood.Checked)
                                edit_ = "Good";
                            else if (dvdCondFair.Checked)
                                edit_ = "Fair";
                            else if (dvdCondPoor.Checked)
                                edit_ = "Poor";
                            else
                                edit_ = "";
                            break;
                        case "":
                            field_ = "errorInFieldSwitch";
                            break;
                    }
                }

                string constring = "datasource=" + db_type.db_hostname + ";port=" + db_type.db_port + ";username=" + db_type.db_username + ";password=" + db_type.db_pw;
                string Query = "USE " + db_type.db_database + "; UPDATE " + table_ + " SET " + field_ + "=\"" + check.sanitize(edit_) + "\" WHERE " + column_ + "=" + check.sanitize(this.id.Text) + " ;";
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
                    MessageBox.Show("Edited.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Make sure the product ID is valid.");
                }
            }
            else
            {
                MessageBox.Show("Enter an ID.");
            }

        }
    }
}
