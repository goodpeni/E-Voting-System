namespace E_Voting_System
{
    partial class Stud_View_Election
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
            PicBoxCandidates = new PictureBox();
            PicBoxPositions = new PictureBox();
            PicBoxPartylists = new PictureBox();
            PnlCandidates = new Panel();
            LblPartylistsDesc = new Label();
            LblPartylists = new Label();
            LblCandidatesDesc = new Label();
            LblCandidates = new Label();
            LblStatus = new Label();
            PnlPartylists = new Panel();
            PnlPositions = new Panel();
            LblPositionsDesc = new Label();
            LblPositions = new Label();
            LblTitle = new Label();
            LblDescription = new Label();
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
            BtnVoteNow = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxCandidates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPartylists).BeginInit();
            PnlCandidates.SuspendLayout();
            PnlPartylists.SuspendLayout();
            PnlPositions.SuspendLayout();
            PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // PicBoxCandidates
            // 
            PicBoxCandidates.BackgroundImage = Properties.Resources.list;
            PicBoxCandidates.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxCandidates.Location = new Point(64, 35);
            PicBoxCandidates.Name = "PicBoxCandidates";
            PicBoxCandidates.Size = new Size(175, 175);
            PicBoxCandidates.TabIndex = 0;
            PicBoxCandidates.TabStop = false;
            PicBoxCandidates.Click += PicBoxPartylists_Click;
            // 
            // PicBoxPositions
            // 
            PicBoxPositions.BackgroundImage = Properties.Resources.listings;
            PicBoxPositions.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxPositions.Location = new Point(65, 35);
            PicBoxPositions.Name = "PicBoxPositions";
            PicBoxPositions.Size = new Size(175, 175);
            PicBoxPositions.TabIndex = 1;
            PicBoxPositions.TabStop = false;
            PicBoxPositions.Click += PicBoxPositions_Click;
            // 
            // PicBoxPartylists
            // 
            PicBoxPartylists.BackgroundImage = Properties.Resources.guest_list;
            PicBoxPartylists.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxPartylists.Location = new Point(63, 35);
            PicBoxPartylists.Name = "PicBoxPartylists";
            PicBoxPartylists.Size = new Size(175, 175);
            PicBoxPartylists.TabIndex = 2;
            PicBoxPartylists.TabStop = false;
            PicBoxPartylists.Click += PicBoxCandidates_Click;
            // 
            // PnlCandidates
            // 
            PnlCandidates.BackColor = Color.Transparent;
            PnlCandidates.Controls.Add(LblPartylistsDesc);
            PnlCandidates.Controls.Add(PicBoxCandidates);
            PnlCandidates.Controls.Add(LblPartylists);
            PnlCandidates.Location = new Point(1041, 241);
            PnlCandidates.Margin = new Padding(3, 4, 3, 4);
            PnlCandidates.Name = "PnlCandidates";
            PnlCandidates.Size = new Size(300, 387);
            PnlCandidates.TabIndex = 9;
            // 
            // LblPartylistsDesc
            // 
            LblPartylistsDesc.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic);
            LblPartylistsDesc.Location = new Point(1, 269);
            LblPartylistsDesc.Name = "LblPartylistsDesc";
            LblPartylistsDesc.Size = new Size(300, 87);
            LblPartylistsDesc.TabIndex = 4;
            LblPartylistsDesc.Text = "Check the groups or organizations each candidate represents.";
            LblPartylistsDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblPartylists
            // 
            LblPartylists.Font = new Font("Arial", 18F, FontStyle.Bold);
            LblPartylists.Location = new Point(24, 206);
            LblPartylists.Name = "LblPartylists";
            LblPartylists.Size = new Size(259, 63);
            LblPartylists.TabIndex = 3;
            LblPartylists.Text = "PARTYLISTS";
            LblPartylists.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblCandidatesDesc
            // 
            LblCandidatesDesc.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic);
            LblCandidatesDesc.Location = new Point(1, 269);
            LblCandidatesDesc.Name = "LblCandidatesDesc";
            LblCandidatesDesc.Size = new Size(300, 87);
            LblCandidatesDesc.TabIndex = 2;
            LblCandidatesDesc.Text = "View the list of all individuals running in the election.";
            LblCandidatesDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblCandidates
            // 
            LblCandidates.Font = new Font("Arial", 18F, FontStyle.Bold);
            LblCandidates.Location = new Point(20, 206);
            LblCandidates.Name = "LblCandidates";
            LblCandidates.Size = new Size(259, 63);
            LblCandidates.TabIndex = 1;
            LblCandidates.Text = "CANDIDATES";
            LblCandidates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblStatus
            // 
            LblStatus.BackColor = Color.Transparent;
            LblStatus.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(416, 1345);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(1742, 101);
            LblStatus.TabIndex = 10;
            LblStatus.Text = "YOU SUBMITTED YOUR VOTE. ";
            LblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlPartylists
            // 
            PnlPartylists.BackColor = Color.Transparent;
            PnlPartylists.Controls.Add(PicBoxPartylists);
            PnlPartylists.Controls.Add(LblCandidatesDesc);
            PnlPartylists.Controls.Add(LblCandidates);
            PnlPartylists.Location = new Point(392, 241);
            PnlPartylists.Margin = new Padding(3, 4, 3, 4);
            PnlPartylists.Name = "PnlPartylists";
            PnlPartylists.Size = new Size(300, 387);
            PnlPartylists.TabIndex = 10;
            // 
            // PnlPositions
            // 
            PnlPositions.BackColor = Color.Transparent;
            PnlPositions.Controls.Add(LblPositionsDesc);
            PnlPositions.Controls.Add(PicBoxPositions);
            PnlPositions.Controls.Add(LblPositions);
            PnlPositions.Location = new Point(716, 241);
            PnlPositions.Margin = new Padding(3, 4, 3, 4);
            PnlPositions.Name = "PnlPositions";
            PnlPositions.Size = new Size(300, 387);
            PnlPositions.TabIndex = 11;
            // 
            // LblPositionsDesc
            // 
            LblPositionsDesc.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic);
            LblPositionsDesc.Location = new Point(1, 269);
            LblPositionsDesc.Name = "LblPositionsDesc";
            LblPositionsDesc.Size = new Size(300, 87);
            LblPositionsDesc.TabIndex = 3;
            LblPositionsDesc.Text = "See the roles available and the candidates running for each one.";
            LblPositionsDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblPositions
            // 
            LblPositions.Font = new Font("Arial", 18F, FontStyle.Bold);
            LblPositions.Location = new Point(21, 206);
            LblPositions.Name = "LblPositions";
            LblPositions.Size = new Size(259, 63);
            LblPositions.TabIndex = 2;
            LblPositions.Text = "POSITIONS";
            LblPositions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.BackColor = Color.Transparent;
            LblTitle.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.Brown;
            LblTitle.Location = new Point(384, 9);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(970, 113);
            LblTitle.TabIndex = 9;
            LblTitle.Text = "VIEW THE ELECTION";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDescription
            // 
            LblDescription.BackColor = Color.Transparent;
            LblDescription.Font = new Font("Arial", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblDescription.Location = new Point(392, 109);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(949, 127);
            LblDescription.TabIndex = 12;
            LblDescription.Text = "See all candidates, their positions, and partylists in one place. Quickly browse and get to know who’s running before you vote.";
            LblDescription.TextAlign = ContentAlignment.TopCenter;
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
            PnlNavigation.TabIndex = 27;
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
            LblSideViewElection.BackColor = Color.SteelBlue;
            LblSideViewElection.Cursor = Cursors.Hand;
            LblSideViewElection.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideViewElection.Location = new Point(0, 305);
            LblSideViewElection.Name = "LblSideViewElection";
            LblSideViewElection.Size = new Size(368, 37);
            LblSideViewElection.TabIndex = 21;
            LblSideViewElection.Text = "               VIEW ELECTION";
            LblSideViewElection.TextAlign = ContentAlignment.MiddleLeft;
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
            // BtnVoteNow
            // 
            BtnVoteNow.BackColor = Color.Brown;
            BtnVoteNow.Cursor = Cursors.Hand;
            BtnVoteNow.FlatAppearance.BorderSize = 0;
            BtnVoteNow.FlatStyle = FlatStyle.Flat;
            BtnVoteNow.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoteNow.ForeColor = Color.White;
            BtnVoteNow.Location = new Point(545, 648);
            BtnVoteNow.Margin = new Padding(3, 4, 3, 4);
            BtnVoteNow.Name = "BtnVoteNow";
            BtnVoteNow.Size = new Size(653, 102);
            BtnVoteNow.TabIndex = 35;
            BtnVoteNow.Text = "VOTE NOW";
            BtnVoteNow.UseVisualStyleBackColor = false;
            // 
            // Stud_View_Election
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lightmode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(BtnVoteNow);
            Controls.Add(PnlCandidates);
            Controls.Add(LblDescription);
            Controls.Add(PnlNavigation);
            Controls.Add(LblTitle);
            Controls.Add(PnlPositions);
            Controls.Add(LblStatus);
            Controls.Add(PnlPartylists);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stud_View_Election";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stud_View_Election";
            ((System.ComponentModel.ISupportInitialize)PicBoxCandidates).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPartylists).EndInit();
            PnlCandidates.ResumeLayout(false);
            PnlPartylists.ResumeLayout(false);
            PnlPositions.ResumeLayout(false);
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicBoxCandidates;
        private PictureBox PicBoxPositions;
        private PictureBox PicBoxPartylists;
        private Panel PnlCandidates;
        private Label LblStatus;
        private Panel PnlPartylists;
        private Panel PnlPositions;
        private Label LblTitle;
        private Label LblDescription;
        private Label LblCandidates;
        private Label LblCandidatesDesc;
        private Label LblPartylists;
        private Label LblPositions;
        private Label LblPartylistsDesc;
        private Label LblPositionsDesc;
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
        private Button BtnVoteNow;
    }
}