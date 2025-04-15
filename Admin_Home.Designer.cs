namespace E_Voting_System
{
    partial class Admin_Home
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
            PicBoxDashboard = new PictureBox();
            PicBoxViewElection = new PictureBox();
            PicBoxManCand = new PictureBox();
            PicBoxManStud = new PictureBox();
            PicBoxManParty = new PictureBox();
            BtnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxManCand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxManStud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxManParty).BeginInit();
            SuspendLayout();
            // 
            // PicBoxDashboard
            // 
            PicBoxDashboard.BorderStyle = BorderStyle.FixedSingle;
            PicBoxDashboard.Location = new Point(59, 32);
            PicBoxDashboard.Name = "PicBoxDashboard";
            PicBoxDashboard.Size = new Size(73, 68);
            PicBoxDashboard.TabIndex = 0;
            PicBoxDashboard.TabStop = false;
            PicBoxDashboard.Click += PicBoxDashboard_Click;
            // 
            // PicBoxViewElection
            // 
            PicBoxViewElection.BorderStyle = BorderStyle.FixedSingle;
            PicBoxViewElection.Location = new Point(178, 32);
            PicBoxViewElection.Name = "PicBoxViewElection";
            PicBoxViewElection.Size = new Size(73, 68);
            PicBoxViewElection.TabIndex = 1;
            PicBoxViewElection.TabStop = false;
            PicBoxViewElection.Click += PicBoxViewElection_Click;
            // 
            // PicBoxManCand
            // 
            PicBoxManCand.BorderStyle = BorderStyle.FixedSingle;
            PicBoxManCand.Location = new Point(298, 32);
            PicBoxManCand.Name = "PicBoxManCand";
            PicBoxManCand.Size = new Size(73, 68);
            PicBoxManCand.TabIndex = 2;
            PicBoxManCand.TabStop = false;
            PicBoxManCand.Click += PicBoxManCand_Click;
            // 
            // PicBoxManStud
            // 
            PicBoxManStud.BorderStyle = BorderStyle.FixedSingle;
            PicBoxManStud.Location = new Point(413, 32);
            PicBoxManStud.Name = "PicBoxManStud";
            PicBoxManStud.Size = new Size(73, 68);
            PicBoxManStud.TabIndex = 3;
            PicBoxManStud.TabStop = false;
            PicBoxManStud.Click += PicBoxManStud_Click_1;
            // 
            // PicBoxManParty
            // 
            PicBoxManParty.BorderStyle = BorderStyle.FixedSingle;
            PicBoxManParty.Location = new Point(522, 32);
            PicBoxManParty.Name = "PicBoxManParty";
            PicBoxManParty.Size = new Size(73, 68);
            PicBoxManParty.TabIndex = 4;
            PicBoxManParty.TabStop = false;
            PicBoxManParty.Click += PicBoxManParty_Click;
            // 
            // BtnLogout
            // 
            BtnLogout.Location = new Point(688, 55);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(73, 33);
            BtnLogout.TabIndex = 5;
            BtnLogout.Text = "button1";
            BtnLogout.UseVisualStyleBackColor = true;
            // 
            // Admin_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLogout);
            Controls.Add(PicBoxManParty);
            Controls.Add(PicBoxManStud);
            Controls.Add(PicBoxManCand);
            Controls.Add(PicBoxViewElection);
            Controls.Add(PicBoxDashboard);
            Name = "Admin_Home";
            Text = "Admin_Home";
            ((System.ComponentModel.ISupportInitialize)PicBoxDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxManCand).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxManStud).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxManParty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxDashboard;
        private PictureBox PicBoxViewElection;
        private PictureBox PicBoxManCand;
        private PictureBox PicBoxManStud;
        private PictureBox PicBoxManParty;
        private Button BtnLogout;
    }
}