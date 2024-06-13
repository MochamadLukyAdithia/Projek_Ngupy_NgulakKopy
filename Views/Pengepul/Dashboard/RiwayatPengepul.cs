using Ngupy_NgulakKopy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    public partial class RiwayatPengepul : UserControl
    {
        PenjualanContext penjualanContext = new PenjualanContext();
        PembelianContext pembelianContext = new PembelianContext();
        public RiwayatPengepul()
        {
            InitializeComponent();
          

            PembelianDataGridView1.EnableHeadersVisualStyles = false;
            PembelianDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            PembelianDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PembelianDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PembelianDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PembelianDataGridView1.ColumnHeadersHeight = 30;
            PembelianDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PembelianDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            PembelianDataGridView1.RowHeadersWidth = 30;

           
           

            PenjualanDataGridView1.EnableHeadersVisualStyles = false;
            PenjualanDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            PenjualanDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PenjualanDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PenjualanDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PenjualanDataGridView1.ColumnHeadersHeight = 30;
            PenjualanDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PenjualanDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            PenjualanDataGridView1.RowHeadersWidth = 30;



        }

        public void DisplayRiwayat()
        {
            PembelianDataGridView1.BringToFront();
            pembelianContext.ReadPembelian();
            PembelianDataGridView1.DataSource = pembelianContext.ReadPembelian();
            penjualanContext.ReadPenjualan();
            PenjualanDataGridView1.DataSource = penjualanContext.listPenjualan;


        }
        private void RiwayatPengepul_Load(object sender, EventArgs e)
        {
            

           
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PembelianButton_Click(object sender, EventArgs e)
        {
            PembelianButton.BringToFront();
            PembelianButton.FillColor = Color.FromArgb(255, 218, 154);
            PenjualanButton.FillColor = Color.FromArgb(255,255,255);
            PembelianDataGridView1.BringToFront();
          
        }

        private void PenjualanButton_Click(object sender, EventArgs e)
        {
            PenjualanButton.BringToFront();
            PembelianButton.FillColor = Color.FromArgb(255, 255, 255);
            PenjualanButton.FillColor = Color.FromArgb(255, 218, 154);
            PenjualanDataGridView1.BringToFront();

        }

        private void pnlPenjemptan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PenjualanDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
