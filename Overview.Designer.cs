namespace E_Voting_System
{
    partial class Overview
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
            BtnBack = new Button();
            LblInfo = new Label();
            BtnLogout = new Button();
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
            LblSideOverview = new Label();
            LblSideHome = new Label();
            LblSideTitle = new Label();
            PicBoxLogo = new PictureBox();
            PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(1332, 27);
            BtnBack.Margin = new Padding(3, 2, 3, 2);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(82, 22);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "button1";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // LblInfo
            // 
            LblInfo.Location = new Point(0, 1105);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(348, 28);
            LblInfo.TabIndex = 31;
            LblInfo.Text = "ABOUT US";
            LblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnLogout
            // 
            BtnLogout.Location = new Point(0, 1136);
            BtnLogout.Margin = new Padding(3, 2, 3, 2);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(348, 22);
            BtnLogout.TabIndex = 5;
            BtnLogout.Text = "LOGOUT";
            BtnLogout.UseVisualStyleBackColor = true;
            BtnLogout.Click += BtnLogout_Click;
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
            PnlNavigation.Controls.Add(LblSideOverview);
            PnlNavigation.Controls.Add(LblSideHome);
            PnlNavigation.Controls.Add(LblSideTitle);
            PnlNavigation.Controls.Add(PicBoxLogo);
            PnlNavigation.Controls.Add(LblInfo);
            PnlNavigation.Controls.Add(BtnLogout);
            PnlNavigation.Dock = DockStyle.Left;
            PnlNavigation.Location = new Point(0, 0);
            PnlNavigation.Margin = new Padding(3, 2, 3, 2);
            PnlNavigation.Name = "PnlNavigation";
            PnlNavigation.Size = new Size(348, 1181);
            PnlNavigation.TabIndex = 7;
            // 
            // RdoDark
            // 
            RdoDark.AutoSize = true;
            RdoDark.Location = new Point(80, 742);
            RdoDark.Margin = new Padding(3, 2, 3, 2);
            RdoDark.Name = "RdoDark";
            RdoDark.Size = new Size(55, 19);
            RdoDark.TabIndex = 45;
            RdoDark.TabStop = true;
            RdoDark.Text = "DARK";
            RdoDark.UseVisualStyleBackColor = true;
            // 
            // RdoLight
            // 
            RdoLight.AutoSize = true;
            RdoLight.Location = new Point(80, 775);
            RdoLight.Margin = new Padding(3, 2, 3, 2);
            RdoLight.Name = "RdoLight";
            RdoLight.Size = new Size(57, 19);
            RdoLight.TabIndex = 44;
            RdoLight.TabStop = true;
            RdoLight.Text = "LIGHT";
            RdoLight.UseVisualStyleBackColor = true;
            // 
            // LblTheme
            // 
            LblTheme.Location = new Point(0, 707);
            LblTheme.Name = "LblTheme";
            LblTheme.Size = new Size(348, 28);
            LblTheme.TabIndex = 43;
            LblTheme.Text = "               THEME";
            LblTheme.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideViewProfile
            // 
            LblSideViewProfile.Location = new Point(0, 640);
            LblSideViewProfile.Name = "LblSideViewProfile";
            LblSideViewProfile.Size = new Size(348, 28);
            LblSideViewProfile.TabIndex = 42;
            LblSideViewProfile.Text = "               VIEW PROFILE";
            LblSideViewProfile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideMyVote
            // 
            LblSideMyVote.Location = new Point(0, 570);
            LblSideMyVote.Name = "LblSideMyVote";
            LblSideMyVote.Size = new Size(348, 28);
            LblSideMyVote.TabIndex = 41;
            LblSideMyVote.Text = "               MY VOTE";
            LblSideMyVote.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideVoteNow
            // 
            LblSideVoteNow.Location = new Point(0, 499);
            LblSideVoteNow.Name = "LblSideVoteNow";
            LblSideVoteNow.Size = new Size(348, 28);
            LblSideVoteNow.TabIndex = 40;
            LblSideVoteNow.Text = "               VOTE NOW";
            LblSideVoteNow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSidePartylists
            // 
            LblSidePartylists.Location = new Point(0, 426);
            LblSidePartylists.Name = "LblSidePartylists";
            LblSidePartylists.Size = new Size(348, 28);
            LblSidePartylists.TabIndex = 39;
            LblSidePartylists.Text = "                         PARTYLISTS";
            LblSidePartylists.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSidePositions
            // 
            LblSidePositions.Location = new Point(0, 398);
            LblSidePositions.Name = "LblSidePositions";
            LblSidePositions.Size = new Size(348, 28);
            LblSidePositions.TabIndex = 38;
            LblSidePositions.Text = "                         POSITIONS";
            LblSidePositions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCandidates
            // 
            LblCandidates.Location = new Point(0, 369);
            LblCandidates.Name = "LblCandidates";
            LblCandidates.Size = new Size(348, 28);
            LblCandidates.TabIndex = 37;
            LblCandidates.Text = "                         CANDIDATES";
            LblCandidates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideViewElection
            // 
            LblSideViewElection.Location = new Point(0, 310);
            LblSideViewElection.Name = "LblSideViewElection";
            LblSideViewElection.Size = new Size(348, 28);
            LblSideViewElection.TabIndex = 36;
            LblSideViewElection.Text = "               VIEW ELECTION";
            LblSideViewElection.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideOverview
            // 
            LblSideOverview.Location = new Point(0, 248);
            LblSideOverview.Name = "LblSideOverview";
            LblSideOverview.Size = new Size(348, 28);
            LblSideOverview.TabIndex = 35;
            LblSideOverview.Text = "               OVERVIEW";
            LblSideOverview.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideHome
            // 
            LblSideHome.Location = new Point(0, 199);
            LblSideHome.Name = "LblSideHome";
            LblSideHome.Size = new Size(348, 28);
            LblSideHome.TabIndex = 34;
            LblSideHome.Text = "               HOME";
            LblSideHome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideTitle
            // 
            LblSideTitle.BorderStyle = BorderStyle.FixedSingle;
            LblSideTitle.Location = new Point(105, 156);
            LblSideTitle.Name = "LblSideTitle";
            LblSideTitle.Size = new Size(138, 29);
            LblSideTitle.TabIndex = 33;
            LblSideTitle.Text = "HALAL 2025";
            LblSideTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PicBoxLogo
            // 
            PicBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            PicBoxLogo.Location = new Point(105, 27);
            PicBoxLogo.Margin = new Padding(3, 2, 3, 2);
            PicBoxLogo.Name = "PicBoxLogo";
            PicBoxLogo.Size = new Size(138, 119);
            PicBoxLogo.TabIndex = 32;
            PicBoxLogo.TabStop = false;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1181);
            Controls.Add(PnlNavigation);
            Controls.Add(BtnBack);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Overview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Overview";
            WindowState = FormWindowState.Maximized;
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Label LblInfo;
        private Button BtnLogout;
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
        private Label LblSideOverview;
        private Label LblSideHome;
        private Label LblSideTitle;
        private PictureBox PicBoxLogo;
    }
}