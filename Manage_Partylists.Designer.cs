namespace E_Voting_System
{
    partial class Manage_Partylists
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
            PicBoxAddPart = new PictureBox();
            PicBoxViewPart = new PictureBox();
            BtnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxAddPart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewPart).BeginInit();
            SuspendLayout();
            // 
            // PicBoxAddPart
            // 
            PicBoxAddPart.BorderStyle = BorderStyle.FixedSingle;
            PicBoxAddPart.Location = new Point(152, 78);
            PicBoxAddPart.Name = "PicBoxAddPart";
            PicBoxAddPart.Size = new Size(125, 62);
            PicBoxAddPart.TabIndex = 0;
            PicBoxAddPart.TabStop = false;
            PicBoxAddPart.Click += PicBoxAddPart_Click;
            // 
            // PicBoxViewPart
            // 
            PicBoxViewPart.BorderStyle = BorderStyle.FixedSingle;
            PicBoxViewPart.Location = new Point(315, 78);
            PicBoxViewPart.Name = "PicBoxViewPart";
            PicBoxViewPart.Size = new Size(125, 62);
            PicBoxViewPart.TabIndex = 1;
            PicBoxViewPart.TabStop = false;
            PicBoxViewPart.Click += PicBoxViewPart_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(694, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "button1";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Manage_Partylists
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Controls.Add(PicBoxViewPart);
            Controls.Add(PicBoxAddPart);
            Name = "Manage_Partylists";
            Text = "Manage_Partylist";
            ((System.ComponentModel.ISupportInitialize)PicBoxAddPart).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxViewPart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxAddPart;
        private PictureBox PicBoxViewPart;
        private Button BtnBack;
    }
}