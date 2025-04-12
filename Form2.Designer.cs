namespace E_Voting_System
{
    partial class Form2
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
            txtStudentID = new TextBox();
            txtStudentPass = new TextBox();
            lblLogin = new Label();
            chkShowPass = new CheckBox();
            btnGoBack = new Button();
            btnLogin = new Button();
            lblStudentID = new Label();
            lblPassword = new Label();
            pnlMAIN = new Panel();
            pnlMAIN.SuspendLayout();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = Color.Gainsboro;
            txtStudentID.Font = new Font("Arial", 13.8F);
            txtStudentID.Location = new Point(60, 52);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(272, 29);
            txtStudentID.TabIndex = 0;
            // 
            // txtStudentPass
            // 
            txtStudentPass.BackColor = Color.Gainsboro;
            txtStudentPass.Font = new Font("Arial", 13.8F);
            txtStudentPass.Location = new Point(60, 136);
            txtStudentPass.Name = "txtStudentPass";
            txtStudentPass.PasswordChar = '*';
            txtStudentPass.Size = new Size(272, 29);
            txtStudentPass.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(113, -5);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(226, 80);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "SIGN IN";
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkShowPass.Location = new Point(126, 172);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(122, 20);
            chkShowPass.TabIndex = 3;
            chkShowPass.Text = "show password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Maroon;
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.White;
            btnGoBack.Location = new Point(60, 204);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(134, 45);
            btnGoBack.TabIndex = 4;
            btnGoBack.Text = "Back";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(199, 204);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.BackColor = Color.Transparent;
            lblStudentID.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(60, 29);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(104, 22);
            lblStudentID.TabIndex = 6;
            lblStudentID.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(60, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(110, 22);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // pnlMAIN
            // 
            pnlMAIN.BackColor = Color.White;
            pnlMAIN.Controls.Add(lblStudentID);
            pnlMAIN.Controls.Add(btnLogin);
            pnlMAIN.Controls.Add(lblPassword);
            pnlMAIN.Controls.Add(btnGoBack);
            pnlMAIN.Controls.Add(txtStudentID);
            pnlMAIN.Controls.Add(chkShowPass);
            pnlMAIN.Controls.Add(txtStudentPass);
            pnlMAIN.Location = new Point(40, 70);
            pnlMAIN.Margin = new Padding(3, 2, 3, 2);
            pnlMAIN.Name = "pnlMAIN";
            pnlMAIN.Size = new Size(388, 283);
            pnlMAIN.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(468, 371);
            ControlBox = false;
            Controls.Add(pnlMAIN);
            Controls.Add(lblLogin);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            KeyDown += Form2_KeyDown;
            pnlMAIN.ResumeLayout(false);
            pnlMAIN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private TextBox txtStudentPass;
        private Label lblLogin;
        private CheckBox chkShowPass;
        private Button btnGoBack;
        private Button btnLogin;
        private Label lblStudentID;
        private Label lblPassword;
        private Panel pnlMAIN;
    }
}