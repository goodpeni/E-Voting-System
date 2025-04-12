using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblLogin.Left = (this.ClientSize.Width - lblLogin.Width) / 2;
            pnlMAIN.Left = (this.ClientSize.Width - pnlMAIN.Width) / 2;
            pnlMAIN.BackColor = Color.FromArgb(70, 0, 0, 0);
            lblStudentID.ForeColor = Color.White;
            lblPassword.ForeColor = Color.White;
            chkShowPass.ForeColor = Color.White;
        }

        private void Login()
        {
            if (txtStudentID.Text == "123456" && txtStudentPass.Text == "123456")
            {
                Form4 Form4 = new Form4();
                Form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Student ID or Password is Incorrect!");
                txtStudentID.Clear();
                txtStudentPass.Clear();
                chkShowPass.Checked = false;
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
                txtStudentPass.PasswordChar = '\0';
            }
            else
            {
                txtStudentPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
