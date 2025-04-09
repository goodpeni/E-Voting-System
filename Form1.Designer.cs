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
            Timer = new System.Windows.Forms.Timer(components);
            btnAdmin = new Button();
            btnStudent = new Button();
            LblTitle = new Label();
            LblStudent = new Label();
            LblAdmin = new Label();
            PnlMenu = new Panel();
            PnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Tick += Timer_Tick;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.BackgroundImage = Properties.Resources._41;
            btnAdmin.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnAdmin.Location = new Point(325, 142);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(203, 203);
            btnAdmin.TabIndex = 1;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Transparent;
            btnStudent.BackgroundImage = Properties.Resources._31;
            btnStudent.BackgroundImageLayout = ImageLayout.Zoom;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStudent.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnStudent.Location = new Point(89, 142);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(203, 203);
            btnStudent.TabIndex = 0;
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.BackColor = Color.Transparent;
            LblTitle.Font = new Font("Impact", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.White;
            LblTitle.Location = new Point(11, 23);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(606, 98);
            LblTitle.TabIndex = 4;
            LblTitle.Text = "E-VOTING SYSTEM";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblStudent
            // 
            LblStudent.AutoSize = true;
            LblStudent.BackColor = Color.Transparent;
            LblStudent.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStudent.ForeColor = Color.White;
            LblStudent.Location = new Point(87, 363);
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
            LblAdmin.Location = new Point(351, 363);
            LblAdmin.Name = "LblAdmin";
            LblAdmin.Size = new Size(152, 50);
            LblAdmin.TabIndex = 3;
            LblAdmin.Text = "ADMIN";
            LblAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlMenu
            // 
            PnlMenu.BackColor = Color.Transparent;
            PnlMenu.Controls.Add(LblAdmin);
            PnlMenu.Controls.Add(LblStudent);
            PnlMenu.Controls.Add(LblTitle);
            PnlMenu.Controls.Add(btnStudent);
            PnlMenu.Controls.Add(btnAdmin);
            PnlMenu.Location = new Point(110, 31);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(620, 428);
            PnlMenu.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = Properties.Resources.Untitled_design__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(803, 490);
            Controls.Add(PnlMenu);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Interface";
            Load += Form1_Load;
            Resize += Form1_Resize;
            PnlMenu.ResumeLayout(false);
            PnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private Button btnAdmin;
        private Button btnStudent;
        private Label LblTitle;
        private Label LblStudent;
        private Label LblAdmin;
        private Panel PnlMenu;
    }
}
