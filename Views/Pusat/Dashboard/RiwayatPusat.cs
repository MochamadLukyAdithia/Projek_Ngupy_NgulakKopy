﻿using Ngupy_NgulakKopy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pusat.Dashboard
{
    public partial class RiwayatPusat : UserControl
    {
        PenjualanContext penjualanContext = new PenjualanContext();
        public RiwayatPusat()
        {
            InitializeComponent();
           
            
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RiwayatPusat_Load(object sender, EventArgs e)
        {
            penjualanContext.ReadPenjualan();
            dataGridView1.DataSource = penjualanContext.listPenjualan;
            //AlamatContext alamatContext = new AlamatContext();

            //guna2DataGridView1.DataSource = null;
            //guna2DataGridView1 .DataSource = alamatContext.listalamat;
        }
    }
}
