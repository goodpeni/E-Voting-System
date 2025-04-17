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
            LblSideVotersManual = new Label();
            LblSideHome = new Label();
            LblSideTitle = new Label();
            LblTitle = new Label();
            LblStatus = new Label();
            LblGreetings = new Label();
            LblYLevel = new Label();
            LblDescription = new Label();
            PnlOverview = new Panel();
            LblVotersManualDesc = new Label();
            LblOverview = new Label();
            pictureBox1 = new PictureBox();
            PnlViewElection = new Panel();
            LblViewElectionDesc = new Label();
            LblViewElection = new Label();
            PnlMyVote = new Panel();
            LblMyVoteDesc = new Label();
            LblMyVote = new Label();
            pictureBox2 = new PictureBox();
            LblReadyToVote = new Label();
            BtnVoteNow = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxMyVote).BeginInit();
            PnlNavigation.SuspendLayout();
            PnlOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PnlViewElection.SuspendLayout();
            PnlMyVote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PicBoxOverview
            // 
            PicBoxOverview.BackgroundImage = Properties.Resources.research;
            PicBoxOverview.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxOverview.Cursor = Cursors.Hand;
            PicBoxOverview.Location = new Point(91, 34);
            PicBoxOverview.Margin = new Padding(3, 2, 3, 2);
            PicBoxOverview.Name = "PicBoxOverview";
            PicBoxOverview.Size = new Size(200, 200);
            PicBoxOverview.TabIndex = 0;
            PicBoxOverview.TabStop = false;
            PicBoxOverview.Click += PicBoxOverview_Click;
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
            // PicBoxViewElection
            // 
            PicBoxViewElection.BackgroundImage = Properties.Resources.elections;
            PicBoxViewElection.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxViewElection.Cursor = Cursors.Hand;
            PicBoxViewElection.Location = new Point(94, 34);
            PicBoxViewElection.Margin = new Padding(3, 2, 3, 2);
            PicBoxViewElection.Name = "PicBoxViewElection";
            PicBoxViewElection.Size = new Size(200, 200);
            PicBoxViewElection.TabIndex = 3;
            PicBoxViewElection.TabStop = false;
            PicBoxViewElection.Click += PicBoxViewElection_Click;
            // 
            // PicBoxMyVote
            // 
            PicBoxMyVote.BackgroundImage = Properties.Resources.voting_box1;
            PicBoxMyVote.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxMyVote.Cursor = Cursors.Hand;
            PicBoxMyVote.Location = new Point(101, 34);
            PicBoxMyVote.Margin = new Padding(3, 2, 3, 2);
            PicBoxMyVote.Name = "PicBoxMyVote";
            PicBoxMyVote.Size = new Size(200, 200);
            PicBoxMyVote.TabIndex = 4;
            PicBoxMyVote.TabStop = false;
            PicBoxMyVote.Click += PicBoxMyVote_Click;
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
            BtnLogout.Location = new Point(294, 995);
            BtnLogout.Margin = new Padding(3, 2, 3, 2);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(42, 38);
            BtnLogout.TabIndex = 5;
            BtnLogout.UseVisualStyleBackColor = false;
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
            PnlNavigation.Controls.Add(LblSideVotersManual);
            PnlNavigation.Controls.Add(LblSideHome);
            PnlNavigation.Controls.Add(LblSideTitle);
            PnlNavigation.Controls.Add(PicBoxLogo);
            PnlNavigation.Controls.Add(BtnLogout);
            PnlNavigation.Dock = DockStyle.Left;
            PnlNavigation.Location = new Point(0, 0);
            PnlNavigation.Margin = new Padding(3, 2, 3, 2);
            PnlNavigation.Name = "PnlNavigation";
            PnlNavigation.Size = new Size(348, 1041);
            PnlNavigation.TabIndex = 6;
            // 
            // LblInfo
            // 
            LblInfo.Cursor = Cursors.Hand;
            LblInfo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblInfo.Location = new Point(43, 998);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(219, 28);
            LblInfo.TabIndex = 31;
            LblInfo.Text = "ABOUT US";
            LblInfo.TextAlign = ContentAlignment.MiddleCenter;
            LblInfo.Click += LblInfo_Click;
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
            LblTheme.Click += LblTheme_Click;
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
            LblSideVotersManual.Cursor = Cursors.Hand;
            LblSideVotersManual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVotersManual.Location = new Point(0, 263);
            LblSideVotersManual.Name = "LblSideVotersManual";
            LblSideVotersManual.Size = new Size(348, 28);
            LblSideVotersManual.TabIndex = 20;
            LblSideVotersManual.Text = "               VOTER'S MANUAL";
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
            // LblTitle
            // 
            LblTitle.BackColor = Color.Transparent;
            LblTitle.Font = new Font("Arial Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.Gold;
            LblTitle.Location = new Point(368, 0);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(1466, 122);
            LblTitle.TabIndex = 7;
            LblTitle.Text = "HALAL 2025";
            LblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblStatus
            // 
            LblStatus.BackColor = Color.Transparent;
            LblStatus.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(368, 958);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(1524, 76);
            LblStatus.TabIndex = 8;
            LblStatus.Text = "YOU SUBMITTED YOUR VOTE. ";
            LblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblGreetings
            // 
            LblGreetings.BackColor = Color.Transparent;
            LblGreetings.Font = new Font("Arial", 24F, FontStyle.Bold);
            LblGreetings.ForeColor = Color.Black;
            LblGreetings.Location = new Point(364, 135);
            LblGreetings.Name = "LblGreetings";
            LblGreetings.Size = new Size(459, 49);
            LblGreetings.TabIndex = 9;
            LblGreetings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblYLevel
            // 
            LblYLevel.BackColor = Color.Transparent;
            LblYLevel.Font = new Font("Arial", 24F, FontStyle.Bold);
            LblYLevel.ForeColor = Color.Black;
            LblYLevel.Location = new Point(364, 184);
            LblYLevel.Name = "LblYLevel";
            LblYLevel.Size = new Size(459, 33);
            LblYLevel.TabIndex = 10;
            LblYLevel.Text = "GRADE 1 - MAHUSAY";
            LblYLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblDescription
            // 
            LblDescription.BackColor = Color.Transparent;
            LblDescription.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescription.ForeColor = Color.Black;
            LblDescription.Location = new Point(846, 122);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(1023, 106);
            LblDescription.TabIndex = 11;
            LblDescription.Text = "You are now logged in to the official Ibayo Elementary School Student Council Voting System. Please review the candidates and cast your vote responsibly.";
            LblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PnlOverview
            // 
            PnlOverview.BackColor = Color.Transparent;
            PnlOverview.Controls.Add(LblVotersManualDesc);
            PnlOverview.Controls.Add(LblOverview);
            PnlOverview.Controls.Add(PicBoxOverview);
            PnlOverview.Location = new Point(417, 510);
            PnlOverview.Name = "PnlOverview";
            PnlOverview.Size = new Size(389, 425);
            PnlOverview.TabIndex = 18;
            PnlOverview.Click += PnlOverview_Click;
            // 
            // LblVotersManualDesc
            // 
            LblVotersManualDesc.Cursor = Cursors.Hand;
            LblVotersManualDesc.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblVotersManualDesc.Location = new Point(23, 282);
            LblVotersManualDesc.Name = "LblVotersManualDesc";
            LblVotersManualDesc.Size = new Size(342, 124);
            LblVotersManualDesc.TabIndex = 2;
            LblVotersManualDesc.Text = "A quick guide to help you vote safely and easily in HALAL 2025.";
            LblVotersManualDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblOverview
            // 
            LblOverview.Cursor = Cursors.Hand;
            LblOverview.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblOverview.Location = new Point(75, 239);
            LblOverview.Name = "LblOverview";
            LblOverview.Size = new Size(233, 42);
            LblOverview.TabIndex = 1;
            LblOverview.Text = "VOTER'S MANUAL";
            LblOverview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(136, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PnlViewElection
            // 
            PnlViewElection.BackColor = Color.Transparent;
            PnlViewElection.Controls.Add(LblViewElectionDesc);
            PnlViewElection.Controls.Add(LblViewElection);
            PnlViewElection.Controls.Add(pictureBox1);
            PnlViewElection.Controls.Add(PicBoxViewElection);
            PnlViewElection.Location = new Point(936, 510);
            PnlViewElection.Name = "PnlViewElection";
            PnlViewElection.Size = new Size(389, 425);
            PnlViewElection.TabIndex = 19;
            PnlViewElection.Click += PnlViewElection_Click;
            // 
            // LblViewElectionDesc
            // 
            LblViewElectionDesc.Cursor = Cursors.Hand;
            LblViewElectionDesc.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblViewElectionDesc.Location = new Point(23, 282);
            LblViewElectionDesc.Name = "LblViewElectionDesc";
            LblViewElectionDesc.Size = new Size(342, 124);
            LblViewElectionDesc.TabIndex = 3;
            LblViewElectionDesc.Text = "View the general details of the election, such as the candidates, their positions, and their assigned partylists.\r\n";
            LblViewElectionDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblViewElection
            // 
            LblViewElection.Cursor = Cursors.Hand;
            LblViewElection.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblViewElection.Location = new Point(94, 240);
            LblViewElection.Name = "LblViewElection";
            LblViewElection.Size = new Size(200, 42);
            LblViewElection.TabIndex = 2;
            LblViewElection.Text = "VIEW ELECTION";
            LblViewElection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlMyVote
            // 
            PnlMyVote.BackColor = Color.Transparent;
            PnlMyVote.Controls.Add(LblMyVoteDesc);
            PnlMyVote.Controls.Add(LblMyVote);
            PnlMyVote.Controls.Add(pictureBox2);
            PnlMyVote.Controls.Add(PicBoxMyVote);
            PnlMyVote.Location = new Point(1444, 510);
            PnlMyVote.Name = "PnlMyVote";
            PnlMyVote.Size = new Size(389, 425);
            PnlMyVote.TabIndex = 20;
            PnlMyVote.Click += PnlMyVote_Click;
            // 
            // LblMyVoteDesc
            // 
            LblMyVoteDesc.Cursor = Cursors.Hand;
            LblMyVoteDesc.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMyVoteDesc.Location = new Point(23, 282);
            LblMyVoteDesc.Name = "LblMyVoteDesc";
            LblMyVoteDesc.Size = new Size(342, 124);
            LblMyVoteDesc.TabIndex = 4;
            LblMyVoteDesc.Text = "View the candidates you voted for. Once submitted, your selections are final and cannot be changed.\r\n";
            LblMyVoteDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblMyVote
            // 
            LblMyVote.Cursor = Cursors.Hand;
            LblMyVote.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMyVote.Location = new Point(101, 240);
            LblMyVote.Name = "LblMyVote";
            LblMyVote.Size = new Size(200, 42);
            LblMyVote.TabIndex = 4;
            LblMyVote.Text = "MY VOTE";
            LblMyVote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(136, 14);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // LblReadyToVote
            // 
            LblReadyToVote.BackColor = Color.Transparent;
            LblReadyToVote.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblReadyToVote.ForeColor = Color.Black;
            LblReadyToVote.Location = new Point(386, 247);
            LblReadyToVote.Name = "LblReadyToVote";
            LblReadyToVote.Size = new Size(1416, 90);
            LblReadyToVote.TabIndex = 23;
            LblReadyToVote.Text = "READY TO VOTE?";
            LblReadyToVote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVoteNow
            // 
            BtnVoteNow.BackColor = Color.Brown;
            BtnVoteNow.Cursor = Cursors.Hand;
            BtnVoteNow.FlatAppearance.BorderSize = 0;
            BtnVoteNow.FlatStyle = FlatStyle.Flat;
            BtnVoteNow.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoteNow.ForeColor = Color.White;
            BtnVoteNow.Location = new Point(391, 352);
            BtnVoteNow.Name = "BtnVoteNow";
            BtnVoteNow.Size = new Size(1466, 136);
            BtnVoteNow.TabIndex = 24;
            BtnVoteNow.Text = "VOTE NOW";
            BtnVoteNow.UseVisualStyleBackColor = false;
            BtnVoteNow.Click += BtnVoteNow_Click;
            // 
            // Student_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.lightmode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            ControlBox = false;
            Controls.Add(BtnVoteNow);
            Controls.Add(LblReadyToVote);
            Controls.Add(LblDescription);
            Controls.Add(LblYLevel);
            Controls.Add(LblStatus);
            Controls.Add(LblTitle);
            Controls.Add(PnlNavigation);
            Controls.Add(PnlOverview);
            Controls.Add(PnlViewElection);
            Controls.Add(PnlMyVote);
            Controls.Add(LblGreetings);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Student_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Home";
            Load += Student_Home_Load;
            ((System.ComponentModel.ISupportInitialize)PicBoxOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxMyVote).EndInit();
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            PnlOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PnlViewElection.ResumeLayout(false);
            PnlMyVote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxOverview;
        private PictureBox PicBoxLogo;
        private PictureBox PicBoxViewElection;
        private PictureBox PicBoxMyVote;
        private Button BtnLogout;
        private Panel PnlNavigation;
        private Label LblTitle;
        private Label LblStatus;
        private Label LblGreetings;
        private Label LblYLevel;
        private Label LblDescription;
        private Label LblSideTitle;
        private Label LblSideHome;
        private Label LblSideViewElection;
        private Label LblSideVotersManual;
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
        private Panel PnlOverview;
        private PictureBox pictureBox1;
        private Panel PnlViewElection;
        private Panel PnlMyVote;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LblReadyToVote;
        private Button BtnVoteNow;
        private Label LblOverview;
        private Label LblViewElection;
        private Label LblMyVote;
        private Label LblVotersManualDesc;
        private Label LblViewElectionDesc;
        private Label LblMyVoteDesc;
    }
}