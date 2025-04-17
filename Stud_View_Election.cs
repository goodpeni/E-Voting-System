﻿using System;
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
    public partial class Stud_View_Election : Form
    {
        public Stud_View_Election()
        {
            InitializeComponent();
        }

        private void PicBoxCandidates_Click(object sender, EventArgs e)
        {
            Candidates formA51 = new Candidates();
            this.Hide();
            formA51.Show();
        }

        private void PicBoxPositions_Click(object sender, EventArgs e)
        {
            Positions formA52 = new Positions();
            this.Hide();
            formA52.Show();
        }

        private void PicBoxPartylists_Click(object sender, EventArgs e)
        {
            Partylists formA53 = new Partylists();
            this.Hide();
            formA53.Show();
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

        private void LblSideViewProfile_Click(object sender, EventArgs e)
        {
            Profile formA3 = new Profile();
            this.Hide();
            formA3.Show();
        }

        private void RdoLight_CheckedChanged(object sender, EventArgs e)
        {
            Stud_View_Election.ActiveForm.BackgroundImage = Properties.Resources.lightmode;
            PnlNavigation.BackColor = Color.LightSteelBlue;
            LblSideTitle.ForeColor = Color.Black;
            LblSidePositions.ForeColor = Color.Black;
            LblSidePartylists.ForeColor = Color.Black;
            LblSideVotersManual.ForeColor = Color.Black;
            LblSideViewElection.BackColor = Color.SteelBlue;
            LblSideHome.ForeColor = Color.Black;
            LblSideMyVote.ForeColor = Color.Black;
            LblSideViewElection.ForeColor = Color.Black;
            LblSideViewProfile.ForeColor = Color.Black;
            LblSideVoteNow.ForeColor = Color.Black;
            LblCandidates.ForeColor = Color.Black;
            LblSideCandidates.ForeColor = Color.Black;
            LblTheme.ForeColor = Color.Black;
            RdoDark.ForeColor = Color.Black;
            RdoLight.ForeColor = Color.Black;

            LblDescription.ForeColor = Color.Black;
            LblCandidates.ForeColor = Color.Black;
            LblCandidatesDesc.ForeColor = Color.Black;
            LblPartylists.ForeColor = Color.Black;
            LblPartylistsDesc.ForeColor = Color.Black;
            LblPositions.ForeColor = Color.Black;
            LblPositionsDesc.ForeColor = Color.Black;
            LblStatus.ForeColor = Color.Black;
        }

        private void RdoDark_CheckedChanged(object sender, EventArgs e)
        {
            Stud_View_Election.ActiveForm.BackgroundImage = Properties.Resources.darkmode;
            PnlNavigation.BackColor = Color.SteelBlue;
            LblSideTitle.ForeColor = Color.White;
            LblSidePositions.ForeColor = Color.White;
            LblSidePartylists.ForeColor = Color.White;
            LblSideVotersManual.ForeColor = Color.White;
            LblSideViewElection.BackColor = Color.LightSteelBlue;
            LblSideHome.ForeColor = Color.White;
            LblSideMyVote.ForeColor = Color.White;
            LblSideViewElection.ForeColor = Color.White;
            LblSideViewProfile.ForeColor = Color.White;
            LblSideVoteNow.ForeColor = Color.White;
            LblSideCandidates.ForeColor = Color.White;
            LblCandidates.ForeColor = Color.White;
            LblTheme.ForeColor = Color.White;
            RdoDark.ForeColor = Color.White;
            RdoLight.ForeColor = Color.White;

            LblDescription.ForeColor = Color.White;
            LblCandidates.ForeColor = Color.White;
            LblCandidatesDesc.ForeColor = Color.White;
            LblPartylists.ForeColor = Color.White;
            LblPartylistsDesc.ForeColor = Color.White;
            LblPositions.ForeColor = Color.White;
            LblPositionsDesc.ForeColor = Color.White;
            LblStatus.ForeColor = Color.White;
        }
    }
}
