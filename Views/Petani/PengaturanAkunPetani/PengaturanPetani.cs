using Ngupy_NgulakKopy.Views.Petani.PengaturanAkunPetani;
using Ngupy_NgulakKopy.Views.Petani.ProfilPetani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Petani.Dashboard.PengaturanProfilPetani
{
    public partial class PengaturanPetani : Form
    {
        public PengaturanPetani()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPengaturanPetani1_Load(object sender, EventArgs e)
        {

        }

        private void AturProfilPetani_Click(object sender, EventArgs e)
        {
            this.Hide();
            AturProfil profil = new AturProfil();
            profil.ShowDialog();
        }

        private void KeamananAkunPetani_Click(object sender, EventArgs e)
        {
            KeamananAkunPetani akun = new KeamananAkunPetani();
            akun.Show();
            this.Hide();
        }

        private void UbahProfilPetani_Click(object sender, EventArgs e)
        {
        
            DialogResult result = MessageBox.Show(
                "Anda akan Log out?",
                "Yakin?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Berhasil Logout.", "klik Ok untuk melanjutkan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 awal = new Form1();
                awal.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.DashboardPetani dashboardPetani = new Dashboard.DashboardPetani();
            dashboardPetani.ShowDialog();
        }

        private void PengaturanPetani_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void KebijakanPrivasi_Click(object sender, EventArgs e)
        {
            KebijakanPrivasi kebijakan = new KebijakanPrivasi();
            kebijakan.Show();
            this.Hide();
        }
    }
}