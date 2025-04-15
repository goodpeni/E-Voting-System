namespace E_Voting_System
{
    partial class View_Student
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
            BtnBack = new Button();
            PicBoxStudProf1 = new PictureBox();
            PicBoxStudProf2 = new PictureBox();
            PicBoxStudProf3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicBoxStudProf1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxStudProf2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxStudProf3).BeginInit();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(694, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "button1";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // PicBoxStudProf1
            // 
            PicBoxStudProf1.Location = new Point(143, 57);
            PicBoxStudProf1.Name = "PicBoxStudProf1";
            PicBoxStudProf1.Size = new Size(125, 62);
            PicBoxStudProf1.TabIndex = 1;
            PicBoxStudProf1.TabStop = false;
            PicBoxStudProf1.Click += PicBoxStudProf1_Click;
            // 
            // PicBoxStudProf2
            // 
            PicBoxStudProf2.Location = new Point(312, 57);
            PicBoxStudProf2.Name = "PicBoxStudProf2";
            PicBoxStudProf2.Size = new Size(125, 62);
            PicBoxStudProf2.TabIndex = 2;
            PicBoxStudProf2.TabStop = false;
            PicBoxStudProf2.Click += PicBoxStudProf2_Click;
            // 
            // PicBoxStudProf3
            // 
            PicBoxStudProf3.Location = new Point(478, 57);
            PicBoxStudProf3.Name = "PicBoxStudProf3";
            PicBoxStudProf3.Size = new Size(125, 62);
            PicBoxStudProf3.TabIndex = 3;
            PicBoxStudProf3.TabStop = false;
            PicBoxStudProf3.Click += PicBoxStudProf3_Click;
            // 
            // View_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PicBoxStudProf3);
            Controls.Add(PicBoxStudProf2);
            Controls.Add(PicBoxStudProf1);
            Controls.Add(BtnBack);
            Name = "View_Student";
            Text = "View_Student";
            ((System.ComponentModel.ISupportInitialize)PicBoxStudProf1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxStudProf2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxStudProf3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private PictureBox PicBoxStudProf1;
        private PictureBox PicBoxStudProf2;
        private PictureBox PicBoxStudProf3;
    }
}