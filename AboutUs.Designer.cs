namespace E_Voting_System
{
    partial class AboutUs
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
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(713, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(75, 23);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "BACK";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Name = "AboutUs";
            Text = "AboutUs";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
    }
}