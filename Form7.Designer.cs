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
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            btnAddCandidate.Location = new Point(45, 21);
            btnAddCandidate.Name = "btnAddCandidate";
            btnAddCandidate.Size = new Size(109, 50);
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
            btnAddStudent.Location = new Point(42, 21);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(109, 50);
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
            btnStatistics.Location = new Point(46, 21);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(109, 50);
            btnStatistics.TabIndex = 8;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnAddStudent);
            panel1.Location = new Point(26, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 243);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnAddCandidate);
            panel2.Location = new Point(251, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 243);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnStatistics);
            panel3.Location = new Point(475, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 243);
            panel3.TabIndex = 11;
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
            Text = "Admin Interface";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
    }
}