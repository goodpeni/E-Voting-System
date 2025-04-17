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
            PnlNavigation = new Panel();
            RdoDark = new RadioButton();
            RdoLight = new RadioButton();
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
            PnlCandidates = new Panel();
            LblCandidatesDesc = new Label();
            LblCandidates = new Label();
            LblStatus = new Label();
            PnlPartylists = new Panel();
            LblPartylistsDesc = new Label();
            LblPartylists = new Label();
            PnlPositions = new Panel();
            LblPositionsDesc = new Label();
            LblPositions = new Label();
            LblTitle = new Label();
            LblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)PicBoxCandidates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPartylists).BeginInit();
            PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            PnlCandidates.SuspendLayout();
            PnlPartylists.SuspendLayout();
            PnlPositions.SuspendLayout();
            SuspendLayout();
            // 
            // PicBoxCandidates
            // 
            PicBoxCandidates.BackgroundImage = Properties.Resources.list;
            PicBoxCandidates.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxCandidates.Location = new Point(71, 20);
            PicBoxCandidates.Margin = new Padding(3, 2, 3, 2);
            PicBoxCandidates.Name = "PicBoxCandidates";
            PicBoxCandidates.Size = new Size(300, 300);
            PicBoxCandidates.TabIndex = 0;
            PicBoxCandidates.TabStop = false;
            PicBoxCandidates.Click += PicBoxCandidates_Click;
            // 
            // PicBoxPositions
            // 
            PicBoxPositions.BackgroundImage = Properties.Resources.listings;
            PicBoxPositions.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxPositions.Location = new Point(68, 20);
            PicBoxPositions.Margin = new Padding(3, 2, 3, 2);
            PicBoxPositions.Name = "PicBoxPositions";
            PicBoxPositions.Size = new Size(300, 300);
            PicBoxPositions.TabIndex = 1;
            PicBoxPositions.TabStop = false;
            PicBoxPositions.Click += PicBoxPositions_Click;
            // 
            // PicBoxPartylists
            // 
            PicBoxPartylists.BackgroundImage = Properties.Resources.guest_list;
            PicBoxPartylists.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxPartylists.Location = new Point(66, 23);
            PicBoxPartylists.Margin = new Padding(3, 2, 3, 2);
            PicBoxPartylists.Name = "PicBoxPartylists";
            PicBoxPartylists.Size = new Size(300, 300);
            PicBoxPartylists.TabIndex = 2;
            PicBoxPartylists.TabStop = false;
            PicBoxPartylists.Click += PicBoxPartylists_Click;
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
            PnlNavigation.Controls.Add(LblSideCandidates);
            PnlNavigation.Controls.Add(LblSideViewElection);
            PnlNavigation.Controls.Add(LblSideVotersManual);
            PnlNavigation.Controls.Add(LblSideHome);
            PnlNavigation.Controls.Add(LblSideTitle);
            PnlNavigation.Controls.Add(PicBoxLogo);
            PnlNavigation.Dock = DockStyle.Left;
            PnlNavigation.Location = new Point(0, 0);
            PnlNavigation.Margin = new Padding(3, 2, 3, 2);
            PnlNavigation.Name = "PnlNavigation";
            PnlNavigation.Size = new Size(348, 1100);
            PnlNavigation.TabIndex = 8;
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
            // LblSideCandidates
            // 
            LblSideCandidates.Cursor = Cursors.Hand;
            LblSideCandidates.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideCandidates.Location = new Point(0, 381);
            LblSideCandidates.Name = "LblSideCandidates";
            LblSideCandidates.Size = new Size(348, 28);
            LblSideCandidates.TabIndex = 22;
            LblSideCandidates.Text = "                         CANDIDATES";
            LblSideCandidates.TextAlign = ContentAlignment.MiddleLeft;
            LblSideCandidates.Click += LblCandidates_Click;
            // 
            // LblSideViewElection
            // 
            LblSideViewElection.BackColor = Color.SteelBlue;
            LblSideViewElection.Cursor = Cursors.Hand;
            LblSideViewElection.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideViewElection.Location = new Point(0, 325);
            LblSideViewElection.Name = "LblSideViewElection";
            LblSideViewElection.Size = new Size(348, 28);
            LblSideViewElection.TabIndex = 21;
            LblSideViewElection.Text = "               VIEW ELECTION";
            LblSideViewElection.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideVotersManual
            // 
            LblSideVotersManual.BackColor = Color.Transparent;
            LblSideVotersManual.Cursor = Cursors.Hand;
            LblSideVotersManual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVotersManual.Location = new Point(0, 263);
            LblSideVotersManual.Name = "LblSideVotersManual";
            LblSideVotersManual.Size = new Size(348, 28);
            LblSideVotersManual.TabIndex = 20;
            LblSideVotersManual.Text = "               VOTER'S MANUAL\r\n";
            LblSideVotersManual.TextAlign = ContentAlignment.MiddleLeft;
            LblSideVotersManual.Click += LblSideVotersManual_Click;
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
            // PnlCandidates
            // 
            PnlCandidates.BackColor = Color.Transparent;
            PnlCandidates.Controls.Add(LblCandidatesDesc);
            PnlCandidates.Controls.Add(LblCandidates);
            PnlCandidates.Controls.Add(PicBoxCandidates);
            PnlCandidates.Location = new Point(427, 283);
            PnlCandidates.Name = "PnlCandidates";
            PnlCandidates.Size = new Size(436, 627);
            PnlCandidates.TabIndex = 9;
            // 
            // LblCandidatesDesc
            // 
            LblCandidatesDesc.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCandidatesDesc.Location = new Point(28, 399);
            LblCandidatesDesc.Name = "LblCandidatesDesc";
            LblCandidatesDesc.Size = new Size(379, 95);
            LblCandidatesDesc.TabIndex = 2;
            LblCandidatesDesc.Text = "View the list of all individuals running in the election.";
            LblCandidatesDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblCandidates
            // 
            LblCandidates.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCandidates.Location = new Point(99, 335);
            LblCandidates.Name = "LblCandidates";
            LblCandidates.Size = new Size(227, 47);
            LblCandidates.TabIndex = 1;
            LblCandidates.Text = "CANDIDATES";
            LblCandidates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblStatus
            // 
            LblStatus.BackColor = Color.Transparent;
            LblStatus.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(364, 949);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(1524, 76);
            LblStatus.TabIndex = 10;
            LblStatus.Text = "YOU SUBMITTED YOUR VOTE. ";
            LblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlPartylists
            // 
            PnlPartylists.BackColor = Color.Transparent;
            PnlPartylists.Controls.Add(LblPartylistsDesc);
            PnlPartylists.Controls.Add(LblPartylists);
            PnlPartylists.Controls.Add(PicBoxPartylists);
            PnlPartylists.Location = new Point(1391, 283);
            PnlPartylists.Name = "PnlPartylists";
            PnlPartylists.Size = new Size(436, 627);
            PnlPartylists.TabIndex = 10;
            // 
            // LblPartylistsDesc
            // 
            LblPartylistsDesc.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPartylistsDesc.Location = new Point(27, 399);
            LblPartylistsDesc.Name = "LblPartylistsDesc";
            LblPartylistsDesc.Size = new Size(379, 95);
            LblPartylistsDesc.TabIndex = 4;
            LblPartylistsDesc.Text = "Check the groups or organizations each candidate represents.";
            LblPartylistsDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblPartylists
            // 
            LblPartylists.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPartylists.Location = new Point(103, 335);
            LblPartylists.Name = "LblPartylists";
            LblPartylists.Size = new Size(227, 47);
            LblPartylists.TabIndex = 3;
            LblPartylists.Text = "PARTYLISTS";
            LblPartylists.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlPositions
            // 
            PnlPositions.BackColor = Color.Transparent;
            PnlPositions.Controls.Add(LblPositionsDesc);
            PnlPositions.Controls.Add(LblPositions);
            PnlPositions.Controls.Add(PicBoxPositions);
            PnlPositions.Location = new Point(909, 283);
            PnlPositions.Name = "PnlPositions";
            PnlPositions.Size = new Size(436, 627);
            PnlPositions.TabIndex = 11;
            // 
            // LblPositionsDesc
            // 
            LblPositionsDesc.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPositionsDesc.Location = new Point(26, 399);
            LblPositionsDesc.Name = "LblPositionsDesc";
            LblPositionsDesc.Size = new Size(379, 95);
            LblPositionsDesc.TabIndex = 3;
            LblPositionsDesc.Text = "See the roles available and the candidates running for each one.";
            LblPositionsDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblPositions
            // 
            LblPositions.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPositions.Location = new Point(106, 335);
            LblPositions.Name = "LblPositions";
            LblPositions.Size = new Size(227, 47);
            LblPositions.TabIndex = 2;
            LblPositions.Text = "POSITIONS";
            LblPositions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.BackColor = Color.Transparent;
            LblTitle.Font = new Font("Arial Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.Brown;
            LblTitle.Location = new Point(565, -2);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(1159, 136);
            LblTitle.TabIndex = 9;
            LblTitle.Text = "VIEW THE ELECTION";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDescription
            // 
            LblDescription.BackColor = Color.Transparent;
            LblDescription.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescription.Location = new Point(427, 134);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(1400, 120);
            LblDescription.TabIndex = 12;
            LblDescription.Text = "See all candidates, their positions, and partylists in one place. Quickly browse and get to know who’s running before you vote.";
            LblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // Stud_View_Election
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lightmode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1100);
            Controls.Add(LblDescription);
            Controls.Add(LblTitle);
            Controls.Add(PnlPositions);
            Controls.Add(PnlPartylists);
            Controls.Add(LblStatus);
            Controls.Add(PnlCandidates);
            Controls.Add(PnlNavigation);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Stud_View_Election";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stud_View_Election";
            ((System.ComponentModel.ISupportInitialize)PicBoxCandidates).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPartylists).EndInit();
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            PnlCandidates.ResumeLayout(false);
            PnlPartylists.ResumeLayout(false);
            PnlPositions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicBoxCandidates;
        private PictureBox PicBoxPositions;
        private PictureBox PicBoxPartylists;
        private Panel PnlNavigation;
        private RadioButton RdoDark;
        private RadioButton RdoLight;
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
    }
}