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
    public partial class Manage_Partylists : Form
    {
        public Manage_Partylists()
        {
            InitializeComponent();
        }

        private void PicBoxAddPart_Click(object sender, EventArgs e)
        {
            Add_Partylist formB61 = new Add_Partylist();
            this.Hide();
            formB61.Show();
        }

        private void PicBoxViewPart_Click(object sender, EventArgs e)
        {
            View_Partylists formB62 = new View_Partylists();
            this.Hide();
            formB62.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Admin_Home formB1 = new Admin_Home();
            this.Hide();
            formB1.Show();
        }
    }
}
