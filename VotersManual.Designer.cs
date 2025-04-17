namespace E_Voting_System
{
    partial class VotersManual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VotersManual));
            PnlNavigation = new Panel();
            RdoDark = new RadioButton();
            RdoLight = new RadioButton();
            LblTheme = new Label();
            LblSideViewProfile = new Label();
            LblSideMyVote = new Label();
            LblSideVoteNow = new Label();
            LblSidePartylists = new Label();
            LblSidePositions = new Label();
            LblCandidates = new Label();
            LblSideViewElection = new Label();
            LblSideVotersManual = new Label();
            LblSideHome = new Label();
            LblSideTitle = new Label();
            PicBoxLogo = new PictureBox();
            LblGreetingTitle = new Label();
            LblIntroduction = new Label();
            LblLogin = new Label();
            LblLoginDesc = new Label();
            LblViewElection = new Label();
            LblViewElectionDesc = new Label();
            LblCastVote = new Label();
            LblCastVoteDesc = new Label();
            LblLogout = new Label();
            LblLogoutDesc = new Label();
            LblReviewChoices = new Label();
            LblReviewChangesDesc = new Label();
            LblSubmitVote = new Label();
            LblSubmitVoteDesc = new Label();
            PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlNavigation
            // 
            PnlNavigation.BackColor = Color.LightSteelBlue;
            PnlNavigation.Controls.Add(RdoDark);
            PnlNavigation.Controls.Add(RdoLight);
            PnlNavigation.Controls.Add(LblTheme);
            PnlNavigation.Controls.Add(LblSideViewProfile);
            PnlNavigation.Controls.Add(LblSideMyVote);
            PnlNavigation.Controls.Add(LblSideVoteNow);
            PnlNavigation.Controls.Add(LblSidePartylists);
            PnlNavigation.Controls.Add(LblSidePositions);
            PnlNavigation.Controls.Add(LblCandidates);
            PnlNavigation.Controls.Add(LblSideViewElection);
            PnlNavigation.Controls.Add(LblSideVotersManual);
            PnlNavigation.Controls.Add(LblSideHome);
            PnlNavigation.Controls.Add(LblSideTitle);
            PnlNavigation.Controls.Add(PicBoxLogo);
            PnlNavigation.Dock = DockStyle.Left;
            PnlNavigation.Location = new Point(0, 0);
            PnlNavigation.Margin = new Padding(3, 2, 3, 2);
            PnlNavigation.Name = "PnlNavigation";
            PnlNavigation.Size = new Size(348, 1041);
            PnlNavigation.TabIndex = 7;
            // 
            // RdoDark
            // 
            RdoDark.AutoSize = true;
            RdoDark.Cursor = Cursors.Hand;
            RdoDark.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            RdoDark.Location = new Point(77, 771);
            RdoDark.Margin = new Padding(3, 2, 3, 2);
            RdoDark.Name = "RdoDark";
            RdoDark.Size = new Size(63, 24);
            RdoDark.TabIndex = 30;
            RdoDark.TabStop = true;
            RdoDark.Text = "DARK";
            RdoDark.UseVisualStyleBackColor = true;
            RdoDark.CheckedChanged += RdoDark_CheckedChanged;
            // 
            // RdoLight
            // 
            RdoLight.AutoSize = true;
            RdoLight.Checked = true;
            RdoLight.Cursor = Cursors.Hand;
            RdoLight.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
            RdoLight.Location = new Point(77, 733);
            RdoLight.Margin = new Padding(3, 2, 3, 2);
            RdoLight.Name = "RdoLight";
            RdoLight.Size = new Size(66, 24);
            RdoLight.TabIndex = 29;
            RdoLight.TabStop = true;
            RdoLight.Text = "LIGHT";
            RdoLight.UseVisualStyleBackColor = true;
            RdoLight.CheckedChanged += RdoLight_CheckedChanged;
            // 
            // LblTheme
            // 
            LblTheme.Cursor = Cursors.Hand;
            LblTheme.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTheme.Location = new Point(0, 694);
            LblTheme.Name = "LblTheme";
            LblTheme.Size = new Size(348, 28);
            LblTheme.TabIndex = 28;
            LblTheme.Text = "               THEME";
            LblTheme.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideViewProfile
            // 
            LblSideViewProfile.Cursor = Cursors.Hand;
            LblSideViewProfile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideViewProfile.Location = new Point(0, 632);
            LblSideViewProfile.Name = "LblSideViewProfile";
            LblSideViewProfile.Size = new Size(348, 28);
            LblSideViewProfile.TabIndex = 27;
            LblSideViewProfile.Text = "               VIEW PROFILE";
            LblSideViewProfile.TextAlign = ContentAlignment.MiddleLeft;
            LblSideViewProfile.Click += LblSideViewProfile_Click;
            // 
            // LblSideMyVote
            // 
            LblSideMyVote.Cursor = Cursors.Hand;
            LblSideMyVote.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideMyVote.Location = new Point(0, 578);
            LblSideMyVote.Name = "LblSideMyVote";
            LblSideMyVote.Size = new Size(348, 28);
            LblSideMyVote.TabIndex = 26;
            LblSideMyVote.Text = "               MY VOTE";
            LblSideMyVote.TextAlign = ContentAlignment.MiddleLeft;
            LblSideMyVote.Click += LblSideMyVote_Click;
            // 
            // LblSideVoteNow
            // 
            LblSideVoteNow.Cursor = Cursors.Hand;
            LblSideVoteNow.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVoteNow.Location = new Point(0, 526);
            LblSideVoteNow.Name = "LblSideVoteNow";
            LblSideVoteNow.Size = new Size(348, 28);
            LblSideVoteNow.TabIndex = 25;
            LblSideVoteNow.Text = "               VOTE NOW";
            LblSideVoteNow.TextAlign = ContentAlignment.MiddleLeft;
            LblSideVoteNow.Click += LblSideVoteNow_Click;
            // 
            // LblSidePartylists
            // 
            LblSidePartylists.Cursor = Cursors.Hand;
            LblSidePartylists.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSidePartylists.Location = new Point(0, 472);
            LblSidePartylists.Name = "LblSidePartylists";
            LblSidePartylists.Size = new Size(348, 28);
            LblSidePartylists.TabIndex = 24;
            LblSidePartylists.Text = "                         PARTYLISTS";
            LblSidePartylists.TextAlign = ContentAlignment.MiddleLeft;
            LblSidePartylists.Click += LblSidePartylists_Click;
            // 
            // LblSidePositions
            // 
            LblSidePositions.Cursor = Cursors.Hand;
            LblSidePositions.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSidePositions.Location = new Point(0, 427);
            LblSidePositions.Name = "LblSidePositions";
            LblSidePositions.Size = new Size(348, 28);
            LblSidePositions.TabIndex = 23;
            LblSidePositions.Text = "                         POSITIONS";
            LblSidePositions.TextAlign = ContentAlignment.MiddleLeft;
            LblSidePositions.Click += LblSidePositions_Click;
            // 
            // LblCandidates
            // 
            LblCandidates.Cursor = Cursors.Hand;
            LblCandidates.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCandidates.Location = new Point(0, 381);
            LblCandidates.Name = "LblCandidates";
            LblCandidates.Size = new Size(348, 28);
            LblCandidates.TabIndex = 22;
            LblCandidates.Text = "                         CANDIDATES";
            LblCandidates.TextAlign = ContentAlignment.MiddleLeft;
            LblCandidates.Click += LblCandidates_Click;
            // 
            // LblSideViewElection
            // 
            LblSideViewElection.Cursor = Cursors.Hand;
            LblSideViewElection.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideViewElection.Location = new Point(0, 325);
            LblSideViewElection.Name = "LblSideViewElection";
            LblSideViewElection.Size = new Size(348, 28);
            LblSideViewElection.TabIndex = 21;
            LblSideViewElection.Text = "               VIEW ELECTION";
            LblSideViewElection.TextAlign = ContentAlignment.MiddleLeft;
            LblSideViewElection.Click += LblSideViewElection_Click;
            // 
            // LblSideVotersManual
            // 
            LblSideVotersManual.BackColor = Color.SteelBlue;
            LblSideVotersManual.Cursor = Cursors.Hand;
            LblSideVotersManual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVotersManual.Location = new Point(0, 263);
            LblSideVotersManual.Name = "LblSideVotersManual";
            LblSideVotersManual.Size = new Size(348, 28);
            LblSideVotersManual.TabIndex = 20;
            LblSideVotersManual.Text = "               VOTER'S MANUAL\r\n";
            LblSideVotersManual.TextAlign = ContentAlignment.MiddleLeft;
            LblSideVotersManual.Click += LblSideOverview_Click;
            // 
            // LblSideHome
            // 
            LblSideHome.Cursor = Cursors.Hand;
            LblSideHome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideHome.Location = new Point(0, 204);
            LblSideHome.Name = "LblSideHome";
            LblSideHome.Size = new Size(348, 28);
            LblSideHome.TabIndex = 19;
            LblSideHome.Text = "               HOME";
            LblSideHome.TextAlign = ContentAlignment.MiddleLeft;
            LblSideHome.Click += LblSideHome_Click;
            // 
            // LblSideTitle
            // 
            LblSideTitle.Cursor = Cursors.Hand;
            LblSideTitle.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideTitle.Location = new Point(105, 145);
            LblSideTitle.Name = "LblSideTitle";
            LblSideTitle.Size = new Size(138, 29);
            LblSideTitle.TabIndex = 18;
            LblSideTitle.Text = "HALAL 2025";
            LblSideTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PicBoxLogo
            // 
            PicBoxLogo.BackColor = Color.Transparent;
            PicBoxLogo.BackgroundImage = Properties.Resources.official_logo;
            PicBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxLogo.Location = new Point(105, 16);
            PicBoxLogo.Margin = new Padding(3, 2, 3, 2);
            PicBoxLogo.Name = "PicBoxLogo";
            PicBoxLogo.Size = new Size(138, 119);
            PicBoxLogo.TabIndex = 1;
            PicBoxLogo.TabStop = false;
            // 
            // LblGreetingTitle
            // 
            LblGreetingTitle.BackColor = Color.Transparent;
            LblGreetingTitle.Font = new Font("Arial Black", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblGreetingTitle.ForeColor = Color.Gold;
            LblGreetingTitle.Location = new Point(394, 9);
            LblGreetingTitle.Name = "LblGreetingTitle";
            LblGreetingTitle.Size = new Size(1473, 100);
            LblGreetingTitle.TabIndex = 8;
            LblGreetingTitle.Text = "VOTER'S MANUAL";
            LblGreetingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblIntroduction
            // 
            LblIntroduction.BackColor = Color.Transparent;
            LblIntroduction.Font = new Font("Arial Narrow", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblIntroduction.ForeColor = Color.Black;
            LblIntroduction.Location = new Point(393, 109);
            LblIntroduction.Name = "LblIntroduction";
            LblIntroduction.Size = new Size(1473, 85);
            LblIntroduction.TabIndex = 9;
            LblIntroduction.Text = "Welcome to the HALAL 2025 - E-Voting System! \r\nThis guide is designed to help you understand how to cast your vote easily and securely.\r\n";
            LblIntroduction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLogin
            // 
            LblLogin.BackColor = Color.Transparent;
            LblLogin.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLogin.ForeColor = Color.Firebrick;
            LblLogin.Location = new Point(526, 241);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(179, 55);
            LblLogin.TabIndex = 10;
            LblLogin.Text = "LOGIN";
            // 
            // LblLoginDesc
            // 
            LblLoginDesc.BackColor = Color.Transparent;
            LblLoginDesc.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLoginDesc.Location = new Point(526, 296);
            LblLoginDesc.Name = "LblLoginDesc";
            LblLoginDesc.Size = new Size(489, 52);
            LblLoginDesc.TabIndex = 11;
            LblLoginDesc.Text = "- Enter your student ID and password in the designated fields.\r\n- Press \"Enter\" or click on the \"LOGIN\" button to proceed. ";
            // 
            // LblViewElection
            // 
            LblViewElection.BackColor = Color.Transparent;
            LblViewElection.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblViewElection.ForeColor = Color.Firebrick;
            LblViewElection.Location = new Point(526, 427);
            LblViewElection.Name = "LblViewElection";
            LblViewElection.Size = new Size(539, 55);
            LblViewElection.TabIndex = 12;
            LblViewElection.Text = "VIEW ELECTION";
            // 
            // LblViewElectionDesc
            // 
            LblViewElectionDesc.BackColor = Color.Transparent;
            LblViewElectionDesc.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblViewElectionDesc.Location = new Point(526, 482);
            LblViewElectionDesc.Name = "LblViewElectionDesc";
            LblViewElectionDesc.Size = new Size(489, 170);
            LblViewElectionDesc.TabIndex = 13;
            LblViewElectionDesc.Text = resources.GetString("LblViewElectionDesc.Text");
            // 
            // LblCastVote
            // 
            LblCastVote.BackColor = Color.Transparent;
            LblCastVote.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCastVote.ForeColor = Color.Firebrick;
            LblCastVote.Location = new Point(525, 712);
            LblCastVote.Name = "LblCastVote";
            LblCastVote.Size = new Size(539, 55);
            LblCastVote.TabIndex = 14;
            LblCastVote.Text = "CAST YOUR VOTE";
            // 
            // LblCastVoteDesc
            // 
            LblCastVoteDesc.BackColor = Color.Transparent;
            LblCastVoteDesc.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCastVoteDesc.Location = new Point(525, 767);
            LblCastVoteDesc.Name = "LblCastVoteDesc";
            LblCastVoteDesc.Size = new Size(489, 193);
            LblCastVoteDesc.TabIndex = 15;
            LblCastVoteDesc.Text = resources.GetString("LblCastVoteDesc.Text");
            // 
            // LblLogout
            // 
            LblLogout.BackColor = Color.Transparent;
            LblLogout.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLogout.ForeColor = Color.Firebrick;
            LblLogout.Location = new Point(1133, 241);
            LblLogout.Name = "LblLogout";
            LblLogout.Size = new Size(234, 55);
            LblLogout.TabIndex = 16;
            LblLogout.Text = "LOGOUT";
            // 
            // LblLogoutDesc
            // 
            LblLogoutDesc.BackColor = Color.Transparent;
            LblLogoutDesc.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLogoutDesc.Location = new Point(1133, 296);
            LblLogoutDesc.Name = "LblLogoutDesc";
            LblLogoutDesc.Size = new Size(489, 52);
            LblLogoutDesc.TabIndex = 17;
            LblLogoutDesc.Text = "Once you have completed the voting process, click on the \"Logout\" button to securely exit the system.";
            // 
            // LblReviewChoices
            // 
            LblReviewChoices.BackColor = Color.Transparent;
            LblReviewChoices.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblReviewChoices.ForeColor = Color.Firebrick;
            LblReviewChoices.Location = new Point(1133, 427);
            LblReviewChoices.Name = "LblReviewChoices";
            LblReviewChoices.Size = new Size(609, 55);
            LblReviewChoices.TabIndex = 18;
            LblReviewChoices.Text = "REVIEW YOUR CHOICES";
            // 
            // LblReviewChangesDesc
            // 
            LblReviewChangesDesc.BackColor = Color.Transparent;
            LblReviewChangesDesc.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblReviewChangesDesc.Location = new Point(1133, 482);
            LblReviewChangesDesc.Name = "LblReviewChangesDesc";
            LblReviewChangesDesc.Size = new Size(609, 170);
            LblReviewChangesDesc.TabIndex = 19;
            LblReviewChangesDesc.Text = "Before finalizing your vote, you will have the opportunity to review your selections. \r\n\r\nIf you need to make changes, simply click the \"Edit\" button next to the position and modify your selection.";
            // 
            // LblSubmitVote
            // 
            LblSubmitVote.BackColor = Color.Transparent;
            LblSubmitVote.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSubmitVote.ForeColor = Color.Firebrick;
            LblSubmitVote.Location = new Point(1133, 704);
            LblSubmitVote.Name = "LblSubmitVote";
            LblSubmitVote.Size = new Size(609, 55);
            LblSubmitVote.TabIndex = 20;
            LblSubmitVote.Text = "VOTE SUBMISSION";
            // 
            // LblSubmitVoteDesc
            // 
            LblSubmitVoteDesc.BackColor = Color.Transparent;
            LblSubmitVoteDesc.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSubmitVoteDesc.Location = new Point(1133, 781);
            LblSubmitVoteDesc.Name = "LblSubmitVoteDesc";
            LblSubmitVoteDesc.Size = new Size(489, 193);
            LblSubmitVoteDesc.TabIndex = 21;
            LblSubmitVoteDesc.Text = "After reviewing your choices, click the \"Submit\" button to cast your vote.";
            // 
            // VotersManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lightmode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(LblSubmitVoteDesc);
            Controls.Add(LblSubmitVote);
            Controls.Add(LblReviewChangesDesc);
            Controls.Add(LblReviewChoices);
            Controls.Add(LblLogoutDesc);
            Controls.Add(LblLogout);
            Controls.Add(LblCastVoteDesc);
            Controls.Add(LblCastVote);
            Controls.Add(LblViewElectionDesc);
            Controls.Add(LblViewElection);
            Controls.Add(LblLoginDesc);
            Controls.Add(LblLogin);
            Controls.Add(LblIntroduction);
            Controls.Add(LblGreetingTitle);
            Controls.Add(PnlNavigation);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "VotersManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voter's Manual";
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlNavigation;
        private RadioButton RdoDark;
        private RadioButton RdoLight;
        private Label LblTheme;
        private Label LblSideViewProfile;
        private Label LblSideMyVote;
        private Label LblSideVoteNow;
        private Label LblSidePartylists;
        private Label LblSidePositions;
        private Label LblCandidates;
        private Label LblSideViewElection;
        private Label LblSideVotersManual;
        private Label LblSideHome;
        private Label LblSideTitle;
        private PictureBox PicBoxLogo;
        private Label LblGreetingTitle;
        private Label LblIntroduction;
        private Label LblLogin;
        private Label LblLoginDesc;
        private Label LblViewElection;
        private Label LblViewElectionDesc;
        private Label LblCastVote;
        private Label LblCastVoteDesc;
        private Label LblLogout;
        private Label LblLogoutDesc;
        private Label LblReviewChoices;
        private Label LblReviewChangesDesc;
        private Label LblSubmitVote;
        private Label LblSubmitVoteDesc;
    }
}