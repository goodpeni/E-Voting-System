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
            VotersManual FormA2 = new VotersManual();
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
                Student_Home.ActiveForm.BackgroundImage = Properties.Resources.lightmode;
                PnlNavigation.BackColor = Color.LightSteelBlue;
                LblSideTitle.ForeColor = Color.Black;
                LblSidePositions.ForeColor = Color.Black;
                LblSidePartylists.ForeColor = Color.Black;
                LblSideVotersManual.ForeColor = Color.Black;
                LblSideHome.ForeColor = Color.Black;
                LblSideHome.BackColor = Color.SteelBlue;
                LblSideMyVote.ForeColor = Color.Black;
                LblSideViewElection.ForeColor = Color.Black;
                LblSideViewProfile.ForeColor = Color.Black;
                LblSideVoteNow.ForeColor = Color.Black;
                LblCandidates.ForeColor = Color.Black;
                LblInfo.ForeColor = Color.Black;
                LblTheme.ForeColor = Color.Black;
                RdoDark.ForeColor = Color.Black;
                RdoLight.ForeColor = Color.Black;


                LblDescription.ForeColor = Color.Black;
                LblGreetings.ForeColor = Color.Black;
                LblYLevel.ForeColor = Color.Black;
                LblReadyToVote.ForeColor = Color.Black;
                LblOverview.ForeColor = Color.Black;
                LblVotersManualDesc.ForeColor = Color.Black;
                LblViewElection.ForeColor = Color.Black;
                LblViewElectionDesc.ForeColor = Color.Black;
                LblMyVote.ForeColor = Color.Black;
                LblMyVoteDesc.ForeColor = Color.Black;
                LblStatus.ForeColor = Color.Black;

                BtnLogout.BackgroundImage = Properties.Resources.power_off;
            }
        }

        private void RdoDark_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoDark.Checked)
            {
                Student_Home.ActiveForm.BackgroundImage = Properties.Resources.darkmode;
                PnlNavigation.BackColor = Color.SteelBlue;
                LblSideTitle.ForeColor = Color.White;
                LblSidePositions.ForeColor = Color.White;
                LblSidePartylists.ForeColor = Color.White;
                LblSideVotersManual.ForeColor = Color.White;
                LblSideHome.ForeColor = Color.White;
                LblSideHome.BackColor = Color.LightSteelBlue;
                LblSideMyVote.ForeColor = Color.White;
                LblSideViewElection.ForeColor = Color.White;
                LblSideViewProfile.ForeColor = Color.White;
                LblSideVoteNow.ForeColor = Color.White;
                LblCandidates.ForeColor = Color.White;
                LblInfo.ForeColor = Color.White;
                LblTheme.ForeColor = Color.White;
                RdoDark.ForeColor = Color.White;
                RdoLight.ForeColor = Color.White;


                LblDescription.ForeColor = Color.White;
                LblGreetings.ForeColor = Color.White;
                LblYLevel.ForeColor = Color.White;
                LblReadyToVote.ForeColor = Color.White;
                LblOverview.ForeColor = Color.White;
                LblVotersManualDesc.ForeColor = Color.White;
                LblViewElection.ForeColor = Color.White;
                LblViewElectionDesc.ForeColor = Color.White;
                LblMyVote.ForeColor = Color.White;
                LblMyVoteDesc.ForeColor = Color.White;
                LblStatus.ForeColor = Color.White;
                RdoLight.Checked = false;

                BtnLogout.BackgroundImage = Properties.Resources.power_off_light;

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
            VotersManual formA2 = new VotersManual();
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

        private void BtnVoteNow_Click(object sender, EventArgs e)
        {
            Vote_Now FormA4 = new Vote_Now();
            this.Hide();
            FormA4.Show();
        }

        private void PnlOverview_Click(object sender, EventArgs e)
        {
            VotersManual FormA2 = new VotersManual();
            this.Hide();
            FormA2.Show();
        }

        private void PnlViewElection_Click(object sender, EventArgs e)
        {
            Stud_View_Election FormA5 = new Stud_View_Election();
            this.Hide();
            FormA5.Show();
        }

        private void PnlMyVote_Click(object sender, EventArgs e)
        {
            MyVote FormA6 = new MyVote();
            this.Hide();
            FormA6.Show();
        }

    }
}
