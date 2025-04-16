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
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=evotingdb";

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
            string adminQuery = "SELECT * FROM admin WHERE admin_name = @id AND admin_password = @pass";
            string studentQuery = "SELECT * FROM student WHERE student_id = @id AND student_password = @pass";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand studentCmd = new MySqlCommand(studentQuery, connection))
                    {
                        studentCmd.Parameters.AddWithValue("@id", TxtUserID.Text);
                        studentCmd.Parameters.AddWithValue("@pass", TxtPass.Text);

                        using (MySqlDataReader studentReader = studentCmd.ExecuteReader())
                        {
                            if (studentReader.Read())
                            {
                                MessageBox.Show("Login Success! (Student)");
                                Student_Home studentForm = new Student_Home();
                                this.Hide();
                                studentForm.Show();
                                return;
                            }
                        }
                    }

                    using (MySqlCommand adminCmd = new MySqlCommand(adminQuery, connection))
                    {
                        adminCmd.Parameters.AddWithValue("@id", TxtUserID.Text);
                        adminCmd.Parameters.AddWithValue("@pass", TxtPass.Text);

                        using (MySqlDataReader adminReader = adminCmd.ExecuteReader())
                        {
                            if (adminReader.Read())
                            {
                                MessageBox.Show("Login Success! (Admin)");
                                Admin_Home adminForm = new Admin_Home();
                                this.Hide();
                                adminForm.Show();
                                return;
                            }
                        }
                    }

                    MessageBox.Show("Oops! Something went wrong. Please try again!");
                    TxtUserID.Clear();
                    TxtPass.Clear();
                    chkShowPass.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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

