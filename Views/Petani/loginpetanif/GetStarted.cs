﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Petani
{
    public partial class GetStarted : Form
    {
        public GetStarted()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.DashboardPetani dashboardPetani = new Dashboard.DashboardPetani();
            dashboardPetani.ShowDialog();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
