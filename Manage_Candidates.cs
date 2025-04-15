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
    public partial class Manage_Candidates : Form
    {
        public Manage_Candidates()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Admin_Home formB1 = new Admin_Home();
            this.Hide();
            formB1.Show();
        }

        private void PicBoxAddCan_Click(object sender, EventArgs e)
        {
            Add_Candidate formB41 = new Add_Candidate();
            this.Hide();
            formB41.Show();
        }

        private void PicBoxViewCan_Click(object sender, EventArgs e)
        {
            View_Candidates formB42 = new View_Candidates();
            this.Hide();
            formB42.Show();
        }
    }
}
