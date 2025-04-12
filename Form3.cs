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

namespace E_Voting_System
{
    public partial class Form3 : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=EVotingDB";

        public Form3()
        {
            InitializeComponent();
        }

        public void Login()
        {
            string query = "SELECT * FROM admin_info WHERE admin_id = '" + txtAdminID.Text + "'AND admin_password = '" + txtAdminPass.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Login Success!");
                        Form7 Form7 = new Form7();
                        Form7.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Oops! Something went wrong. Please try again!");
                    txtAdminID.Clear();
                    txtAdminPass.Clear();
                    chkShowPass.Checked = false;
                }
                databaseConnection.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtAdminPass.PasswordChar = '\0';
            }
            else
            {
                txtAdminPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();          
        }
    }
}

