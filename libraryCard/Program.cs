using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace libraryCard
{


    public static class db_type
    {
        public static string db_hostname;
        public static string db_port;
        public static string db_username;
        public static string db_pw;
        public static string db_database;
    }

    public static class check
    {
        public static string sanitize(string input)
        {

            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(input, @"[^\s\w\.@+\\-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters, 
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        public static bool checkedOut(string id, string selection)
        {
            List<string> outBooks = new List<string>(); //stores books that aren't checked out

            string constring = "datasource = " + db_type.db_hostname + ";port = " + db_type.db_port + "; Initial Catalog = '" + db_type.db_database + "'; username = " + db_type.db_username + "; password = " + db_type.db_pw;
            string queryBookCheck = "";
            if (selection == "book")
            {
                queryBookCheck = "SELECT COUNT(bookID) FROM books WHERE bookID=" + sanitize(id) + " AND status='out'"; //checks if book status is "out". 1 if true, 0 if false
            }
            else if (selection == "dvd")
            {
                queryBookCheck = "SELECT COUNT(dvdID) FROM dvd WHERE dvdID=" + sanitize(id) + " AND status='out'"; //checks if book status is "out". 1 if true, 0 if false
            }

            if (selection == "book" || selection == "dvd")
            {
                MySqlConnection conBookCheck = new MySqlConnection(constring);
                MySqlCommand cmdBookCheck = new MySqlCommand(queryBookCheck, conBookCheck);
                MySqlDataReader myReaderBookCheck;

                try
                {

                    conBookCheck.Open();

                    myReaderBookCheck = cmdBookCheck.ExecuteReader();

                    cmdBookCheck.CommandType = CommandType.Text;

                    for (int i = 0; myReaderBookCheck.Read(); i++)
                    {
                        outBooks.Add(myReaderBookCheck.GetString(0));
                    }

                    myReaderBookCheck.Close();

                    if (outBooks[0] == "0")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Make sure entered information is valid. Returning true.");
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Selection doesn't match book or dvd. Returning true.");
                return true;
            }

        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1()); // start program with the menu
            Application.Run(new logInForm()); // start program the login form
        }
    }
}
