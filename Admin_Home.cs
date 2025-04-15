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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void PicBoxDashboard_Click(object sender, EventArgs e)
        {
            Dashboard formB2 = new Dashboard();
            this.Hide();
            formB2.Show();
        }

        private void PicBoxViewElection_Click(object sender, EventArgs e)
        {
            View_Election formB3 = new View_Election();
            this.Hide();
            formB3.Show();
        }

        private void PicBoxManCand_Click(object sender, EventArgs e)
        {
            Manage_Candidates formB4 = new Manage_Candidates();
            this.Hide();
            formB4.Show();
        }

        private void PicBoxManStud_Click_1(object sender, EventArgs e)
        {
            Manage_Students formB5 = new Manage_Students();
            this.Hide();
            formB5.Show();
        }

        private void PicBoxManParty_Click(object sender, EventArgs e)
        {
            Manage_Partylists formB6 = new Manage_Partylists();
            this.Hide();
            formB6.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login_Interface form1 = new Login_Interface();
            this.Hide();
            form1.Show();
        }
    }
}
