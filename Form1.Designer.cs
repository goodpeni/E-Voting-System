namespace E_Voting_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStudent = new Button();
            btnAdmin = new Button();
            LblStudent = new Label();
            LblAdmin = new Label();
            label1 = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Transparent;
            btnStudent.BackgroundImage = Properties.Resources._31;
            btnStudent.BackgroundImageLayout = ImageLayout.Stretch;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnStudent.Location = new Point(177, 162);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(203, 203);
            btnStudent.TabIndex = 0;
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.BackgroundImage = Properties.Resources._41;
            btnAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnAdmin.Location = new Point(412, 162);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(203, 203);
            btnAdmin.TabIndex = 1;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // LblStudent
            // 
            LblStudent.AutoSize = true;
            LblStudent.BackColor = Color.Transparent;
            LblStudent.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStudent.ForeColor = Color.White;
            LblStudent.Location = new Point(173, 384);
            LblStudent.Name = "LblStudent";
            LblStudent.Size = new Size(207, 50);
            LblStudent.TabIndex = 2;
            LblStudent.Text = "STUDENT";
            LblStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblAdmin
            // 
            LblAdmin.AutoSize = true;
            LblAdmin.BackColor = Color.Transparent;
            LblAdmin.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAdmin.ForeColor = Color.White;
            LblAdmin.Location = new Point(437, 384);
            LblAdmin.Name = "LblAdmin";
            LblAdmin.Size = new Size(152, 50);
            LblAdmin.TabIndex = 3;
            LblAdmin.Text = "ADMIN";
            LblAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 48);
            label1.Name = "label1";
            label1.Size = new Size(606, 98);
            label1.TabIndex = 4;
            label1.Text = "E-VOTING SYSTEM";
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Tick += Timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = Properties.Resources.Untitled_design__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(803, 490);
            Controls.Add(label1);
            Controls.Add(LblAdmin);
            Controls.Add(LblStudent);
            Controls.Add(btnAdmin);
            Controls.Add(btnStudent);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Interface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudent;
        private Button btnAdmin;
        private Label LblStudent;
        private Label LblAdmin;
        private Label label1;
        private System.Windows.Forms.Timer Timer;
    }
}
