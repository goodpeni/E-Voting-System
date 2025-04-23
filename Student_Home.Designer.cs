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
            LblStatus = new Label();
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
            LblCandidates = new Label();
            LblSideViewElection = new Label();
            LblSideVotersManual = new Label();
            LblSideHome = new Label();
            LblSideTitle = new Label();
            PicBoxLogo = new PictureBox();
            PnlMyVote = new Panel();
            pictureBox2 = new PictureBox();
            LblMyVoteDesc = new Label();
            LblMyVote = new Label();
            PicBoxMyVote = new PictureBox();
            LblTitle = new Label();
            BtnVoteNow = new Button();
            LblYLevel = new Label();
            LblDescription = new Label();
            LblReadyToVote = new Label();
            PnlViewElection = new Panel();
            pictureBox1 = new PictureBox();
            LblOverview = new Label();
            LblVotersManualDesc = new Label();
            PicBoxViewElection = new PictureBox();
            LblGreetings = new Label();
            PnlOverview = new Panel();
            LblViewElectionDesc = new Label();
            LblViewElection = new Label();
            PicBoxOverview = new PictureBox();
            PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).BeginInit();
            PnlMyVote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxMyVote).BeginInit();
            PnlViewElection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).BeginInit();
            PnlOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxOverview).BeginInit();
            SuspendLayout();
            // 
            // LblStatus
            // 
            LblStatus.BackColor = Color.Transparent;
            LblStatus.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(576, 701);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(605, 52);
            LblStatus.TabIndex = 8;
            LblStatus.Text = "YOU SUBMITTED YOUR VOTE. ";
            LblStatus.TextAlign = ContentAlignment.MiddleCenter;
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
            PnlNavigation.Controls.Add(LblCandidates);
            PnlNavigation.Controls.Add(LblSideViewElection);
            PnlNavigation.Controls.Add(LblSideVotersManual);
            PnlNavigation.Controls.Add(LblSideHome);
            PnlNavigation.Controls.Add(LblSideTitle);
            PnlNavigation.Controls.Add(PicBoxLogo);
            PnlNavigation.Dock = DockStyle.Left;
            PnlNavigation.Location = new Point(0, 0);
            PnlNavigation.Name = "PnlNavigation";
            PnlNavigation.Size = new Size(368, 768);
            PnlNavigation.TabIndex = 25;
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
            // LblCandidates
            // 
            LblCandidates.Cursor = Cursors.Hand;
            LblCandidates.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCandidates.Location = new Point(0, 347);
            LblCandidates.Name = "LblCandidates";
            LblCandidates.Size = new Size(368, 37);
            LblCandidates.TabIndex = 22;
            LblCandidates.Text = "                         CANDIDATES";
            LblCandidates.TextAlign = ContentAlignment.MiddleLeft;
            LblCandidates.Click += LblCandidates_Click;
            // 
            // LblSideViewElection
            // 
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
            LblSideVotersManual.Cursor = Cursors.Hand;
            LblSideVotersManual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideVotersManual.Location = new Point(0, 263);
            LblSideVotersManual.Name = "LblSideVotersManual";
            LblSideVotersManual.Size = new Size(368, 37);
            LblSideVotersManual.TabIndex = 20;
            LblSideVotersManual.Text = "               VOTER'S MANUAL";
            LblSideVotersManual.TextAlign = ContentAlignment.MiddleLeft;
            LblSideVotersManual.Click += LblSideOverview_Click;
            // 
            // LblSideHome
            // 
            LblSideHome.BackColor = Color.SteelBlue;
            LblSideHome.Cursor = Cursors.Hand;
            LblSideHome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideHome.Location = new Point(0, 221);
            LblSideHome.Name = "LblSideHome";
            LblSideHome.Size = new Size(368, 37);
            LblSideHome.TabIndex = 19;
            LblSideHome.Text = "               HOME";
            LblSideHome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSideTitle
            // 
            LblSideTitle.Cursor = Cursors.Hand;
            LblSideTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSideTitle.Location = new Point(77, 182);
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
            PicBoxLogo.Location = new Point(101, 31);
            PicBoxLogo.Name = "PicBoxLogo";
            PicBoxLogo.Size = new Size(150, 150);
            PicBoxLogo.TabIndex = 1;
            PicBoxLogo.TabStop = false;
            // 
            // PnlMyVote
            // 
            PnlMyVote.BackColor = Color.Transparent;
            PnlMyVote.Controls.Add(pictureBox2);
            PnlMyVote.Controls.Add(LblMyVoteDesc);
            PnlMyVote.Controls.Add(LblMyVote);
            PnlMyVote.Controls.Add(PicBoxMyVote);
            PnlMyVote.Location = new Point(1045, 355);
            PnlMyVote.Margin = new Padding(3, 4, 3, 4);
            PnlMyVote.Name = "PnlMyVote";
            PnlMyVote.Size = new Size(300, 340);
            PnlMyVote.TabIndex = 32;
            PnlMyVote.Click += PnlMyVote_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(155, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // LblMyVoteDesc
            // 
            LblMyVoteDesc.Cursor = Cursors.Hand;
            LblMyVoteDesc.Font = new Font("Arial", 12F, FontStyle.Italic);
            LblMyVoteDesc.Location = new Point(0, 215);
            LblMyVoteDesc.Name = "LblMyVoteDesc";
            LblMyVoteDesc.Size = new Size(300, 109);
            LblMyVoteDesc.TabIndex = 4;
            LblMyVoteDesc.Text = "View the candidates you voted for. Once submitted, your selections are final and cannot be changed.\r\n";
            LblMyVoteDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblMyVote
            // 
            LblMyVote.Cursor = Cursors.Hand;
            LblMyVote.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            LblMyVote.Location = new Point(23, 165);
            LblMyVote.Name = "LblMyVote";
            LblMyVote.Size = new Size(253, 41);
            LblMyVote.TabIndex = 4;
            LblMyVote.Text = "MY VOTE";
            LblMyVote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PicBoxMyVote
            // 
            PicBoxMyVote.BackgroundImage = Properties.Resources.voting_box1;
            PicBoxMyVote.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxMyVote.Cursor = Cursors.Hand;
            PicBoxMyVote.Location = new Point(72, 12);
            PicBoxMyVote.Name = "PicBoxMyVote";
            PicBoxMyVote.Size = new Size(150, 150);
            PicBoxMyVote.TabIndex = 4;
            PicBoxMyVote.TabStop = false;
            PicBoxMyVote.Click += PicBoxMyVote_Click;
            // 
            // LblTitle
            // 
            LblTitle.BackColor = Color.Transparent;
            LblTitle.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.Gold;
            LblTitle.Location = new Point(587, 0);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(635, 118);
            LblTitle.TabIndex = 26;
            LblTitle.Text = "HALAL 2025";
            LblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnVoteNow
            // 
            BtnVoteNow.BackColor = Color.Brown;
            BtnVoteNow.Cursor = Cursors.Hand;
            BtnVoteNow.FlatAppearance.BorderSize = 0;
            BtnVoteNow.FlatStyle = FlatStyle.Flat;
            BtnVoteNow.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoteNow.ForeColor = Color.White;
            BtnVoteNow.Location = new Point(661, 266);
            BtnVoteNow.Margin = new Padding(3, 4, 3, 4);
            BtnVoteNow.Name = "BtnVoteNow";
            BtnVoteNow.Size = new Size(485, 67);
            BtnVoteNow.TabIndex = 34;
            BtnVoteNow.Text = "VOTE NOW";
            BtnVoteNow.UseVisualStyleBackColor = false;
            BtnVoteNow.Click += BtnVoteNow_Click;
            // 
            // LblYLevel
            // 
            LblYLevel.BackColor = Color.Transparent;
            LblYLevel.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            LblYLevel.ForeColor = Color.Black;
            LblYLevel.Location = new Point(926, 109);
            LblYLevel.Name = "LblYLevel";
            LblYLevel.Size = new Size(429, 44);
            LblYLevel.TabIndex = 28;
            LblYLevel.Text = "GRADE 1 - MAHUSAY";
            LblYLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblDescription
            // 
            LblDescription.BackColor = Color.Transparent;
            LblDescription.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescription.ForeColor = Color.Black;
            LblDescription.Location = new Point(404, 153);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(950, 61);
            LblDescription.TabIndex = 29;
            LblDescription.Text = "You are now logged in to the official Ibayo Elementary School Student Council Voting System. Please review the candidates and cast your vote responsibly.";
            LblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblReadyToVote
            // 
            LblReadyToVote.BackColor = Color.Transparent;
            LblReadyToVote.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblReadyToVote.ForeColor = Color.Black;
            LblReadyToVote.Location = new Point(661, 213);
            LblReadyToVote.Name = "LblReadyToVote";
            LblReadyToVote.Size = new Size(485, 49);
            LblReadyToVote.TabIndex = 33;
            LblReadyToVote.Text = "READY TO VOTE?";
            LblReadyToVote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlViewElection
            // 
            PnlViewElection.BackColor = Color.Transparent;
            PnlViewElection.Controls.Add(pictureBox1);
            PnlViewElection.Controls.Add(LblOverview);
            PnlViewElection.Controls.Add(LblVotersManualDesc);
            PnlViewElection.Controls.Add(PicBoxViewElection);
            PnlViewElection.Location = new Point(413, 355);
            PnlViewElection.Margin = new Padding(3, 4, 3, 4);
            PnlViewElection.Name = "PnlViewElection";
            PnlViewElection.Size = new Size(300, 340);
            PnlViewElection.TabIndex = 31;
            PnlViewElection.Click += PnlOverview_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(155, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LblOverview
            // 
            LblOverview.Cursor = Cursors.Hand;
            LblOverview.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            LblOverview.Location = new Point(4, 165);
            LblOverview.Name = "LblOverview";
            LblOverview.Size = new Size(290, 41);
            LblOverview.TabIndex = 1;
            LblOverview.Text = "VOTER'S MANUAL";
            LblOverview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblVotersManualDesc
            // 
            LblVotersManualDesc.Cursor = Cursors.Hand;
            LblVotersManualDesc.Font = new Font("Arial", 12F, FontStyle.Italic);
            LblVotersManualDesc.Location = new Point(0, 215);
            LblVotersManualDesc.Name = "LblVotersManualDesc";
            LblVotersManualDesc.Size = new Size(300, 109);
            LblVotersManualDesc.TabIndex = 2;
            LblVotersManualDesc.Text = "A quick guide to help you vote safely and easily in HALAL 2025.";
            LblVotersManualDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // PicBoxViewElection
            // 
            PicBoxViewElection.BackgroundImage = Properties.Resources.elections;
            PicBoxViewElection.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxViewElection.Cursor = Cursors.Hand;
            PicBoxViewElection.Location = new Point(69, 12);
            PicBoxViewElection.Name = "PicBoxViewElection";
            PicBoxViewElection.Size = new Size(150, 150);
            PicBoxViewElection.TabIndex = 3;
            PicBoxViewElection.TabStop = false;
            PicBoxViewElection.Click += PicBoxOverview_Click;
            // 
            // LblGreetings
            // 
            LblGreetings.BackColor = Color.Transparent;
            LblGreetings.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            LblGreetings.ForeColor = Color.Black;
            LblGreetings.Location = new Point(400, 107);
            LblGreetings.Name = "LblGreetings";
            LblGreetings.Size = new Size(433, 46);
            LblGreetings.TabIndex = 27;
            LblGreetings.Text = "Good morning, User!";
            LblGreetings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PnlOverview
            // 
            PnlOverview.BackColor = Color.Transparent;
            PnlOverview.Controls.Add(LblViewElectionDesc);
            PnlOverview.Controls.Add(LblViewElection);
            PnlOverview.Controls.Add(PicBoxOverview);
            PnlOverview.Location = new Point(729, 355);
            PnlOverview.Margin = new Padding(3, 4, 3, 4);
            PnlOverview.Name = "PnlOverview";
            PnlOverview.Size = new Size(300, 340);
            PnlOverview.TabIndex = 30;
            PnlOverview.Click += PnlViewElection_Click;
            // 
            // LblViewElectionDesc
            // 
            LblViewElectionDesc.Cursor = Cursors.Hand;
            LblViewElectionDesc.Font = new Font("Arial", 12F, FontStyle.Italic);
            LblViewElectionDesc.Location = new Point(0, 215);
            LblViewElectionDesc.Name = "LblViewElectionDesc";
            LblViewElectionDesc.Size = new Size(300, 109);
            LblViewElectionDesc.TabIndex = 3;
            LblViewElectionDesc.Text = "View the general details of the election, such as the candidates, their positions, and their assigned partylists.\r\n";
            LblViewElectionDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LblViewElection
            // 
            LblViewElection.Cursor = Cursors.Hand;
            LblViewElection.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            LblViewElection.Location = new Point(23, 165);
            LblViewElection.Name = "LblViewElection";
            LblViewElection.Size = new Size(253, 41);
            LblViewElection.TabIndex = 2;
            LblViewElection.Text = "VIEW ELECTION";
            LblViewElection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PicBoxOverview
            // 
            PicBoxOverview.BackgroundImage = Properties.Resources.research;
            PicBoxOverview.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxOverview.Cursor = Cursors.Hand;
            PicBoxOverview.Location = new Point(74, 12);
            PicBoxOverview.Name = "PicBoxOverview";
            PicBoxOverview.Size = new Size(150, 150);
            PicBoxOverview.TabIndex = 0;
            PicBoxOverview.TabStop = false;
            PicBoxOverview.Click += PicBoxViewElection_Click;
            // 
            // Student_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.lightmode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            ControlBox = false;
            Controls.Add(PnlNavigation);
            Controls.Add(PnlMyVote);
            Controls.Add(LblTitle);
            Controls.Add(BtnVoteNow);
            Controls.Add(LblYLevel);
            Controls.Add(LblDescription);
            Controls.Add(LblReadyToVote);
            Controls.Add(PnlViewElection);
            Controls.Add(LblGreetings);
            Controls.Add(PnlOverview);
            Controls.Add(LblStatus);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Home";
            Load += Student_Home_Load;
            PnlNavigation.ResumeLayout(false);
            PnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogo).EndInit();
            PnlMyVote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxMyVote).EndInit();
            PnlViewElection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).EndInit();
            PnlOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBoxOverview).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label LblStatus;
        private FlowLayoutPanel flowLayoutPanel1;
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
        private Label LblCandidates;
        private Label LblSideViewElection;
        private Label LblSideVotersManual;
        private Label LblSideHome;
        private Label LblSideTitle;
        private PictureBox PicBoxLogo;
        private Panel PnlMyVote;
        private PictureBox pictureBox2;
        private Label LblMyVoteDesc;
        private Label LblMyVote;
        private PictureBox PicBoxMyVote;
        private Label LblTitle;
        private Button BtnVoteNow;
        private Label LblYLevel;
        private Label LblDescription;
        private Label LblReadyToVote;
        private Panel PnlViewElection;
        private PictureBox pictureBox1;
        private Label LblOverview;
        private Label LblVotersManualDesc;
        private PictureBox PicBoxViewElection;
        private Label LblGreetings;
        private Panel PnlOverview;
        private Label LblViewElectionDesc;
        private Label LblViewElection;
        private PictureBox PicBoxOverview;
    }
}