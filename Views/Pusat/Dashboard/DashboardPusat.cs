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
    public partial class DashboardPusat : Form
    {
        public DashboardPusat()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            berandaPusat1.Show();
            transaksiPusat1.Hide();
            updateHargaPusat1.Hide();
            riwayatPusat1.Hide();
            pnlBeranda.BackColor = Color.FromArgb(182, 137, 81);
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);

            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);
            BerandaPusat berandaPusat = new BerandaPusat();
            berandaPusat.DisplayLatestPrice();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pnlBeranda.BackColor = Color.FromArgb(255, 243, 233);
            pnlsideHarga.BackColor = Color.FromArgb(182, 137, 81);

            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);

            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);

            berandaPusat1.Hide();
            transaksiPusat1.Hide();
            updateHargaPusat1.Show();
            riwayatPusat1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            berandaPusat1.Hide();
            transaksiPusat1.Show();
            updateHargaPusat1.Hide();
            riwayatPusat1.Hide();
            pnlBeranda.BackColor = Color.FromArgb(255, 243, 233);
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideTransaksi.BackColor = Color.FromArgb(182, 137, 81);
            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {

            berandaPusat1.Hide();
            transaksiPusat1.Hide();
            updateHargaPusat1.Hide();
            riwayatPusat1.Show();
            pnlBeranda.BackColor = Color.FromArgb(255, 243, 233);
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideRiwayat.BackColor = Color.FromArgb(182, 137, 81);
        }

        private void DashboardPusat_Load(object sender, EventArgs e)
        {
            berandaPusat1.Show();
            transaksiPusat1.Hide();
            updateHargaPusat1.Hide();
            riwayatPusat1.Hide();
        }

        private void transaksiPusat1_Load(object sender, EventArgs e)
        {

        }
    }
}
