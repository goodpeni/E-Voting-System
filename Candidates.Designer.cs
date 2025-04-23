namespace E_Voting_System
{
    partial class Candidates
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
            LblTitle = new Label();
            LblFilter = new Label();
            CmbFilter = new ComboBox();
            BtnVoteNow = new Button();
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
            PnlFilter = new Panel();
            PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.BackColor = Color.Transparent;
            LblTitle.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.Gold;
            LblTitle.Location = new Point(396, 9);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(943, 82);
            LblTitle.TabIndex = 8;
            LblTitle.Text = "CANDIDATES FOR THE STUDENT ELECTIONS";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblFilter
            // 
            LblFilter.BackColor = Color.Transparent;
            LblFilter.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFilter.ForeColor = Color.Black;
            LblFilter.Location = new Point(497, 84);
            LblFilter.Name = "LblFilter";
            LblFilter.Size = new Size(326, 46);
            LblFilter.TabIndex = 9;
            LblFilter.Text = "FILTER BY POSITION:";
            LblFilter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmbFilter
            // 
            CmbFilter.BackColor = Color.White;
            CmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilter.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CmbFilter.FormattingEnabled = true;
            CmbFilter.Items.AddRange(new object[] { "PRESIDENT", "VICE PRESIDENT", "SECRETARY", "TREASURER", "AUDITOR", "PUBLIC INFORMATION OFFICER", "PEACE OFFICER", "GRADE 4 REPRESENTATIVE", "GRADE 5 REPRESENTATIVE", "GRADE 6 REPRESENTATIVE" });
            CmbFilter.Location = new Point(765, 81);
            CmbFilter.Margin = new Padding(3, 4, 3, 4);
            CmbFilter.Name = "CmbFilter";
            CmbFilter.Size = new Size(485, 46);
            CmbFilter.TabIndex = 10;
            // 
            // BtnVoteNow
            // 
            BtnVoteNow.BackColor = Color.Brown;
            BtnVoteNow.Cursor = Cursors.Hand;
            BtnVoteNow.FlatAppearance.BorderSize = 0;
            BtnVoteNow.FlatStyle = FlatStyle.Flat;
            BtnVoteNow.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoteNow.ForeColor = Color.White;
            BtnVoteNow.Location = new Point(408, 674);
            BtnVoteNow.Margin = new Padding(3, 4, 3, 4);
            BtnVoteNow.Name = "BtnVoteNow";
            BtnVoteNow.Size = new Size(918, 81);
            BtnVoteNow.TabIndex = 25;
            BtnVoteNow.Text = "VOTE NOW";
            BtnVoteNow.UseVisualStyleBackColor = false;
            BtnVoteNow.Click += BtnVoteNow_Click;
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
            PnlNavigation.TabIndex = 28;
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
            BtnLogout.Location = new Point(321, 721);
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
            LblSideVoteNow.Cursor = Cursors.Hand;
            LblSideVoteNow.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVoteNow.Location = new Point(0, 473);
            LblSideVoteNow.Name = "LblSideVoteNow";
            LblSideVoteNow.Size = new Size(368, 37);
            LblSideVoteNow.TabIndex = 25;
            LblSideVoteNow.Text = "               VOTE NOW";
            LblSideVoteNow.TextAlign = ContentAlignment.MiddleLeft;
            LblSideVoteNow.Click += LblSideVoteNow_Click;
            // 
            // LblSidePartylists
            // 
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
            LblSideCandidates.BackColor = Color.SteelBlue;
            LblSideCandidates.Cursor = Cursors.Hand;
            LblSideCandidates.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideCandidates.Location = new Point(0, 347);
            LblSideCandidates.Name = "LblSideCandidates";
            LblSideCandidates.Size = new Size(368, 37);
            LblSideCandidates.TabIndex = 22;
            LblSideCandidates.Text = "                         CANDIDATES";
            LblSideCandidates.TextAlign = ContentAlignment.MiddleLeft;
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
            // PnlFilter
            // 
            PnlFilter.BackColor = Color.Transparent;
            PnlFilter.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PnlFilter.Location = new Point(408, 139);
            PnlFilter.Name = "PnlFilter";
            PnlFilter.Size = new Size(918, 510);
            PnlFilter.TabIndex = 29;
            // 
            // Candidates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lightmode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(PnlFilter);
            Controls.Add(PnlNavigation);
            Controls.Add(BtnVoteNow);
            Controls.Add(CmbFilter);
            Controls.Add(LblFilter);
            Controls.Add(LblTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Candidates";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Candidates";
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label LblTitle;
        private Label LblFilter;
        private ComboBox CmbFilter;
        private Button BtnVoteNow;
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
        private Panel PnlFilter;
    }
}