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
    public partial class Positions : Form
    {
        public Positions()
        {
            InitializeComponent();
        }

        private void LblSideHome_Click(object sender, EventArgs e)
        {
            Student_Home formA1 = new Student_Home();
            this.Hide();
            formA1.Show();
        }

        private void LblSideVotersManual_Click(object sender, EventArgs e)
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

        private void LblSideViewProfile_Click(object sender, EventArgs e)
        {
            Profile formA3 = new Profile();
            this.Hide();
            formA3.Show();
        }

        private void RdoLight_CheckedChanged(object sender, EventArgs e)
        {
            PicBoxPres.BackgroundImage = Properties.Resources.user;
            PicBoxVice.BackgroundImage = Properties.Resources.user;
            PicBoxSec.BackgroundImage = Properties.Resources.user;
            PicBoxTreas.BackgroundImage = Properties.Resources.user;
            PicBoxAudi.BackgroundImage = Properties.Resources.user;
            PicBoxPO1.BackgroundImage = Properties.Resources.user;
            PicBoxPO2.BackgroundImage = Properties.Resources.user;
            PicBoxPIO.BackgroundImage = Properties.Resources.user;
            PicBoxG4Repre.BackgroundImage = Properties.Resources.user;
            PicBoxG5Repre.BackgroundImage = Properties.Resources.user;
            PicBoxG6Repre.BackgroundImage = Properties.Resources.user;

            Positions.ActiveForm.BackgroundImage = Properties.Resources.lightmode;
            PnlNavigation.BackColor = Color.LightSteelBlue;
            LblSideTitle.ForeColor = Color.Black;
            LblSidePositions.ForeColor = Color.Black;
            LblSidePartylists.ForeColor = Color.Black;
            LblSideVotersManual.ForeColor = Color.Black;
            LblSideHome.ForeColor = Color.Black;
            LblSidePositions.BackColor = Color.SteelBlue;
            LblSideMyVote.ForeColor = Color.Black;
            LblSideViewElection.ForeColor = Color.Black;
            LblSideViewProfile.ForeColor = Color.Black;
            LblSideVoteNow.ForeColor = Color.Black;
            LblSideCandidates.ForeColor = Color.Black;
            LblTheme.ForeColor = Color.Black;
            RdoDark.ForeColor = Color.Black;
            RdoLight.ForeColor = Color.Black;

            LblPres.ForeColor = Color.Black;
            LblVice.ForeColor = Color.Black;
            LblSec.ForeColor = Color.Black;
            LblTreas.ForeColor = Color.Black;
            LblAudi.ForeColor = Color.Black;
            LblPO1.ForeColor = Color.Black;
            LblPO2.ForeColor = Color.Black;
            LblPIO.ForeColor = Color.Black;
            LblG4Repre.ForeColor = Color.Black;
            LblG5Repre.ForeColor = Color.Black;
            LblG6Repre.ForeColor = Color.Black;

            LblPresDesc.ForeColor = Color.Black;
            LblViceDesc.ForeColor = Color.Black;
            LblSecDesc.ForeColor = Color.Black;
            LblTreasDesc.ForeColor = Color.Black;
            LblAudiDesc.ForeColor = Color.Black;
            LblPO1Desc.ForeColor = Color.Black;
            LblPO2Desc.ForeColor = Color.Black;
            LblPIODesc.ForeColor = Color.Black;
            LblG4RepreDesc.ForeColor = Color.Black;
            LblG5RepreDesc.ForeColor = Color.Black;
            LblG6RepreDesc.ForeColor = Color.Black;
        }

        private void RdoDark_CheckedChanged(object sender, EventArgs e)
        {
            PicBoxPres.BackgroundImage = Properties.Resources.userlighter;
            PicBoxVice.BackgroundImage = Properties.Resources.userlighter;
            PicBoxSec.BackgroundImage = Properties.Resources.userlighter;
            PicBoxTreas.BackgroundImage = Properties.Resources.userlighter;
            PicBoxAudi.BackgroundImage = Properties.Resources.userlighter;
            PicBoxPO1.BackgroundImage = Properties.Resources.userlighter;
            PicBoxPO2.BackgroundImage = Properties.Resources.userlighter;
            PicBoxPIO.BackgroundImage = Properties.Resources.userlighter;
            PicBoxG4Repre.BackgroundImage = Properties.Resources.userlighter;
            PicBoxG5Repre.BackgroundImage = Properties.Resources.userlighter;
            PicBoxG6Repre.BackgroundImage = Properties.Resources.userlighter;

            Positions.ActiveForm.BackgroundImage = Properties.Resources.darkmode;
            PnlNavigation.BackColor = Color.SteelBlue;
            LblSideTitle.ForeColor = Color.White;
            LblSidePositions.ForeColor = Color.White;
            LblSidePartylists.ForeColor = Color.White;
            LblSideVotersManual.ForeColor = Color.White;
            LblSideHome.ForeColor = Color.White;
            LblSidePositions.BackColor = Color.LightSteelBlue;
            LblSideMyVote.ForeColor = Color.White;
            LblSideViewElection.ForeColor = Color.White;
            LblSideViewProfile.ForeColor = Color.White;
            LblSideVoteNow.ForeColor = Color.White;
            LblSideCandidates.ForeColor = Color.White;
            LblTheme.ForeColor = Color.White;
            RdoDark.ForeColor = Color.White;
            RdoLight.ForeColor = Color.White;

            LblPres.ForeColor = Color.White;
            LblVice.ForeColor = Color.White;
            LblSec.ForeColor = Color.White;
            LblTreas.ForeColor = Color.White;
            LblAudi.ForeColor = Color.White;
            LblPO1.ForeColor = Color.White;
            LblPO2.ForeColor = Color.White;
            LblPIO.ForeColor = Color.White;
            LblG4Repre.ForeColor = Color.White;
            LblG5Repre.ForeColor = Color.White;
            LblG6Repre.ForeColor = Color.White;

            LblPresDesc.ForeColor = Color.White;
            LblViceDesc.ForeColor = Color.White;
            LblSecDesc.ForeColor = Color.White;
            LblTreasDesc.ForeColor = Color.White;
            LblAudiDesc.ForeColor = Color.White;
            LblPO1Desc.ForeColor = Color.White;
            LblPO2Desc.ForeColor = Color.White;
            LblPIODesc.ForeColor = Color.White;
            LblG4RepreDesc.ForeColor = Color.White;
            LblG5RepreDesc.ForeColor = Color.White;
            LblG6RepreDesc.ForeColor = Color.White;
        }

        private void PnlPIO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblInfo_Click(object sender, EventArgs e)
        {
            AboutUs formA7 = new AboutUs();
            this.Hide();
            formA7.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login_Interface form1 = new Login_Interface();
            this.Hide();
            form1.Show();
        }

        private void PnlNavigation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
