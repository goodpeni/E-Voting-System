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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            btnAddStudent.ForeColor = Color.White;
            btnAddCandidate.ForeColor = Color.White;
            btnStatistics.ForeColor = Color.White;

            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.BackColor = Color.Transparent;
            btnAddStudent.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddStudent.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnAddCandidate.FlatStyle = FlatStyle.Flat;
            btnAddCandidate.FlatAppearance.BorderSize = 0;
            btnAddCandidate.BackColor = Color.Transparent;
            btnAddCandidate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddCandidate.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.BackColor = Color.Transparent;
            btnStatistics.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStatistics.FlatAppearance.MouseDownBackColor = Color.Transparent;


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            this.Hide();
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
            this.Hide();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
            this.Hide();
        }

        private void picBOXStud_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            this.Hide();
        }

        private void picBOXCan_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
            this.Hide();
        }

        private void picBOXStats_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
            this.Hide();
        }

        private void lblStud_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            this.Hide();
        }

        private void lblCan_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
            this.Hide();
        }

        private void lblStats_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
            this.Hide();
        }
    }
}
