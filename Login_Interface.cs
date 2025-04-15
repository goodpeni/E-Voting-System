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
    public partial class Login_Interface : Form
    {
        bool passVisible = false;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=EVotingDB";

        public Login_Interface()
        {
            InitializeComponent();
            LblTitle1.Left = (this.ClientSize.Width - LblTitle1.Width) / 2;
            LblTitle2.Left = (this.ClientSize.Width - LblTitle2.Width) / 2;
            PnlAdmin.Left = (this.ClientSize.Width - PnlAdmin.Width) / 2;
            PnlAdmin.BackColor = Color.FromArgb(70, 0, 0, 0);
        }


        public void Login()
        {
            string query = "SELECT * FROM admin_info WHERE admin_id = '" + TxtUserID.Text + "'AND admin_password = '" + TxtPass.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (TxtUserID.Text == "123456" && TxtPass.Text == "123456")
                {
                    MessageBox.Show("Login Success!");
                    Student_Home formA1 = new Student_Home();
                    this.Hide();
                    formA1.Show();
                }
                
                else if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Login Success!");
                        Admin_Home formB1 = new Admin_Home();
                        this.Hide();
                        formB1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Oops! Something went wrong. Please try again!");
                    TxtUserID.Clear();
                    TxtPass.Clear();
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
            Application.Exit();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                TxtPass.PasswordChar = '\0';
                PicBoxClosed.BackgroundImage = Properties.Resources.view;
            }
            else
            {
                TxtPass.PasswordChar = '*';
                PicBoxClosed.BackgroundImage = Properties.Resources.eye;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

     
    }
}

