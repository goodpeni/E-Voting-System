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
    public partial class Stud_View_Election : Form
    {
        public Stud_View_Election()
        {
            InitializeComponent();
        }

        private void PicBoxCandidates_Click(object sender, EventArgs e)
        {
            Candidates formA51 = new Candidates();
            this.Hide();
            formA51.Show();
        }

        private void PicBoxPositions_Click(object sender, EventArgs e)
        {
            Positions formA52 = new Positions();
            this.Hide();
            formA52.Show();
        }

        private void PicBoxPartylists_Click(object sender, EventArgs e)
        {
            Partylists formA53 = new Partylists();
            this.Hide();
            formA53.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Student_Home formA1 = new Student_Home();
            this.Hide();
            formA1.Show();
        }
    }
}
