﻿using Ngupy_NgulakKopy.Views.Petani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pusat
{
    public partial class MasukPusat : Form
    {
        public MasukPusat()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
     
      

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginPetani_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaftarPusat dp = new DaftarPusat();
            dp.ShowDialog();
        }
    }
}
