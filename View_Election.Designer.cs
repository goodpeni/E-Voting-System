namespace E_Voting_System
{
    partial class View_Election
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
            PicBoxLeaderboards = new PictureBox();
            PicBoxAnalytics = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicBoxLeaderboards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxAnalytics).BeginInit();
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
            // PicBoxLeaderboards
            // 
            PicBoxLeaderboards.Location = new Point(110, 59);
            PicBoxLeaderboards.Name = "PicBoxLeaderboards";
            PicBoxLeaderboards.Size = new Size(125, 62);
            PicBoxLeaderboards.TabIndex = 1;
            PicBoxLeaderboards.TabStop = false;
            PicBoxLeaderboards.Click += PicBoxLeaderboards_Click;
            // 
            // PicBoxAnalytics
            // 
            PicBoxAnalytics.Location = new Point(296, 59);
            PicBoxAnalytics.Name = "PicBoxAnalytics";
            PicBoxAnalytics.Size = new Size(125, 62);
            PicBoxAnalytics.TabIndex = 2;
            PicBoxAnalytics.TabStop = false;
            PicBoxAnalytics.Click += PicBoxAnalytics_Click;
            // 
            // View_Election
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PicBoxAnalytics);
            Controls.Add(PicBoxLeaderboards);
            Controls.Add(BtnBack);
            Name = "View_Election";
            Text = "View_Election";
            ((System.ComponentModel.ISupportInitialize)PicBoxLeaderboards).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxAnalytics).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private PictureBox PicBoxLeaderboards;
        private PictureBox PicBoxAnalytics;
    }
}