﻿using System;
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
    public partial class Add_Partylist : Form
    {
        public Add_Partylist()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Manage_Partylists formB6 = new Manage_Partylists();
            this.Hide();
            formB6.Show();
        }
    }
}
