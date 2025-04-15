namespace E_Voting_System
{
    partial class Manage_Students
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
            PicBoxAddStud = new PictureBox();
            PicBoxViewStud = new PictureBox();
            BtnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxAddStud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewStud).BeginInit();
            SuspendLayout();
            // 
            // PicBoxAddStud
            // 
            PicBoxAddStud.Location = new Point(129, 35);
            PicBoxAddStud.Name = "PicBoxAddStud";
            PicBoxAddStud.Size = new Size(125, 62);
            PicBoxAddStud.TabIndex = 0;
            PicBoxAddStud.TabStop = false;
            PicBoxAddStud.Click += PicBoxAddStud_Click;
            // 
            // PicBoxViewStud
            // 
            PicBoxViewStud.Location = new Point(303, 35);
            PicBoxViewStud.Name = "PicBoxViewStud";
            PicBoxViewStud.Size = new Size(125, 62);
            PicBoxViewStud.TabIndex = 1;
            PicBoxViewStud.TabStop = false;
            PicBoxViewStud.Click += PicBoxViewStud_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(580, 45);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "button1";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Manage_Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Controls.Add(PicBoxViewStud);
            Controls.Add(PicBoxAddStud);
            Name = "Manage_Students";
            Text = "Manage_Students";
            ((System.ComponentModel.ISupportInitialize)PicBoxAddStud).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewStud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxAddStud;
        private PictureBox PicBoxViewStud;
        private Button BtnBack;
    }
}