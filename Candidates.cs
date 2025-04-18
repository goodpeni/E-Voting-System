using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;

namespace E_Voting_System
{
    public partial class Candidates : Form
    {
        public Candidates()
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

        private void LblSideViewProfile_Click(object sender, EventArgs e)
        {
            Profile formA3 = new Profile();
            this.Hide();
            formA3.Show();
        }

        private void RdoLight_CheckedChanged(object sender, EventArgs e)
        {
            Candidates.ActiveForm.BackgroundImage = Properties.Resources.lightmode;
            PnlNavigation.BackColor = Color.LightSteelBlue;
            LblSideTitle.ForeColor = Color.Black;
            LblSidePositions.ForeColor = Color.Black;
            LblSidePartylists.ForeColor = Color.Black;
            LblSideVotersManual.ForeColor = Color.Black;
            LblSideHome.ForeColor = Color.Black;
            LblCandidates.BackColor = Color.SteelBlue;
            LblSideMyVote.ForeColor = Color.Black;
            LblSideViewElection.ForeColor = Color.Black;
            LblSideViewProfile.ForeColor = Color.Black;
            LblSideVoteNow.ForeColor = Color.Black;
            LblCandidates.ForeColor = Color.Black;
            LblTheme.ForeColor = Color.Black;
            RdoDark.ForeColor = Color.Black;
            RdoLight.ForeColor = Color.Black;

            LblFilter.ForeColor = Color.Black;
            LblName1.ForeColor = Color.Black;
            LblName2.ForeColor = Color.Black;
            LblName3.ForeColor = Color.Black;
            LblName4.ForeColor = Color.Black;
            LblName5.ForeColor = Color.Black;
            LblName6.ForeColor = Color.Black;
            LblPosition1.ForeColor = Color.Black;
            LblPosition2.ForeColor = Color.Black;
            LblPosition3.ForeColor = Color.Black;
            LblPosition4.ForeColor = Color.Black;
            LblPosition5.ForeColor = Color.Black;
            LblPosition6.ForeColor = Color.Black;
            LblGradeSection1.ForeColor = Color.Black;
            LblGradeSection2.ForeColor = Color.Black;
            LblGradeSection3.ForeColor = Color.Black;
            LblGradeSection4.ForeColor = Color.Black;
            LblGradeSection5.ForeColor = Color.Black;
            lblGradeSection6.ForeColor = Color.Black;
            LblPartylist1.ForeColor = Color.Black;
            LblPartylist2.ForeColor = Color.Black;
            LblPartylist3.ForeColor = Color.Black;
            LblPartylist4.ForeColor = Color.Black;
            LblPartylist5.ForeColor = Color.Black;
            LblPartylist6.ForeColor = Color.Black;


        }

        private void RdoDark_CheckedChanged(object sender, EventArgs e)
        {
            Candidates.ActiveForm.BackgroundImage = Properties.Resources.darkmode;
            PnlNavigation.BackColor = Color.SteelBlue;
            LblSideTitle.ForeColor = Color.White;
            LblSidePositions.ForeColor = Color.White;
            LblSidePartylists.ForeColor = Color.White;
            LblSideVotersManual.ForeColor = Color.White;
            LblSideHome.ForeColor = Color.White;
            LblCandidates.BackColor = Color.LightSteelBlue;
            LblSideMyVote.ForeColor = Color.White;
            LblSideViewElection.ForeColor = Color.White;
            LblSideViewProfile.ForeColor = Color.White;
            LblSideVoteNow.ForeColor = Color.White;
            LblCandidates.ForeColor = Color.White;
            LblTheme.ForeColor = Color.White;
            RdoDark.ForeColor = Color.White;
            RdoLight.ForeColor = Color.White;

            LblFilter.ForeColor = Color.White;
            LblName1.ForeColor = Color.White;
            LblName2.ForeColor = Color.White;
            LblName3.ForeColor = Color.White;
            LblName4.ForeColor = Color.White;
            LblName5.ForeColor = Color.White;
            LblName6.ForeColor = Color.White;
            LblPosition1.ForeColor = Color.White;
            LblPosition2.ForeColor = Color.White;
            LblPosition3.ForeColor = Color.White;
            LblPosition4.ForeColor = Color.White;
            LblPosition5.ForeColor = Color.White;
            LblPosition6.ForeColor = Color.White;
            LblGradeSection1.ForeColor = Color.White;
            LblGradeSection2.ForeColor = Color.White;
            LblGradeSection3.ForeColor = Color.White;
            LblGradeSection4.ForeColor = Color.White;
            LblGradeSection5.ForeColor = Color.White;
            lblGradeSection6.ForeColor = Color.White;
            LblPartylist1.ForeColor = Color.White;
            LblPartylist2.ForeColor = Color.White;
            LblPartylist3.ForeColor = Color.White;
            LblPartylist4.ForeColor = Color.White;
            LblPartylist5.ForeColor = Color.White;
            LblPartylist6.ForeColor = Color.White;
        }

        private void BtnVoteNow_Click(object sender, EventArgs e)
        {
            Vote_Now formA4 = new Vote_Now();
            this.Hide();
            formA4.Show();
        }
    }
}
