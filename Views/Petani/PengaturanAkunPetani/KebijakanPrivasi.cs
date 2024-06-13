using Ngupy_NgulakKopy.Views.Petani.Dashboard.PengaturanProfilPetani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Petani.PengaturanAkunPetani
{
    public partial class KebijakanPrivasi : Form
    {
        private string username;
        public KebijakanPrivasi(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KebijakanPrivasi_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void back_Click(object sender, EventArgs e)
        {
            PengaturanPetani profil = new PengaturanPetani(username);
            profil.Show();
            this.Hide();
        }
    }
}
