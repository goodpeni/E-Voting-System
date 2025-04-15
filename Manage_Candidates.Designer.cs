namespace E_Voting_System
{
    partial class Manage_Candidates
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
            PicBoxAddCan = new PictureBox();
            PicBoxViewCan = new PictureBox();
            BtnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxAddCan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewCan).BeginInit();
            SuspendLayout();
            // 
            // PicBoxAddCan
            // 
            PicBoxAddCan.BorderStyle = BorderStyle.FixedSingle;
            PicBoxAddCan.Location = new Point(127, 75);
            PicBoxAddCan.Name = "PicBoxAddCan";
            PicBoxAddCan.Size = new Size(125, 62);
            PicBoxAddCan.TabIndex = 0;
            PicBoxAddCan.TabStop = false;
            PicBoxAddCan.Click += PicBoxAddCan_Click;
            // 
            // PicBoxViewCan
            // 
            PicBoxViewCan.BorderStyle = BorderStyle.FixedSingle;
            PicBoxViewCan.Location = new Point(320, 75);
            PicBoxViewCan.Name = "PicBoxViewCan";
            PicBoxViewCan.Size = new Size(125, 62);
            PicBoxViewCan.TabIndex = 1;
            PicBoxViewCan.TabStop = false;
            PicBoxViewCan.Click += PicBoxViewCan_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(658, 82);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "button1";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Manage_Candidates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Controls.Add(PicBoxViewCan);
            Controls.Add(PicBoxAddCan);
            Name = "Manage_Candidates";
            Text = "Manage_Candidates";
            ((System.ComponentModel.ISupportInitialize)PicBoxAddCan).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewCan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxAddCan;
        private PictureBox PicBoxViewCan;
        private Button BtnBack;
    }
}