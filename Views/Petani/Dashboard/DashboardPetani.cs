using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ngupy_NgulakKopy.Views.Petani.Dashboard.PengaturanProfilPetani;
using Ngupy_NgulakKopy.Views.Petani.ProfilPetani;


namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class DashboardPetani : Form
    {
        public DashboardPetani()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            berandaPetani1.Show();
            penjemputanPetani1.Hide();
            transaksiPetani1.Hide();
            riwayatPetani1.Hide();
            pnlBeranda.BackColor = Color.FromArgb(182, 137, 81);
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);

            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            berandaPetani1.Hide();
            penjemputanPetani1.Show();
            transaksiPetani1.Hide();
            riwayatPetani1.Hide();
            pnlBeranda.BackColor = Color.FromArgb(255, 243, 233);
            pnlsideHarga.BackColor = Color.FromArgb(182, 137, 81);

            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);

            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            berandaPetani1.Hide();
            penjemputanPetani1.Hide();
            transaksiPetani1.Show();
            riwayatPetani1.Hide();
            pnlBeranda.BackColor = Color.FromArgb(255, 243, 233);
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideTransaksi.BackColor = Color.FromArgb(182, 137, 81);
            pnlSideRiwayat.BackColor = Color.FromArgb(255, 243, 233);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            berandaPetani1.Hide();
            penjemputanPetani1.Hide();
            transaksiPetani1.Hide();
            riwayatPetani1.Show();
            pnlBeranda.BackColor = Color.FromArgb(255, 243, 233);
            pnlsideHarga.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideTransaksi.BackColor = Color.FromArgb(255, 243, 233);
            pnlSideRiwayat.BackColor = Color.FromArgb(182, 137, 81);
        }

        private void DashboardPetani_Load(object sender, EventArgs e)
        {
            berandaPetani1.Show();
            penjemputanPetani1.Hide();
            transaksiPetani1.Hide();
            riwayatPetani1.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            PengaturanPetani profil = new PengaturanPetani();
            profil.Show();
            this.Hide();
        }

        private void riwayatPetani1_Load(object sender, EventArgs e)
        {

        }

        private void berandaPetani1_Load(object sender, EventArgs e)
        {

        }

        private void transaksiPetani1_Load(object sender, EventArgs e)
        {

        }
    }
}
