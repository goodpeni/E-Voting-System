namespace E_Voting_System
{
    partial class Profile
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
            LblTitle = new Label();
            LblStudentID = new Label();
            TxtStudentID = new TextBox();
            LblFirstName = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            LblLastName = new Label();
            TxtMiddleName = new TextBox();
            LblMiddleName = new Label();
            TxtGradeSection = new TextBox();
            LblGradeSection = new Label();
            TxtAge = new TextBox();
            LblAge = new Label();
            TxtSex = new TextBox();
            LblSex = new Label();
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
            PnlNavigation.Size = new Size(348, 1100);
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
            LblSideViewProfile.BackColor = Color.SteelBlue;
            LblSideViewProfile.Cursor = Cursors.Hand;
            LblSideViewProfile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideViewProfile.Location = new Point(0, 632);
            LblSideViewProfile.Name = "LblSideViewProfile";
            LblSideViewProfile.Size = new Size(348, 28);
            LblSideViewProfile.TabIndex = 27;
            LblSideViewProfile.Text = "               VIEW PROFILE";
            LblSideViewProfile.TextAlign = ContentAlignment.MiddleLeft;
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
            LblSideVotersManual.Cursor = Cursors.Hand;
            LblSideVotersManual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVotersManual.Location = new Point(0, 263);
            LblSideVotersManual.Name = "LblSideVotersManual";
            LblSideVotersManual.Size = new Size(348, 28);
            LblSideVotersManual.TabIndex = 20;
            LblSideVotersManual.Text = "               VOTER'S MANUAL";
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
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.BackColor = Color.Transparent;
            LblTitle.Font = new Font("Arial Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.Brown;
            LblTitle.Location = new Point(562, 38);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(1152, 136);
            LblTitle.TabIndex = 8;
            LblTitle.Text = "STUDENT'S PROFILE";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblStudentID
            // 
            LblStudentID.BackColor = Color.Transparent;
            LblStudentID.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStudentID.Location = new Point(364, 204);
            LblStudentID.Name = "LblStudentID";
            LblStudentID.Size = new Size(1528, 40);
            LblStudentID.TabIndex = 9;
            LblStudentID.Text = "STUDENT ID";
            LblStudentID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtStudentID
            // 
            TxtStudentID.Enabled = false;
            TxtStudentID.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtStudentID.Location = new Point(831, 247);
            TxtStudentID.Name = "TxtStudentID";
            TxtStudentID.Size = new Size(577, 48);
            TxtStudentID.TabIndex = 10;
            // 
            // LblFirstName
            // 
            LblFirstName.BackColor = Color.Transparent;
            LblFirstName.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFirstName.Location = new Point(1012, 377);
            LblFirstName.Name = "LblFirstName";
            LblFirstName.Size = new Size(244, 40);
            LblFirstName.TabIndex = 11;
            LblFirstName.Text = "FIRST NAME";
            LblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(880, 421);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(494, 48);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(375, 421);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(494, 48);
            textBox3.TabIndex = 14;
            // 
            // LblLastName
            // 
            LblLastName.BackColor = Color.Transparent;
            LblLastName.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLastName.Location = new Point(507, 377);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(244, 40);
            LblLastName.TabIndex = 13;
            LblLastName.Text = "LAST NAME";
            LblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtMiddleName
            // 
            TxtMiddleName.Enabled = false;
            TxtMiddleName.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMiddleName.Location = new Point(1386, 421);
            TxtMiddleName.Name = "TxtMiddleName";
            TxtMiddleName.Size = new Size(494, 48);
            TxtMiddleName.TabIndex = 16;
            // 
            // LblMiddleName
            // 
            LblMiddleName.BackColor = Color.Transparent;
            LblMiddleName.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMiddleName.Location = new Point(1518, 377);
            LblMiddleName.Name = "LblMiddleName";
            LblMiddleName.Size = new Size(244, 40);
            LblMiddleName.TabIndex = 15;
            LblMiddleName.Text = "MIDDLE NAME";
            LblMiddleName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtGradeSection
            // 
            TxtGradeSection.Enabled = false;
            TxtGradeSection.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtGradeSection.Location = new Point(1386, 671);
            TxtGradeSection.Name = "TxtGradeSection";
            TxtGradeSection.Size = new Size(494, 48);
            TxtGradeSection.TabIndex = 22;
            // 
            // LblGradeSection
            // 
            LblGradeSection.BackColor = Color.Transparent;
            LblGradeSection.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblGradeSection.Location = new Point(1462, 627);
            LblGradeSection.Name = "LblGradeSection";
            LblGradeSection.Size = new Size(362, 40);
            LblGradeSection.TabIndex = 21;
            LblGradeSection.Text = "GRADE AND SECTION";
            LblGradeSection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtAge
            // 
            TxtAge.Enabled = false;
            TxtAge.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAge.Location = new Point(375, 671);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(494, 48);
            TxtAge.TabIndex = 20;
            // 
            // LblAge
            // 
            LblAge.BackColor = Color.Transparent;
            LblAge.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAge.Location = new Point(507, 627);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(244, 40);
            LblAge.TabIndex = 19;
            LblAge.Text = "AGE";
            LblAge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtSex
            // 
            TxtSex.Enabled = false;
            TxtSex.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSex.Location = new Point(880, 671);
            TxtSex.Name = "TxtSex";
            TxtSex.Size = new Size(494, 48);
            TxtSex.TabIndex = 18;
            // 
            // LblSex
            // 
            LblSex.BackColor = Color.Transparent;
            LblSex.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSex.Location = new Point(1012, 627);
            LblSex.Name = "LblSex";
            LblSex.Size = new Size(244, 40);
            LblSex.TabIndex = 17;
            LblSex.Text = "SEX";
            LblSex.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lightmode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1100);
            Controls.Add(TxtGradeSection);
            Controls.Add(LblGradeSection);
            Controls.Add(TxtAge);
            Controls.Add(LblAge);
            Controls.Add(TxtSex);
            Controls.Add(LblSex);
            Controls.Add(TxtMiddleName);
            Controls.Add(LblMiddleName);
            Controls.Add(textBox3);
            Controls.Add(LblLastName);
            Controls.Add(textBox2);
            Controls.Add(LblFirstName);
            Controls.Add(TxtStudentID);
            Controls.Add(LblStudentID);
            Controls.Add(LblTitle);
            Controls.Add(PnlNavigation);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label LblTitle;
        private Label LblStudentID;
        private TextBox TxtStudentID;
        private Label LblFirstName;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label LblLastName;
        private TextBox TxtMiddleName;
        private Label LblMiddleName;
        private TextBox TxtGradeSection;
        private Label LblGradeSection;
        private TextBox TxtAge;
        private Label LblAge;
        private TextBox TxtSex;
        private Label LblSex;
    }
}