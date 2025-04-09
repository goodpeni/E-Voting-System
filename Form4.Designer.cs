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
            btnVoteNow = new Button();
            btnCheckCandidates = new Button();
            lblStudentName = new Label();
            btnLogout = new Button();
            lblYearLevel = new Label();
            SuspendLayout();
            // 
            // btnVoteNow
            // 
            btnVoteNow.Font = new Font("Arial Black", 15.75F, FontStyle.Bold);
            btnVoteNow.ForeColor = SystemColors.ControlText;
            btnVoteNow.Location = new Point(264, 114);
            btnVoteNow.Name = "btnVoteNow";
            btnVoteNow.Size = new Size(235, 66);
            btnVoteNow.TabIndex = 0;
            btnVoteNow.Text = "Vote Now";
            btnVoteNow.UseVisualStyleBackColor = true;
            btnVoteNow.Click += btnVoteNow_Click;
            // 
            // btnCheckCandidates
            // 
            btnCheckCandidates.Font = new Font("Arial Black", 15.75F, FontStyle.Bold);
            btnCheckCandidates.ForeColor = SystemColors.ControlText;
            btnCheckCandidates.Location = new Point(264, 201);
            btnCheckCandidates.Name = "btnCheckCandidates";
            btnCheckCandidates.Size = new Size(235, 66);
            btnCheckCandidates.TabIndex = 1;
            btnCheckCandidates.Text = "Check Candidates";
            btnCheckCandidates.UseVisualStyleBackColor = true;
            btnCheckCandidates.Click += btnCheckCandidates_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblStudentName.ForeColor = SystemColors.ControlText;
            lblStudentName.Location = new Point(12, 9);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(127, 19);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Student Name: ";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(702, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(40, 40);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblYearLevel
            // 
            lblYearLevel.AutoSize = true;
            lblYearLevel.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblYearLevel.ForeColor = SystemColors.ControlText;
            lblYearLevel.Location = new Point(12, 42);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(97, 19);
            lblYearLevel.TabIndex = 4;
            lblYearLevel.Text = "Year Level: ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(749, 371);
            Controls.Add(lblYearLevel);
            Controls.Add(btnLogout);
            Controls.Add(lblStudentName);
            Controls.Add(btnCheckCandidates);
            Controls.Add(btnVoteNow);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Interface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoteNow;
        private Button btnCheckCandidates;
        private Label lblStudentName;
        private Button btnLogout;
        private Label lblYearLevel;
    }
}