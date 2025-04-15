namespace E_Voting_System
{
    partial class Student_Home
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
            PicBoxOverview = new PictureBox();
            PicBoxProfile = new PictureBox();
            PicBoxVoteNow = new PictureBox();
            PicBoxViewElection = new PictureBox();
            PicBoxMyVote = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicBoxOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxVoteNow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxMyVote).BeginInit();
            SuspendLayout();
            // 
            // PicBoxOverview
            // 
            PicBoxOverview.Location = new Point(28, 27);
            PicBoxOverview.Name = "PicBoxOverview";
            PicBoxOverview.Size = new Size(125, 62);
            PicBoxOverview.TabIndex = 0;
            PicBoxOverview.TabStop = false;
            PicBoxOverview.Click += PicBoxOverview_Click;
            // 
            // PicBoxProfile
            // 
            PicBoxProfile.Location = new Point(193, 27);
            PicBoxProfile.Name = "PicBoxProfile";
            PicBoxProfile.Size = new Size(125, 62);
            PicBoxProfile.TabIndex = 1;
            PicBoxProfile.TabStop = false;
            PicBoxProfile.Click += PicBoxProfile_Click;
            // 
            // PicBoxVoteNow
            // 
            PicBoxVoteNow.Location = new Point(356, 27);
            PicBoxVoteNow.Name = "PicBoxVoteNow";
            PicBoxVoteNow.Size = new Size(125, 62);
            PicBoxVoteNow.TabIndex = 2;
            PicBoxVoteNow.TabStop = false;
            PicBoxVoteNow.Click += PicBoxVoteNow_Click;
            // 
            // PicBoxViewElection
            // 
            PicBoxViewElection.Location = new Point(110, 126);
            PicBoxViewElection.Name = "PicBoxViewElection";
            PicBoxViewElection.Size = new Size(125, 62);
            PicBoxViewElection.TabIndex = 3;
            PicBoxViewElection.TabStop = false;
            PicBoxViewElection.Click += PicBoxViewElection_Click;
            // 
            // PicBoxMyVote
            // 
            PicBoxMyVote.Location = new Point(274, 126);
            PicBoxMyVote.Name = "PicBoxMyVote";
            PicBoxMyVote.Size = new Size(125, 62);
            PicBoxMyVote.TabIndex = 4;
            PicBoxMyVote.TabStop = false;
            PicBoxMyVote.Click += PicBoxMyVote_Click;
            // 
            // Student_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PicBoxMyVote);
            Controls.Add(PicBoxViewElection);
            Controls.Add(PicBoxVoteNow);
            Controls.Add(PicBoxProfile);
            Controls.Add(PicBoxOverview);
            Name = "Student_Home";
            Text = "Student_Home";
            ((System.ComponentModel.ISupportInitialize)PicBoxOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxVoteNow).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewElection).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxMyVote).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxOverview;
        private PictureBox PicBoxProfile;
        private PictureBox PicBoxVoteNow;
        private PictureBox PicBoxViewElection;
        private PictureBox PicBoxMyVote;
    }
}