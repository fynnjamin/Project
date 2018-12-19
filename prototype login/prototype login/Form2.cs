using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace prototype_login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            first_name.Text = "FIRST NAME";
            last_name.Text = "LAST NAME";
            USERNAME.Text = "USERNAME";
            PASSWORD.Text = "PASSWORD";
            string text = PASSWORD.Text;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void USERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void PASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void fisrtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DONE_Click(object sender, EventArgs e)
        {
            string newFileName = "//pfa.education/utccstudentusers$/15u-fcampbell/Documents/COMP/project/prototype login/PROTOTYPE1.csv";
            
            string clientDetails = " "+ "," + fisrtname.Text + "," + lastname.Text + "," + user.Text + "," + Password_1.Text;


          

            File.AppendAllText(newFileName, clientDetails);
            MessageBox.Show("YOU HAVE CREATED AN ACCOUNT");

            string connStr = "server=localhost;username=root;password=;database=prototype";
            MySqlConnection conn = new MySqlConnection(connStr);
            string file = "//pfa.education/utccstudentusers$/15u-fcampbell/Documents/COMP/project/prototype login/PROTOTYPE1.csv";

            MySqlBulkLoader bl = new MySqlBulkLoader(conn);
            bl.TableName = "login";
            bl.FieldTerminator = ","; //This can be { comma,tab,semi colon, or other character}
            bl.LineTerminator = "\r\n";
            bl.FileName = file;


            try
            {
                MessageBox.Show("Connecting to MySQL...");
                conn.Open();

                // Upload data from file
                int count = bl.Load();
                MessageBox.Show(count + " lines uploaded.");

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            MessageBox.Show("done");
            File.Delete(file);

            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }
        private static string GenerateHashString(HashAlgorithm algo, string text)
        {
            // Compute hash from text parameter
            algo.ComputeHash(Encoding.UTF8.GetBytes(text));

            // Get has value in array of bytes
            var result = algo.Hash;

            // Return as hexadecimal string
            return string.Join(
                string.Empty,
                result.Select(x => x.ToString("x2")));
        }
    }
}
