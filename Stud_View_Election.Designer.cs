namespace E_Voting_System
{
    partial class Stud_View_Election
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
            PicBoxCandidates = new PictureBox();
            PicBoxPositions = new PictureBox();
            PicBoxPartylists = new PictureBox();
            BtnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxCandidates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPartylists).BeginInit();
            SuspendLayout();
            // 
            // PicBoxCandidates
            // 
            PicBoxCandidates.BorderStyle = BorderStyle.FixedSingle;
            PicBoxCandidates.Location = new Point(194, 92);
            PicBoxCandidates.Name = "PicBoxCandidates";
            PicBoxCandidates.Size = new Size(67, 65);
            PicBoxCandidates.TabIndex = 0;
            PicBoxCandidates.TabStop = false;
            PicBoxCandidates.Click += PicBoxCandidates_Click;
            // 
            // PicBoxPositions
            // 
            PicBoxPositions.BorderStyle = BorderStyle.FixedSingle;
            PicBoxPositions.Location = new Point(329, 92);
            PicBoxPositions.Name = "PicBoxPositions";
            PicBoxPositions.Size = new Size(67, 65);
            PicBoxPositions.TabIndex = 1;
            PicBoxPositions.TabStop = false;
            PicBoxPositions.Click += PicBoxPositions_Click;
            // 
            // PicBoxPartylists
            // 
            PicBoxPartylists.BorderStyle = BorderStyle.FixedSingle;
            PicBoxPartylists.Location = new Point(464, 92);
            PicBoxPartylists.Name = "PicBoxPartylists";
            PicBoxPartylists.Size = new Size(67, 65);
            PicBoxPartylists.TabIndex = 2;
            PicBoxPartylists.TabStop = false;
            PicBoxPartylists.Click += PicBoxPartylists_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(682, 23);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "button1";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Stud_View_Election
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Controls.Add(PicBoxPartylists);
            Controls.Add(PicBoxPositions);
            Controls.Add(PicBoxCandidates);
            Name = "Stud_View_Election";
            Text = "Stud_View_Election";
            ((System.ComponentModel.ISupportInitialize)PicBoxCandidates).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxPartylists).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxCandidates;
        private PictureBox PicBoxPositions;
        private PictureBox PicBoxPartylists;
        private Button BtnBack;
    }
}