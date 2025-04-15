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
    public partial class Student_Home : Form
    {
        public Student_Home()
        {
            InitializeComponent();
        }

        private void PicBoxOverview_Click(object sender, EventArgs e)
        {
            Overview FormA2 = new Overview();
            this.Hide();
            FormA2.Show();
        }

        private void PicBoxProfile_Click(object sender, EventArgs e)
        {
            Profile FormA3 = new Profile();
            this.Hide();
            FormA3.Show();
        }

        private void PicBoxVoteNow_Click(object sender, EventArgs e)
        {
            Vote_Now FormA4 = new Vote_Now();
            this.Hide();
            FormA4.Show();
        }

        private void PicBoxViewElection_Click(object sender, EventArgs e)
        {
            Stud_View_Election FormA5 = new Stud_View_Election();
            this.Hide();
            FormA5.Show();
        }

        private void PicBoxMyVote_Click(object sender, EventArgs e)
        {
            MyVote FormA6 = new MyVote();
            this.Hide();
            FormA6.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login_Interface form1 = new Login_Interface();
            this.Hide();
            form1.Show();
        }
    }
}
