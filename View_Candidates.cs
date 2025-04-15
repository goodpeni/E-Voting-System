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
    public partial class View_Candidates : Form
    {
        public View_Candidates()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Manage_Candidates formB4 = new Manage_Candidates();
            this.Hide();
            formB4.Show();
        }
    }
}
