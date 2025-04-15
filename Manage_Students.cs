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
    public partial class Manage_Students : Form
    {
        public Manage_Students()
        {
            InitializeComponent();
        }

        private void PicBoxAddStud_Click(object sender, EventArgs e)
        {
            Add_Student formB5 = new Add_Student();
            this.Hide();
            formB5.Show();
        }

        private void PicBoxViewStud_Click(object sender, EventArgs e)
        {
            View_Student formB5 = new View_Student();
            this.Hide();
            formB5.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Admin_Home formB1 = new Admin_Home();
            this.Hide();
            formB1.Show();
        }
    }
}
