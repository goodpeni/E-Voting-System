namespace E_Voting_System
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            btnVoteNow = new Button();
            btnCheckCandidates = new Button();
            lblStudentName = new Label();
            btnLogout = new Button();
            lblYearLevel = new Label();
            pnlVote = new Panel();
            lblVDesc = new Label();
            lblVote = new Label();
            pnlCandidates = new Panel();
            lblCDesc = new Label();
            lblCandidates = new Label();
            timerStudent = new System.Windows.Forms.Timer(components);
            lblSystem = new Label();
            pnlVote.SuspendLayout();
            pnlCandidates.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoteNow
            // 
            btnVoteNow.BackgroundImage = Properties.Resources.E_VOTING_SYSTEM_LOGO__10_;
            btnVoteNow.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoteNow.Cursor = Cursors.Hand;
            btnVoteNow.FlatAppearance.BorderColor = Color.Black;
            btnVoteNow.FlatAppearance.BorderSize = 0;
            btnVoteNow.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVoteNow.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVoteNow.FlatStyle = FlatStyle.Flat;
            btnVoteNow.Font = new Font("Arial Black", 15.75F, FontStyle.Bold);
            btnVoteNow.ForeColor = SystemColors.ControlText;
            btnVoteNow.Location = new Point(64, 12);
            btnVoteNow.Name = "btnVoteNow";
            btnVoteNow.Size = new Size(110, 110);
            btnVoteNow.TabIndex = 0;
            btnVoteNow.UseVisualStyleBackColor = true;
            btnVoteNow.Click += btnVoteNow_Click;
            // 
            // btnCheckCandidates
            // 
            btnCheckCandidates.BackgroundImage = Properties.Resources.E_VOTING_SYSTEM_LOGO__11_;
            btnCheckCandidates.BackgroundImageLayout = ImageLayout.Zoom;
            btnCheckCandidates.Cursor = Cursors.Hand;
            btnCheckCandidates.FlatAppearance.BorderColor = Color.Black;
            btnCheckCandidates.FlatAppearance.BorderSize = 0;
            btnCheckCandidates.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCheckCandidates.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCheckCandidates.FlatStyle = FlatStyle.Flat;
            btnCheckCandidates.Font = new Font("Arial Black", 15.75F, FontStyle.Bold);
            btnCheckCandidates.ForeColor = SystemColors.ControlText;
            btnCheckCandidates.Location = new Point(60, 12);
            btnCheckCandidates.Name = "btnCheckCandidates";
            btnCheckCandidates.Size = new Size(110, 110);
            btnCheckCandidates.TabIndex = 1;
            btnCheckCandidates.UseVisualStyleBackColor = true;
            btnCheckCandidates.Click += btnCheckCandidates_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblStudentName.ForeColor = Color.WhiteSmoke;
            lblStudentName.Location = new Point(12, 9);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(0, 19);
            lblStudentName.TabIndex = 2;
            lblStudentName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImage = Properties.Resources.E_VOTING_SYSTEM_LOGO__7_;
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(595, 8);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(35, 35);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblYearLevel
            // 
            lblYearLevel.AutoSize = true;
            lblYearLevel.BackColor = Color.Transparent;
            lblYearLevel.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblYearLevel.ForeColor = Color.WhiteSmoke;
            lblYearLevel.Location = new Point(12, 32);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(150, 19);
            lblYearLevel.TabIndex = 4;
            lblYearLevel.Text = "Grade 1 - Mahusay";
            lblYearLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlVote
            // 
            pnlVote.BackColor = Color.Transparent;
            pnlVote.BorderStyle = BorderStyle.FixedSingle;
            pnlVote.Controls.Add(btnVoteNow);
            pnlVote.Controls.Add(lblVDesc);
            pnlVote.Controls.Add(lblVote);
            pnlVote.Cursor = Cursors.Hand;
            pnlVote.Location = new Point(88, 133);
            pnlVote.Name = "pnlVote";
            pnlVote.Size = new Size(233, 281);
            pnlVote.TabIndex = 5;
            pnlVote.Click += pnlVote_Click;
            // 
            // lblVDesc
            // 
            lblVDesc.Cursor = Cursors.Hand;
            lblVDesc.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVDesc.ForeColor = Color.White;
            lblVDesc.Location = new Point(20, 154);
            lblVDesc.Name = "lblVDesc";
            lblVDesc.Size = new Size(195, 110);
            lblVDesc.TabIndex = 8;
            lblVDesc.Text = "A strong call-to-action that encourages students to join school elections—promoting awareness, participation, and unity in choosing their leaders.";
            lblVDesc.TextAlign = ContentAlignment.MiddleCenter;
            lblVDesc.Click += lblVDesc_Click;
            // 
            // lblVote
            // 
            lblVote.Cursor = Cursors.Hand;
            lblVote.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblVote.ForeColor = Color.White;
            lblVote.Location = new Point(68, 136);
            lblVote.Name = "lblVote";
            lblVote.Size = new Size(100, 19);
            lblVote.TabIndex = 7;
            lblVote.Text = "VOTE NOW";
            lblVote.TextAlign = ContentAlignment.MiddleCenter;
            lblVote.Click += lblVote_Click;
            // 
            // pnlCandidates
            // 
            pnlCandidates.BackColor = Color.Transparent;
            pnlCandidates.BorderStyle = BorderStyle.FixedSingle;
            pnlCandidates.Controls.Add(lblCDesc);
            pnlCandidates.Controls.Add(btnCheckCandidates);
            pnlCandidates.Controls.Add(lblCandidates);
            pnlCandidates.Cursor = Cursors.Hand;
            pnlCandidates.Location = new Point(337, 133);
            pnlCandidates.Name = "pnlCandidates";
            pnlCandidates.Size = new Size(233, 281);
            pnlCandidates.TabIndex = 6;
            pnlCandidates.Click += pnlCandidates_Click;
            // 
            // lblCDesc
            // 
            lblCDesc.Cursor = Cursors.Hand;
            lblCDesc.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCDesc.ForeColor = Color.White;
            lblCDesc.Location = new Point(19, 154);
            lblCDesc.Name = "lblCDesc";
            lblCDesc.Size = new Size(195, 110);
            lblCDesc.TabIndex = 9;
            lblCDesc.Text = "Encourages students to review and understand each candidate’s background and platform to make informed decisions during school elections.";
            lblCDesc.TextAlign = ContentAlignment.MiddleCenter;
            lblCDesc.Click += lblCDesc_Click;
            // 
            // lblCandidates
            // 
            lblCandidates.Cursor = Cursors.Hand;
            lblCandidates.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCandidates.ForeColor = Color.White;
            lblCandidates.Location = new Point(18, 136);
            lblCandidates.Name = "lblCandidates";
            lblCandidates.Size = new Size(197, 19);
            lblCandidates.TabIndex = 8;
            lblCandidates.Text = "CHECK CANDIDATES";
            lblCandidates.TextAlign = ContentAlignment.MiddleCenter;
            lblCandidates.Click += lblCandidates_Click;
            // 
            // lblSystem
            // 
            lblSystem.BackColor = Color.Transparent;
            lblSystem.Font = new Font("Impact", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystem.ForeColor = Color.White;
            lblSystem.Location = new Point(88, 51);
            lblSystem.Name = "lblSystem";
            lblSystem.Size = new Size(482, 79);
            lblSystem.TabIndex = 7;
            lblSystem.Text = "E-VOTING SYSTEM";
            lblSystem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(637, 426);
            ControlBox = false;
            Controls.Add(lblSystem);
            Controls.Add(pnlVote);
            Controls.Add(lblYearLevel);
            Controls.Add(btnLogout);
            Controls.Add(lblStudentName);
            Controls.Add(pnlCandidates);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Interface";
            Load += Form4_Load;
            pnlVote.ResumeLayout(false);
            pnlCandidates.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoteNow;
        private Button btnCheckCandidates;
        private Label lblStudentName;
        private Button btnLogout;
        private Label lblYearLevel;
        private Panel pnlVote;
        private Panel pnlCandidates;
        private Label lblVote;
        private Label lblCandidates;
        private System.Windows.Forms.Timer timerStudent;
        private Label lblVDesc;
        private Label lblCDesc;
        private Label lblSystem;
    }
}