namespace E_Voting_System
{
    partial class Form7
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
            btnLogout = new Button();
            lblAdminName = new Label();
            btnAddCandidate = new Button();
            btnAddStudent = new Button();
            btnStatistics = new Button();
            panel1 = new Panel();
            lblStud = new Label();
            picBOXStud = new PictureBox();
            panel2 = new Panel();
            lblCan = new Label();
            picBOXCan = new PictureBox();
            panel3 = new Panel();
            picBOXStats = new PictureBox();
            lblStats = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBOXStud).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBOXCan).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBOXStats).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(600, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(99, 34);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminName.Location = new Point(12, 9);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(109, 21);
            lblAdminName.TabIndex = 6;
            lblAdminName.Text = "Admin Name: ";
            // 
            // btnAddCandidate
            // 
            btnAddCandidate.BackColor = Color.Transparent;
            btnAddCandidate.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnAddCandidate.ForeColor = Color.Black;
            btnAddCandidate.Location = new Point(44, 164);
            btnAddCandidate.Name = "btnAddCandidate";
            btnAddCandidate.Size = new Size(109, 28);
            btnAddCandidate.TabIndex = 5;
            btnAddCandidate.Text = "Add Candidate";
            btnAddCandidate.UseVisualStyleBackColor = false;
            btnAddCandidate.Click += btnAddCandidate_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.Transparent;
            btnAddStudent.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnAddStudent.ForeColor = Color.Black;
            btnAddStudent.Location = new Point(45, 164);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(109, 28);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.Transparent;
            btnStatistics.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            btnStatistics.ForeColor = Color.Black;
            btnStatistics.Location = new Point(47, 164);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(109, 28);
            btnStatistics.TabIndex = 8;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblStud);
            panel1.Controls.Add(btnAddStudent);
            panel1.Controls.Add(picBOXStud);
            panel1.Location = new Point(26, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 281);
            panel1.TabIndex = 9;
            // 
            // lblStud
            // 
            lblStud.AutoSize = true;
            lblStud.ForeColor = Color.White;
            lblStud.Location = new Point(21, 195);
            lblStud.Name = "lblStud";
            lblStud.Size = new Size(162, 15);
            lblStud.TabIndex = 5;
            lblStud.Text = "Add a student eligible to vote";
            lblStud.TextAlign = ContentAlignment.MiddleCenter;
            lblStud.Click += lblStud_Click;
            // 
            // picBOXStud
            // 
            picBOXStud.BackColor = Color.Transparent;
            picBOXStud.BackgroundImage = Properties.Resources.E_VOTING_SYSTEM_LOGO_20250413_115438_00011;
            picBOXStud.BackgroundImageLayout = ImageLayout.Zoom;
            picBOXStud.Location = new Point(36, 11);
            picBOXStud.Name = "picBOXStud";
            picBOXStud.Size = new Size(129, 147);
            picBOXStud.TabIndex = 12;
            picBOXStud.TabStop = false;
            picBOXStud.Click += picBOXStud_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblCan);
            panel2.Controls.Add(btnAddCandidate);
            panel2.Controls.Add(picBOXCan);
            panel2.Location = new Point(251, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 281);
            panel2.TabIndex = 10;
            // 
            // lblCan
            // 
            lblCan.AutoSize = true;
            lblCan.ForeColor = Color.White;
            lblCan.Location = new Point(22, 195);
            lblCan.Name = "lblCan";
            lblCan.Size = new Size(145, 30);
            lblCan.TabIndex = 6;
            lblCan.Text = "Register a new \r\ncandidate for the election.\r\n";
            lblCan.TextAlign = ContentAlignment.MiddleCenter;
            lblCan.Click += lblCan_Click;
            // 
            // picBOXCan
            // 
            picBOXCan.BackColor = Color.Transparent;
            picBOXCan.BackgroundImage = Properties.Resources.E_VOTING_SYSTEM_LOGO_20250413_115438_0000;
            picBOXCan.BackgroundImageLayout = ImageLayout.Zoom;
            picBOXCan.Location = new Point(34, 11);
            picBOXCan.Name = "picBOXCan";
            picBOXCan.Size = new Size(133, 158);
            picBOXCan.TabIndex = 13;
            picBOXCan.TabStop = false;
            picBOXCan.Click += picBOXCan_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(picBOXStats);
            panel3.Controls.Add(lblStats);
            panel3.Controls.Add(btnStatistics);
            panel3.Location = new Point(475, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 281);
            panel3.TabIndex = 11;
            // 
            // picBOXStats
            // 
            picBOXStats.BackColor = Color.Transparent;
            picBOXStats.BackgroundImage = Properties.Resources.E_VOTING_SYSTEM_LOGO_20250413_115438_0002;
            picBOXStats.BackgroundImageLayout = ImageLayout.Zoom;
            picBOXStats.Location = new Point(32, 11);
            picBOXStats.Name = "picBOXStats";
            picBOXStats.Size = new Size(140, 147);
            picBOXStats.TabIndex = 14;
            picBOXStats.TabStop = false;
            picBOXStats.Click += picBOXStats_Click;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.ForeColor = Color.White;
            lblStats.Location = new Point(22, 195);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(150, 75);
            lblStats.TabIndex = 7;
            lblStats.Text = "View current rankings \r\nand vote statistics for each \r\ncandidate.\r\n\r\n ";
            lblStats.TextAlign = ContentAlignment.MiddleCenter;
            lblStats.Click += lblStats_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(711, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblAdminName);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            DoubleBuffered = true;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBOXStud).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBOXCan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBOXStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Label lblAdminName;
        private Button btnAddCandidate;
        private Button btnAddStudent;
        private Button btnStatistics;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblStud;
        private Label lblCan;
        private Label lblStats;
        private PictureBox picBOXStud;
        private PictureBox picBOXCan;
        private PictureBox picBOXStats;
    }
}