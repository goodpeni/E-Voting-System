namespace E_Voting_System
{
    partial class Vote_Now
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
            PnlNavigation = new Panel();
            LblInfo = new Label();
            RdoDark = new RadioButton();
            RdoLight = new RadioButton();
            BtnLogout = new Button();
            LblTheme = new Label();
            LblSideViewProfile = new Label();
            LblSideMyVote = new Label();
            LblSideVoteNow = new Label();
            LblSidePartylists = new Label();
            LblSidePositions = new Label();
            LblSideCandidates = new Label();
            LblSideViewElection = new Label();
            LblSideVotersManual = new Label();
            LblSideHome = new Label();
            LblSideTitle = new Label();
            PicBoxLogo = new PictureBox();
            TabVoteNow = new TabControl();
            TabPres = new TabPage();
            TabVice = new TabPage();
            TabSec = new TabPage();
            TabTreas = new TabPage();
            TabAudit = new TabPage();
            TabPO = new TabPage();
            TabPIO = new TabPage();
            TabG4Repre = new TabPage();
            TabG5Repre = new TabPage();
            TabG6Repre = new TabPage();
            LblTitle = new Label();
            PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            TabVoteNow.SuspendLayout();
            SuspendLayout();
            // 
            // PnlNavigation
            // 
            PnlNavigation.BackColor = Color.LightSteelBlue;
            PnlNavigation.Controls.Add(LblInfo);
            PnlNavigation.Controls.Add(RdoDark);
            PnlNavigation.Controls.Add(RdoLight);
            PnlNavigation.Controls.Add(BtnLogout);
            PnlNavigation.Controls.Add(LblTheme);
            PnlNavigation.Controls.Add(LblSideViewProfile);
            PnlNavigation.Controls.Add(LblSideMyVote);
            PnlNavigation.Controls.Add(LblSideVoteNow);
            PnlNavigation.Controls.Add(LblSidePartylists);
            PnlNavigation.Controls.Add(LblSidePositions);
            PnlNavigation.Controls.Add(LblSideCandidates);
            PnlNavigation.Controls.Add(LblSideViewElection);
            PnlNavigation.Controls.Add(LblSideVotersManual);
            PnlNavigation.Controls.Add(LblSideHome);
            PnlNavigation.Controls.Add(LblSideTitle);
            PnlNavigation.Controls.Add(PicBoxLogo);
            PnlNavigation.Dock = DockStyle.Left;
            PnlNavigation.Location = new Point(0, 0);
            PnlNavigation.Name = "PnlNavigation";
            PnlNavigation.Size = new Size(368, 768);
            PnlNavigation.TabIndex = 40;
            // 
            // LblInfo
            // 
            LblInfo.Cursor = Cursors.Hand;
            LblInfo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblInfo.Location = new Point(41, 720);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(250, 40);
            LblInfo.TabIndex = 31;
            LblInfo.Text = "ABOUT US";
            LblInfo.TextAlign = ContentAlignment.MiddleCenter;
            LblInfo.Click += LblInfo_Click;
            // 
            // RdoDark
            // 
            RdoDark.AutoSize = true;
            RdoDark.Cursor = Cursors.Hand;
            RdoDark.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            RdoDark.Location = new Point(110, 676);
            RdoDark.Name = "RdoDark";
            RdoDark.Size = new Size(86, 28);
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
            RdoLight.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            RdoLight.Location = new Point(110, 639);
            RdoLight.Name = "RdoLight";
            RdoLight.Size = new Size(90, 28);
            RdoLight.TabIndex = 29;
            RdoLight.TabStop = true;
            RdoLight.Text = "LIGHT";
            RdoLight.UseVisualStyleBackColor = true;
            RdoLight.CheckedChanged += RdoLight_CheckedChanged;
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.Transparent;
            BtnLogout.BackgroundImage = Properties.Resources.power_off;
            BtnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLogout.Cursor = Cursors.Hand;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.Location = new Point(318, 721);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(40, 40);
            BtnLogout.TabIndex = 5;
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // LblTheme
            // 
            LblTheme.Cursor = Cursors.Hand;
            LblTheme.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTheme.Location = new Point(0, 599);
            LblTheme.Name = "LblTheme";
            LblTheme.Size = new Size(368, 37);
            LblTheme.TabIndex = 28;
            LblTheme.Text = "               THEME";
            LblTheme.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideViewProfile
            // 
            LblSideViewProfile.Cursor = Cursors.Hand;
            LblSideViewProfile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideViewProfile.Location = new Point(-3, 557);
            LblSideViewProfile.Name = "LblSideViewProfile";
            LblSideViewProfile.Size = new Size(371, 37);
            LblSideViewProfile.TabIndex = 27;
            LblSideViewProfile.Text = "               VIEW PROFILE";
            LblSideViewProfile.TextAlign = ContentAlignment.MiddleLeft;
            LblSideViewProfile.Click += LblSideViewProfile_Click;
            // 
            // LblSideMyVote
            // 
            LblSideMyVote.Cursor = Cursors.Hand;
            LblSideMyVote.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideMyVote.Location = new Point(0, 515);
            LblSideMyVote.Name = "LblSideMyVote";
            LblSideMyVote.Size = new Size(368, 37);
            LblSideMyVote.TabIndex = 26;
            LblSideMyVote.Text = "               MY VOTE";
            LblSideMyVote.TextAlign = ContentAlignment.MiddleLeft;
            LblSideMyVote.Click += LblSideMyVote_Click;
            // 
            // LblSideVoteNow
            // 
            LblSideVoteNow.BackColor = Color.SteelBlue;
            LblSideVoteNow.Cursor = Cursors.Hand;
            LblSideVoteNow.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVoteNow.Location = new Point(0, 473);
            LblSideVoteNow.Name = "LblSideVoteNow";
            LblSideVoteNow.Size = new Size(368, 37);
            LblSideVoteNow.TabIndex = 25;
            LblSideVoteNow.Text = "               VOTE NOW";
            LblSideVoteNow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSidePartylists
            // 
            LblSidePartylists.BackColor = Color.LightSteelBlue;
            LblSidePartylists.Cursor = Cursors.Hand;
            LblSidePartylists.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSidePartylists.Location = new Point(0, 431);
            LblSidePartylists.Name = "LblSidePartylists";
            LblSidePartylists.Size = new Size(368, 37);
            LblSidePartylists.TabIndex = 24;
            LblSidePartylists.Text = "                         PARTYLISTS";
            LblSidePartylists.TextAlign = ContentAlignment.MiddleLeft;
            LblSidePartylists.Click += LblSidePartylists_Click;
            // 
            // LblSidePositions
            // 
            LblSidePositions.BackColor = Color.LightSteelBlue;
            LblSidePositions.Cursor = Cursors.Hand;
            LblSidePositions.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSidePositions.Location = new Point(0, 389);
            LblSidePositions.Name = "LblSidePositions";
            LblSidePositions.Size = new Size(368, 37);
            LblSidePositions.TabIndex = 23;
            LblSidePositions.Text = "                         POSITIONS";
            LblSidePositions.TextAlign = ContentAlignment.MiddleLeft;
            LblSidePositions.Click += LblSidePositions_Click;
            // 
            // LblSideCandidates
            // 
            LblSideCandidates.BackColor = Color.LightSteelBlue;
            LblSideCandidates.Cursor = Cursors.Hand;
            LblSideCandidates.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideCandidates.Location = new Point(0, 347);
            LblSideCandidates.Name = "LblSideCandidates";
            LblSideCandidates.Size = new Size(368, 37);
            LblSideCandidates.TabIndex = 22;
            LblSideCandidates.Text = "                         CANDIDATES";
            LblSideCandidates.TextAlign = ContentAlignment.MiddleLeft;
            LblSideCandidates.Click += LblSideCandidates_Click;
            // 
            // LblSideViewElection
            // 
            LblSideViewElection.BackColor = Color.LightSteelBlue;
            LblSideViewElection.Cursor = Cursors.Hand;
            LblSideViewElection.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideViewElection.Location = new Point(0, 305);
            LblSideViewElection.Name = "LblSideViewElection";
            LblSideViewElection.Size = new Size(368, 37);
            LblSideViewElection.TabIndex = 21;
            LblSideViewElection.Text = "               VIEW ELECTION";
            LblSideViewElection.TextAlign = ContentAlignment.MiddleLeft;
            LblSideViewElection.Click += LblSideViewElection_Click;
            // 
            // LblSideVotersManual
            // 
            LblSideVotersManual.BackColor = Color.LightSteelBlue;
            LblSideVotersManual.Cursor = Cursors.Hand;
            LblSideVotersManual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVotersManual.Location = new Point(0, 263);
            LblSideVotersManual.Name = "LblSideVotersManual";
            LblSideVotersManual.Size = new Size(368, 37);
            LblSideVotersManual.TabIndex = 20;
            LblSideVotersManual.Text = "               VOTER'S MANUAL";
            LblSideVotersManual.TextAlign = ContentAlignment.MiddleLeft;
            LblSideVotersManual.Click += LblSideVotersManual_Click;
            // 
            // LblSideHome
            // 
            LblSideHome.BackColor = Color.LightSteelBlue;
            LblSideHome.Cursor = Cursors.Hand;
            LblSideHome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideHome.Location = new Point(0, 221);
            LblSideHome.Name = "LblSideHome";
            LblSideHome.Size = new Size(368, 37);
            LblSideHome.TabIndex = 19;
            LblSideHome.Text = "               HOME";
            LblSideHome.TextAlign = ContentAlignment.MiddleLeft;
            LblSideHome.Click += LblSideHome_Click;
            // 
            // LblSideTitle
            // 
            LblSideTitle.Cursor = Cursors.Hand;
            LblSideTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideTitle.Location = new Point(78, 182);
            LblSideTitle.Name = "LblSideTitle";
            LblSideTitle.Size = new Size(200, 39);
            LblSideTitle.TabIndex = 18;
            LblSideTitle.Text = "HALAL 2025";
            LblSideTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PicBoxLogo
            // 
            PicBoxLogo.BackColor = Color.Transparent;
            PicBoxLogo.BackgroundImage = Properties.Resources.official_logo;
            PicBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxLogo.Location = new Point(102, 31);
            PicBoxLogo.Name = "PicBoxLogo";
            PicBoxLogo.Size = new Size(150, 150);
            PicBoxLogo.TabIndex = 1;
            PicBoxLogo.TabStop = false;
            // 
            // TabVoteNow
            // 
            TabVoteNow.Controls.Add(TabPres);
            TabVoteNow.Controls.Add(TabVice);
            TabVoteNow.Controls.Add(TabSec);
            TabVoteNow.Controls.Add(TabTreas);
            TabVoteNow.Controls.Add(TabAudit);
            TabVoteNow.Controls.Add(TabPO);
            TabVoteNow.Controls.Add(TabPIO);
            TabVoteNow.Controls.Add(TabG4Repre);
            TabVoteNow.Controls.Add(TabG5Repre);
            TabVoteNow.Controls.Add(TabG6Repre);
            TabVoteNow.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabVoteNow.Location = new Point(419, 125);
            TabVoteNow.Name = "TabVoteNow";
            TabVoteNow.SelectedIndex = 0;
            TabVoteNow.Size = new Size(898, 598);
            TabVoteNow.TabIndex = 41;
            // 
            // TabPres
            // 
            TabPres.Location = new Point(4, 28);
            TabPres.Name = "TabPres";
            TabPres.Padding = new Padding(3);
            TabPres.Size = new Size(890, 566);
            TabPres.TabIndex = 0;
            TabPres.Text = "PRESIDENT";
            TabPres.UseVisualStyleBackColor = true;
            // 
            // TabVice
            // 
            TabVice.Location = new Point(4, 29);
            TabVice.Name = "TabVice";
            TabVice.Padding = new Padding(3);
            TabVice.Size = new Size(890, 565);
            TabVice.TabIndex = 1;
            TabVice.Text = "VICE PRESIDENT";
            TabVice.UseVisualStyleBackColor = true;
            // 
            // TabSec
            // 
            TabSec.Location = new Point(4, 29);
            TabSec.Name = "TabSec";
            TabSec.Size = new Size(890, 565);
            TabSec.TabIndex = 2;
            TabSec.Text = "SECRETARY";
            TabSec.UseVisualStyleBackColor = true;
            // 
            // TabTreas
            // 
            TabTreas.Location = new Point(4, 29);
            TabTreas.Name = "TabTreas";
            TabTreas.Size = new Size(890, 565);
            TabTreas.TabIndex = 3;
            TabTreas.Text = "TREASURER";
            TabTreas.UseVisualStyleBackColor = true;
            // 
            // TabAudit
            // 
            TabAudit.Location = new Point(4, 29);
            TabAudit.Name = "TabAudit";
            TabAudit.Size = new Size(890, 565);
            TabAudit.TabIndex = 4;
            TabAudit.Text = "AUDITOR";
            TabAudit.UseVisualStyleBackColor = true;
            // 
            // TabPO
            // 
            TabPO.Location = new Point(4, 29);
            TabPO.Name = "TabPO";
            TabPO.Size = new Size(890, 565);
            TabPO.TabIndex = 5;
            TabPO.Text = "PEACE OFFICER";
            TabPO.UseVisualStyleBackColor = true;
            // 
            // TabPIO
            // 
            TabPIO.Location = new Point(4, 29);
            TabPIO.Name = "TabPIO";
            TabPIO.Size = new Size(890, 565);
            TabPIO.TabIndex = 6;
            TabPIO.Text = "PUBLIC INFORMATION OFFICER";
            TabPIO.UseVisualStyleBackColor = true;
            // 
            // TabG4Repre
            // 
            TabG4Repre.Location = new Point(4, 29);
            TabG4Repre.Name = "TabG4Repre";
            TabG4Repre.Size = new Size(890, 565);
            TabG4Repre.TabIndex = 7;
            TabG4Repre.Text = "GRADE 4 REPRESENTATIVE";
            TabG4Repre.UseVisualStyleBackColor = true;
            // 
            // TabG5Repre
            // 
            TabG5Repre.Location = new Point(4, 29);
            TabG5Repre.Name = "TabG5Repre";
            TabG5Repre.Size = new Size(890, 565);
            TabG5Repre.TabIndex = 8;
            TabG5Repre.Text = "GRADE 5 REPRESENTATIVE";
            TabG5Repre.UseVisualStyleBackColor = true;
            // 
            // TabG6Repre
            // 
            TabG6Repre.Location = new Point(4, 29);
            TabG6Repre.Name = "TabG6Repre";
            TabG6Repre.Size = new Size(890, 565);
            TabG6Repre.TabIndex = 9;
            TabG6Repre.Text = "GRADE 6 REPRESENTATIVE";
            TabG6Repre.UseVisualStyleBackColor = true;
            // 
            // LblTitle
            // 
            LblTitle.BackColor = Color.Transparent;
            LblTitle.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.Brown;
            LblTitle.Location = new Point(420, 5);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(893, 113);
            LblTitle.TabIndex = 42;
            LblTitle.Text = "CAST YOUR VOTE";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Vote_Now
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lightmode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(LblTitle);
            Controls.Add(TabVoteNow);
            Controls.Add(PnlNavigation);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vote_Now";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vote_Now";
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            TabVoteNow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlNavigation;
        private Label LblInfo;
        private RadioButton RdoDark;
        private RadioButton RdoLight;
        private Button BtnLogout;
        private Label LblTheme;
        private Label LblSideViewProfile;
        private Label LblSideMyVote;
        private Label LblSideVoteNow;
        private Label LblSidePartylists;
        private Label LblSidePositions;
        private Label LblSideCandidates;
        private Label LblSideViewElection;
        private Label LblSideVotersManual;
        private Label LblSideHome;
        private Label LblSideTitle;
        private PictureBox PicBoxLogo;
        private TabControl TabVoteNow;
        private TabPage TabPres;
        private TabPage TabVice;
        private TabPage TabSec;
        private TabPage TabTreas;
        private TabPage TabAudit;
        private TabPage TabPO;
        private TabPage TabPIO;
        private TabPage TabG4Repre;
        private TabPage TabG5Repre;
        private TabPage TabG6Repre;
        private Label LblTitle;
    }
}