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
    public partial class View_Student : Form
    {
        public View_Student()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Manage_Students formB5 = new Manage_Students();
            this.Hide();
            formB5.Show();
        }

        private void PicBoxStudProf1_Click(object sender, EventArgs e)
        {
            Student_Profile formB521 = new Student_Profile();
            this.Hide();
            formB521.Show();
        }

        private void PicBoxStudProf2_Click(object sender, EventArgs e)
        {
            Student_Profile formB521 = new Student_Profile();
            this.Hide();
            formB521.Show();
        }

        private void PicBoxStudProf3_Click(object sender, EventArgs e)
        {
            Student_Profile formB521 = new Student_Profile();
            this.Hide();
            formB521.Show();
        }
    }
}
