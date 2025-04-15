﻿namespace E_Voting_System
{
    partial class Login_Interface
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
            lblPassword = new Label();
            lblAdminID = new Label();
            btnLogin = new Button();
            btnGoBack = new Button();
            chkShowPass = new CheckBox();
            lblLogin = new Label();
            TxtPass = new TextBox();
            TxtUserID = new TextBox();
            PnlAdmin = new Panel();
            PicBoxClosed = new PictureBox();
            LblTitle1 = new Label();
            LblTitle2 = new Label();
            PnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxClosed).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(43, 189);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(158, 29);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "PASSWORD:";
            // 
            // lblAdminID
            // 
            lblAdminID.AutoSize = true;
            lblAdminID.BackColor = Color.Transparent;
            lblAdminID.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblAdminID.ForeColor = Color.White;
            lblAdminID.Location = new Point(43, 100);
            lblAdminID.Name = "lblAdminID";
            lblAdminID.Size = new Size(117, 29);
            lblAdminID.TabIndex = 14;
            lblAdminID.Text = "USER ID:";
            lblAdminID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaGreen;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(203, 299);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 41);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Maroon;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.White;
            btnGoBack.Location = new Point(37, 299);
            btnGoBack.Margin = new Padding(3, 4, 3, 4);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(158, 41);
            btnGoBack.TabIndex = 12;
            btnGoBack.Text = "EXIT";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkShowPass.ForeColor = Color.White;
            chkShowPass.Location = new Point(123, 265);
            chkShowPass.Margin = new Padding(3, 4, 3, 4);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(153, 23);
            chkShowPass.TabIndex = 11;
            chkShowPass.Text = "show password";
            chkShowPass.UseVisualStyleBackColor = false;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // lblLogin
            // 
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(80, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(249, 100);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "LOGIN";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPass
            // 
            TxtPass.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPass.Location = new Point(43, 221);
            TxtPass.Margin = new Padding(3, 4, 3, 4);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '*';
            TxtPass.Size = new Size(318, 30);
            TxtPass.TabIndex = 9;
            // 
            // TxtUserID
            // 
            TxtUserID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUserID.Location = new Point(43, 133);
            TxtUserID.Margin = new Padding(3, 4, 3, 4);
            TxtUserID.Name = "TxtUserID";
            TxtUserID.Size = new Size(318, 30);
            TxtUserID.TabIndex = 8;
            // 
            // PnlAdmin
            // 
            PnlAdmin.BackColor = Color.DarkGray;
            PnlAdmin.Controls.Add(lblLogin);
            PnlAdmin.Controls.Add(PicBoxClosed);
            PnlAdmin.Controls.Add(TxtPass);
            PnlAdmin.Controls.Add(chkShowPass);
            PnlAdmin.Controls.Add(TxtUserID);
            PnlAdmin.Controls.Add(lblPassword);
            PnlAdmin.Controls.Add(btnLogin);
            PnlAdmin.Controls.Add(lblAdminID);
            PnlAdmin.Controls.Add(btnGoBack);
            PnlAdmin.ForeColor = SystemColors.ControlText;
            PnlAdmin.Location = new Point(122, 140);
            PnlAdmin.Margin = new Padding(3, 4, 3, 4);
            PnlAdmin.Name = "PnlAdmin";
            PnlAdmin.Size = new Size(400, 349);
            PnlAdmin.TabIndex = 16;
            // 
            // PicBoxClosed
            // 
            PicBoxClosed.BackColor = SystemColors.Window;
            PicBoxClosed.BackgroundImage = Properties.Resources.eye;
            PicBoxClosed.BackgroundImageLayout = ImageLayout.Zoom;
            PicBoxClosed.Location = new Point(328, 223);
            PicBoxClosed.Name = "PicBoxClosed";
            PicBoxClosed.Size = new Size(27, 27);
            PicBoxClosed.TabIndex = 18;
            PicBoxClosed.TabStop = false;
            // 
            // LblTitle1
            // 
            LblTitle1.BackColor = Color.Transparent;
            LblTitle1.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle1.ForeColor = Color.Gold;
            LblTitle1.Location = new Point(122, 3);
            LblTitle1.Name = "LblTitle1";
            LblTitle1.Size = new Size(400, 96);
            LblTitle1.TabIndex = 17;
            LblTitle1.Text = "HELLO!";
            LblTitle1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTitle2
            // 
            LblTitle2.BackColor = Color.Transparent;
            LblTitle2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle2.ForeColor = Color.White;
            LblTitle2.Location = new Point(122, 99);
            LblTitle2.Name = "LblTitle2";
            LblTitle2.Size = new Size(400, 29);
            LblTitle2.TabIndex = 18;
            LblTitle2.Text = "WELCOME TO HALAL 2025!";
            LblTitle2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login_Interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(648, 543);
            Controls.Add(LblTitle2);
            Controls.Add(PnlAdmin);
            Controls.Add(LblTitle1);
            DoubleBuffered = true;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login_Interface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            KeyDown += Form3_KeyDown;
            PnlAdmin.ResumeLayout(false);
            PnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxClosed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPassword;
        private Label lblAdminID;
        private Button btnLogin;
        private Button btnGoBack;
        private CheckBox chkShowPass;
        private Label lblLogin;
        private TextBox TxtPass;
        private TextBox TxtUserID;
        private Panel PnlAdmin;
        private PictureBox PicBoxClosed;
        private Label LblTitle1;
        private Label LblTitle2;
    }
}