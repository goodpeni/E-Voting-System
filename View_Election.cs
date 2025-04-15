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
    public partial class View_Election : Form
    {
        public View_Election()
        {
            InitializeComponent();
        }

        private void PicBoxLeaderboards_Click(object sender, EventArgs e)
        {
            Leaderboards formB31 = new Leaderboards();
            this.Hide();
            formB31.Show();
        }

        private void PicBoxAnalytics_Click(object sender, EventArgs e)
        {
            Analytics formB32 = new Analytics();
            this.Hide();
            formB32.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            View_Election formB3 = new View_Election();
            this.Hide();
            formB3.Show();
        }
    }
}
