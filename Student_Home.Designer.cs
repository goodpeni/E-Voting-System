namespace E_Voting_System
{
    partial class Student_Home
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
            PicBoxOverview = new PictureBox();
            PicBoxLogo = new PictureBox();
            PicBoxVoteNow = new PictureBox();
            PicBoxViewElection = new PictureBox();
            PicBoxMyVote = new PictureBox();
            BtnLogout = new Button();
            PnlNavigation = new Panel();
            LblInfo = new Label();
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
            LblSideOverview = new Label();
            LblSideHome = new Label();
            LblSideTitle = new Label();
            LblTitle = new Label();
            LblStatus = new Label();
            LblGreetings = new Label();
            LblYLevel = new Label();
            LblDescription = new Label();
            LblOverview = new Label();
            LblViewElection = new Label();
            LblVoteNow = new Label();
            LblMyVote = new Label();
            LblReminder = new Label();
            ((System.ComponentModel.ISupportInitialize)PicBoxOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxVoteNow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxMyVote).BeginInit();
            PnlNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // PicBoxOverview
            // 
            PicBoxOverview.BorderStyle = BorderStyle.FixedSingle;
            PicBoxOverview.Location = new Point(441, 499);
            PicBoxOverview.Name = "PicBoxOverview";
            PicBoxOverview.Size = new Size(429, 438);
            PicBoxOverview.TabIndex = 0;
            PicBoxOverview.TabStop = false;
            PicBoxOverview.Click += PicBoxOverview_Click;
            // 
            // PicBoxLogo
            // 
            PicBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            PicBoxLogo.Location = new Point(120, 22);
            PicBoxLogo.Name = "PicBoxLogo";
            PicBoxLogo.Size = new Size(158, 158);
            PicBoxLogo.TabIndex = 1;
            PicBoxLogo.TabStop = false;
            // 
            // PicBoxVoteNow
            // 
            PicBoxVoteNow.BorderStyle = BorderStyle.FixedSingle;
            PicBoxVoteNow.Location = new Point(416, 363);
            PicBoxVoteNow.Name = "PicBoxVoteNow";
            PicBoxVoteNow.Size = new Size(1491, 117);
            PicBoxVoteNow.TabIndex = 2;
            PicBoxVoteNow.TabStop = false;
            PicBoxVoteNow.Click += PicBoxVoteNow_Click;
            // 
            // PicBoxViewElection
            // 
            PicBoxViewElection.BorderStyle = BorderStyle.FixedSingle;
            PicBoxViewElection.Location = new Point(945, 499);
            PicBoxViewElection.Name = "PicBoxViewElection";
            PicBoxViewElection.Size = new Size(429, 438);
            PicBoxViewElection.TabIndex = 3;
            PicBoxViewElection.TabStop = false;
            PicBoxViewElection.Click += PicBoxViewElection_Click;
            // 
            // PicBoxMyVote
            // 
            PicBoxMyVote.BorderStyle = BorderStyle.FixedSingle;
            PicBoxMyVote.Location = new Point(1453, 499);
            PicBoxMyVote.Name = "PicBoxMyVote";
            PicBoxMyVote.Size = new Size(429, 438);
            PicBoxMyVote.TabIndex = 4;
            PicBoxMyVote.TabStop = false;
            PicBoxMyVote.Click += PicBoxMyVote_Click;
            // 
            // BtnLogout
            // 
            BtnLogout.Location = new Point(0, 1000);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(398, 29);
            BtnLogout.TabIndex = 5;
            BtnLogout.Text = "LOGOUT";
            BtnLogout.UseVisualStyleBackColor = true;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // PnlNavigation
            // 
            PnlNavigation.BackColor = Color.LightSteelBlue;
            PnlNavigation.Controls.Add(LblInfo);
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
            PnlNavigation.Controls.Add(LblSideOverview);
            PnlNavigation.Controls.Add(LblSideHome);
            PnlNavigation.Controls.Add(LblSideTitle);
            PnlNavigation.Controls.Add(PicBoxLogo);
            PnlNavigation.Controls.Add(BtnLogout);
            PnlNavigation.Dock = DockStyle.Left;
            PnlNavigation.Location = new Point(0, 0);
            PnlNavigation.Name = "PnlNavigation";
            PnlNavigation.Size = new Size(398, 1055);
            PnlNavigation.TabIndex = 6;
            // 
            // LblInfo
            // 
            LblInfo.Location = new Point(0, 959);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(398, 38);
            LblInfo.TabIndex = 31;
            LblInfo.Text = "ABOUT US";
            LblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RdoDark
            // 
            RdoDark.AutoSize = true;
            RdoDark.Location = new Point(61, 885);
            RdoDark.Name = "RdoDark";
            RdoDark.Size = new Size(69, 24);
            RdoDark.TabIndex = 30;
            RdoDark.TabStop = true;
            RdoDark.Text = "DARK";
            RdoDark.UseVisualStyleBackColor = true;
            RdoDark.CheckedChanged += RdoDark_CheckedChanged;
            // 
            // RdoLight
            // 
            RdoLight.AutoSize = true;
            RdoLight.Location = new Point(61, 855);
            RdoLight.Name = "RdoLight";
            RdoLight.Size = new Size(70, 24);
            RdoLight.TabIndex = 29;
            RdoLight.TabStop = true;
            RdoLight.Text = "LIGHT";
            RdoLight.UseVisualStyleBackColor = true;
            RdoLight.CheckedChanged += RdoLight_CheckedChanged;
            // 
            // LblTheme
            // 
            LblTheme.Location = new Point(0, 814);
            LblTheme.Name = "LblTheme";
            LblTheme.Size = new Size(398, 38);
            LblTheme.TabIndex = 28;
            LblTheme.Text = "               THEME";
            LblTheme.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideViewProfile
            // 
            LblSideViewProfile.Location = new Point(0, 661);
            LblSideViewProfile.Name = "LblSideViewProfile";
            LblSideViewProfile.Size = new Size(398, 38);
            LblSideViewProfile.TabIndex = 27;
            LblSideViewProfile.Text = "               VIEW PROFILE";
            LblSideViewProfile.TextAlign = ContentAlignment.MiddleLeft;
            LblSideViewProfile.Click += LblSideViewProfile_Click;
            // 
            // LblSideMyVote
            // 
            LblSideMyVote.Location = new Point(0, 598);
            LblSideMyVote.Name = "LblSideMyVote";
            LblSideMyVote.Size = new Size(398, 38);
            LblSideMyVote.TabIndex = 26;
            LblSideMyVote.Text = "               MY VOTE";
            LblSideMyVote.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideVoteNow
            // 
            LblSideVoteNow.Location = new Point(0, 539);
            LblSideVoteNow.Name = "LblSideVoteNow";
            LblSideVoteNow.Size = new Size(398, 38);
            LblSideVoteNow.TabIndex = 25;
            LblSideVoteNow.Text = "               VOTE NOW";
            LblSideVoteNow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSidePartylists
            // 
            LblSidePartylists.Location = new Point(0, 488);
            LblSidePartylists.Name = "LblSidePartylists";
            LblSidePartylists.Size = new Size(398, 38);
            LblSidePartylists.TabIndex = 24;
            LblSidePartylists.Text = "                         PARTYLISTS";
            LblSidePartylists.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSidePositions
            // 
            LblSidePositions.Location = new Point(0, 450);
            LblSidePositions.Name = "LblSidePositions";
            LblSidePositions.Size = new Size(398, 38);
            LblSidePositions.TabIndex = 23;
            LblSidePositions.Text = "                         POSITIONS";
            LblSidePositions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCandidates
            // 
            LblCandidates.Location = new Point(0, 412);
            LblCandidates.Name = "LblCandidates";
            LblCandidates.Size = new Size(398, 38);
            LblCandidates.TabIndex = 22;
            LblCandidates.Text = "                         CANDIDATES";
            LblCandidates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideViewElection
            // 
            LblSideViewElection.Location = new Point(0, 362);
            LblSideViewElection.Name = "LblSideViewElection";
            LblSideViewElection.Size = new Size(398, 38);
            LblSideViewElection.TabIndex = 21;
            LblSideViewElection.Text = "               VIEW ELECTION";
            LblSideViewElection.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideOverview
            // 
            LblSideOverview.Location = new Point(0, 306);
            LblSideOverview.Name = "LblSideOverview";
            LblSideOverview.Size = new Size(398, 38);
            LblSideOverview.TabIndex = 20;
            LblSideOverview.Text = "               OVERVIEW";
            LblSideOverview.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideHome
            // 
            LblSideHome.Location = new Point(0, 250);
            LblSideHome.Name = "LblSideHome";
            LblSideHome.Size = new Size(398, 38);
            LblSideHome.TabIndex = 19;
            LblSideHome.Text = "               HOME";
            LblSideHome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideTitle
            // 
            LblSideTitle.BorderStyle = BorderStyle.FixedSingle;
            LblSideTitle.Location = new Point(120, 193);
            LblSideTitle.Name = "LblSideTitle";
            LblSideTitle.Size = new Size(158, 38);
            LblSideTitle.TabIndex = 18;
            LblSideTitle.Text = "HALAL 2205";
            LblSideTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTitle
            // 
            LblTitle.BorderStyle = BorderStyle.FixedSingle;
            LblTitle.Location = new Point(416, 22);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(1491, 108);
            LblTitle.TabIndex = 7;
            LblTitle.Text = "TITLE";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblStatus
            // 
            LblStatus.BorderStyle = BorderStyle.FixedSingle;
            LblStatus.Location = new Point(416, 945);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(1491, 101);
            LblStatus.TabIndex = 8;
            LblStatus.Text = "VOTING STATUS";
            LblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblGreetings
            // 
            LblGreetings.BorderStyle = BorderStyle.FixedSingle;
            LblGreetings.Location = new Point(416, 145);
            LblGreetings.Name = "LblGreetings";
            LblGreetings.Size = new Size(505, 51);
            LblGreetings.TabIndex = 9;
            LblGreetings.Text = "GREETINGS";
            LblGreetings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblYLevel
            // 
            LblYLevel.BorderStyle = BorderStyle.FixedSingle;
            LblYLevel.Location = new Point(416, 212);
            LblYLevel.Name = "LblYLevel";
            LblYLevel.Size = new Size(505, 51);
            LblYLevel.TabIndex = 10;
            LblYLevel.Text = "GRADE LEVEL AND SECTION";
            LblYLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblDescription
            // 
            LblDescription.BorderStyle = BorderStyle.FixedSingle;
            LblDescription.Location = new Point(967, 145);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(940, 118);
            LblDescription.TabIndex = 11;
            LblDescription.Text = "DESCRIPTION";
            LblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblOverview
            // 
            LblOverview.BorderStyle = BorderStyle.FixedSingle;
            LblOverview.Location = new Point(441, 499);
            LblOverview.Name = "LblOverview";
            LblOverview.Size = new Size(429, 67);
            LblOverview.TabIndex = 12;
            LblOverview.Text = "OVERVIEW";
            LblOverview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblViewElection
            // 
            LblViewElection.BorderStyle = BorderStyle.FixedSingle;
            LblViewElection.Location = new Point(945, 499);
            LblViewElection.Name = "LblViewElection";
            LblViewElection.Size = new Size(429, 67);
            LblViewElection.TabIndex = 14;
            LblViewElection.Text = "VIEW ELECTION";
            LblViewElection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblVoteNow
            // 
            LblVoteNow.BorderStyle = BorderStyle.FixedSingle;
            LblVoteNow.Location = new Point(416, 363);
            LblVoteNow.Name = "LblVoteNow";
            LblVoteNow.Size = new Size(1491, 56);
            LblVoteNow.TabIndex = 15;
            LblVoteNow.Text = "VOTE NOW";
            LblVoteNow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblMyVote
            // 
            LblMyVote.BorderStyle = BorderStyle.FixedSingle;
            LblMyVote.Location = new Point(1453, 499);
            LblMyVote.Name = "LblMyVote";
            LblMyVote.Size = new Size(429, 67);
            LblMyVote.TabIndex = 16;
            LblMyVote.Text = "MY VOTE";
            LblMyVote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblReminder
            // 
            LblReminder.BorderStyle = BorderStyle.FixedSingle;
            LblReminder.Location = new Point(441, 282);
            LblReminder.Name = "LblReminder";
            LblReminder.Size = new Size(1441, 66);
            LblReminder.TabIndex = 17;
            LblReminder.Text = "READY TO VOTE?";
            LblReminder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Student_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            ControlBox = false;
            Controls.Add(LblReminder);
            Controls.Add(LblMyVote);
            Controls.Add(LblVoteNow);
            Controls.Add(LblViewElection);
            Controls.Add(PicBoxVoteNow);
            Controls.Add(LblOverview);
            Controls.Add(LblDescription);
            Controls.Add(LblYLevel);
            Controls.Add(LblGreetings);
            Controls.Add(LblStatus);
            Controls.Add(LblTitle);
            Controls.Add(PnlNavigation);
            Controls.Add(PicBoxMyVote);
            Controls.Add(PicBoxViewElection);
            Controls.Add(PicBoxOverview);
            Name = "Student_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Home";
            WindowState = FormWindowState.Maximized;
            Load += Student_Home_Load;
            ((System.ComponentModel.ISupportInitialize)PicBoxOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxVoteNow).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxMyVote).EndInit();
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxOverview;
        private PictureBox PicBoxLogo;
        private PictureBox PicBoxVoteNow;
        private PictureBox PicBoxViewElection;
        private PictureBox PicBoxMyVote;
        private Button BtnLogout;
        private Panel PnlNavigation;
        private Label LblTitle;
        private Label LblStatus;
        private Label LblGreetings;
        private Label LblYLevel;
        private Label LblDescription;
        private Label LblOverview;
        private Label LblViewElection;
        private Label LblVoteNow;
        private Label LblMyVote;
        private Label LblReminder;
        private Label LblSideTitle;
        private Label LblSideHome;
        private Label LblSideViewElection;
        private Label LblSideOverview;
        private Label LblSideViewProfile;
        private Label LblSideMyVote;
        private Label LblSideVoteNow;
        private Label LblSidePartylists;
        private Label LblSidePositions;
        private Label LblCandidates;
        private RadioButton RdoLight;
        private Label LblTheme;
        private RadioButton RdoDark;
        private Label LblInfo;
    }
}