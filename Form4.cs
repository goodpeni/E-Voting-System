using E_Voting_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_System
{
    public partial class Form4 : Form
    {

        private int maxSizeIncrease = 10;
        private int step = 2;

        private Size originalSizeV, originalSizeC, originalSizeL;
        private Point originalLocationV, originalLocationC, originalLocationL;

        private Button activeButton = null;

        public Form4()
        {
            InitializeComponent();

            btnVoteNow.Left = (pnlVote.Width - btnVoteNow.Width) / 2;
            btnCheckCandidates.Left = (pnlCandidates.Width - btnCheckCandidates.Width) / 2;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            activeButton = sender as Button;
            timerStudent.Start();
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            activeButton = sender as Button;
            timerStudent.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void btnVoteNow_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }

        private void btnCheckCandidates_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string greeting = "";

            int hour = DateTime.Now.Hour;

            if (hour >= 5 && hour < 12)
                greeting = "Good morning";
            else if (hour >= 12 && hour < 18)
                greeting = "Good afternoon";
            else
                greeting = "Good evening";

            lblStudentName.Text = $"{greeting}, Anfernee!";
        }

        private void lblVote_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }

        private void lblVDesc_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }

        private void pnlVote_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }

        private void lblCandidates_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            this.Hide();
        }

        private void lblCDesc_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            this.Hide();
        }

        private void pnlCandidates_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
            this.Hide();
        }
    }
}
