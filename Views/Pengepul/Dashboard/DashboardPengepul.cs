﻿using System;
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
    public partial class DashboardPengepul : Form
    {
        public DashboardPengepul()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            pnlHarga.Show();
            pnlKapasitas.Show();
            pnlPenjemptan.Show();
            pnlBeranda.BackColor = Color.FromArgb(182, 137, 81);
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);
            pnlUpdateHarga.Hide();
            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);
            
        }

        private void DashboardPengepul_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            pnlUpdateHarga.Hide();
            lblTransaksi.Hide();
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = guna2TextBox1;
            pnlHarga.Hide();
            pnlKapasitas.Hide();
            pnlPenjemptan.Hide();
            pnlBeranda.BackColor = Color.FromArgb(255, 243, 233);
            pnlsideHarga.BackColor = Color.FromArgb(182, 137, 81);
            pnlUpdateHarga.Show();
            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);
            pnlTransaksi.Hide() ;
            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);
          
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBeranda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlsideHarga_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnlTransaksi.Show();
            pnlBeranda.BackColor = Color.FromArgb(255,243,233) ;
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideTransaksi.BackColor = Color.FromArgb(182, 137, 81);
            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);
            pnlRiwayat.Hide();

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            
            pnlUpdateHarga.Hide();
            pnlTransaksi.Hide();
            pnlHarga.Hide();
            pnlKapasitas.Hide();
            pnlPenjemptan.Hide();
            pnlBeranda.BackColor = Color.FromArgb(255, 243, 233);
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideRiwayat.BackColor = Color.FromArgb(182, 137, 81);
            Riwayat r = new Riwayat();
            r.Show();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTanggal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlPenjemptan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pnlKapasitas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlUpdateHarga_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
