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


namespace prototype_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            USERTEXT.Text = "USERNAME";
            PASSTEXT.Text = "PASSWORD";
            
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string sql = "SELECT USERNAME, password_1 FROM login WHERE USERNAME = '"+USERNAME.Text+"';";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=prototype;");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string username = reader.GetString("USERNAME");
              string password = reader.GetString("password_1");
                MessageBox.Show(username +" "+ password);
            }

        }

        private void SIGN_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            

        }

        private void USERNAME_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void USERTEXT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
