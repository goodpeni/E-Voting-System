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


        private string Greetings()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 5 && hour < 12)
            {
                return "Good morning";
            }
            else if (hour >= 12 && hour < 18)
            {
                return "Good afternoon";
            }
            else
            {
                return "Good evening";
            }
        }


        private void PicBoxOverview_Click(object sender, EventArgs e)
        {
            Overview FormA2 = new Overview();
            this.Hide();
            FormA2.Show();
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

        private void LblSideViewProfile_Click(object sender, EventArgs e)
        {
            Profile FormA3 = new Profile();
            this.Hide();
            FormA3.Show();
        }

        private void RdoLight_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoLight.Checked)
            {
                Student_Home.ActiveForm.BackColor = Color.White;
            }
        }

        private void RdoDark_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoDark.Checked)
            {
                Student_Home.ActiveForm.BackColor = Color.LightGray;
            }
        }

        private void Student_Home_Load(object sender, EventArgs e)
        {
            LblSideHome.BackColor = Color.SteelBlue;

            string greet = Greetings();
            LblGreetings.Text = $"{greet}, Student!";
        }

        private void LblSideOverview_Click(object sender, EventArgs e)
        {
            Overview formA2 = new Overview();
            this.Hide();
            formA2.Show();
        }

        private void LblSideViewElection_Click(object sender, EventArgs e)
        {
            Stud_View_Election formA5 = new Stud_View_Election();
            this.Hide();
            formA5.Show();
        }

        private void LblCandidates_Click(object sender, EventArgs e)
        {
            Candidates formA51 = new Candidates();
            this.Hide();
            formA51.Show();
        }

        private void LblSidePositions_Click(object sender, EventArgs e)
        {
            Positions formA52 = new Positions();
            this.Hide();
            formA52.Show();
        }

        private void LblSidePartylists_Click(object sender, EventArgs e)
        {
            Partylists formA53 = new Partylists();
            this.Hide();
            formA53.Show();
        }

        private void LblSideVoteNow_Click(object sender, EventArgs e)
        {
            Vote_Now formA4 = new Vote_Now();
            this.Hide();
            formA4.Show();
        }

        private void LblSideMyVote_Click(object sender, EventArgs e)
        {
            MyVote formA6 = new MyVote();
            this.Hide();
            formA6.Show();
        }

        private void LblInfo_Click(object sender, EventArgs e)
        {
            AboutUs formA7 = new AboutUs();
            this.Hide();
            formA7.Show();
        }

        private void PnlOverview_Paint(object sender, PaintEventArgs e)
        {
            Overview FormA2 = new Overview();
            this.Hide();
            FormA2.Show();
        }

        private void PnlViewElection_Paint(object sender, PaintEventArgs e)
        {
            Stud_View_Election FormA5 = new Stud_View_Election();
            this.Hide();
            FormA5.Show();
        }

        private void PnlMyVote_Paint(object sender, PaintEventArgs e)
        {
            MyVote FormA6 = new MyVote();
            this.Hide();
            FormA6.Show();
        }

        private void PnlVoteNow_Paint(object sender, PaintEventArgs e)
        {
            Vote_Now FormA4 = new Vote_Now();
            this.Hide();
            FormA4.Show();
        }
    }
}
