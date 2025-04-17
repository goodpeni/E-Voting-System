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
    public partial class Profile : Form
    {
        public Profile()
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

        private void RdoLight_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoLight.Checked)
            {
                Profile.ActiveForm.BackgroundImage = Properties.Resources.lightmode;
                PnlNavigation.BackColor = Color.LightSteelBlue;
                LblSideTitle.ForeColor = Color.Black;
                LblSidePositions.ForeColor = Color.Black;
                LblSidePartylists.ForeColor = Color.Black;
                LblSideVotersManual.ForeColor = Color.Black;
                LblSideHome.ForeColor = Color.Black;
                LblSideMyVote.ForeColor = Color.Black;
                LblSideViewElection.ForeColor = Color.Black;
                LblSideViewProfile.ForeColor = Color.Black;
                LblSideViewProfile.BackColor = Color.SteelBlue;
                LblSideVoteNow.ForeColor = Color.Black;
                LblCandidates.ForeColor = Color.Black;
                LblTheme.ForeColor = Color.Black;
                RdoDark.ForeColor = Color.Black;
                RdoLight.ForeColor = Color.Black;

                LblStudentID.ForeColor = Color.Black;
                LblLastName.ForeColor = Color.Black;
                LblFirstName.ForeColor = Color.Black;
                LblMiddleName.ForeColor = Color.Black;
                LblAge.ForeColor = Color.Black;
                LblSex.ForeColor = Color.Black;
                LblGradeSection.ForeColor = Color.Black;
            }
        }

        private void RdoDark_CheckedChanged(object sender, EventArgs e)
        {
            Profile.ActiveForm.BackgroundImage = Properties.Resources.darkmode;
            PnlNavigation.BackColor = Color.SteelBlue;
            LblSideTitle.ForeColor = Color.White;
            LblSidePositions.ForeColor = Color.White;
            LblSidePartylists.ForeColor = Color.Black;
            LblSideVotersManual.ForeColor = Color.White;
            LblSideHome.ForeColor = Color.White;
            LblSideMyVote.ForeColor = Color.White;
            LblSideViewElection.ForeColor = Color.White;
            LblSideViewProfile.ForeColor = Color.White;
            LblSideViewProfile.BackColor = Color.LightSteelBlue;
            LblSideVoteNow.ForeColor = Color.White;
            LblCandidates.ForeColor = Color.White;
            LblTheme.ForeColor = Color.White;
            RdoDark.ForeColor = Color.White;
            RdoLight.ForeColor = Color.White;

            LblStudentID.ForeColor = Color.White;
            LblLastName.ForeColor = Color.White;
            LblFirstName.ForeColor = Color.White;
            LblMiddleName.ForeColor = Color.White;
            LblAge.ForeColor = Color.White;
            LblSex.ForeColor = Color.White;
            LblGradeSection.ForeColor = Color.White;
        }
    }
}
