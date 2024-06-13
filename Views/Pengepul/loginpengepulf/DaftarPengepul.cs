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
using Ngupy_NgulakKopy.Tools;
using Npgsql;
using Ngupy_NgulakKopy.Controllers;
using Ngupy_NgulakKopy.Views.Petani;

namespace Ngupy_NgulakKopy.Views.Pengepul
{
    public partial class DaftarPengepul : Form
    {
       
        public DaftarPengepul()
        {
            InitializeComponent();
          
        }

       

        private void DaftarPengepul_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasukPengepul masuk = new MasukPengepul();
            masuk.Show();
        }

        private void btnLoginPetani_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string NomorHp = txtNomorHandphone.Text;
            string Desa = txtDesa.SelectedItem.ToString();
            string Jalan = txtJalan.Text;
            string Kecamatan = txtKecamatan.SelectedItem.ToString();
            string KonfirPassword = txtKonfirmasiPassword.Text;

            AkunControllers akunControllers = new AkunControllers();
            AlamatControllers alamatControllers = new AlamatControllers();

            if (password != KonfirPassword)
            {
                MessageBox.Show($"Password tidak sama dengan konfirmasi password");
                return;
            }

            bool username_ada = akunControllers.Cek_Username(username);

            if (username_ada == true)
            {
                MessageBox.Show($"Username sudah ada!");
                return;
            }

            int? id_alamat = alamatControllers.insert_alamat(Jalan, Desa, Kecamatan);

            if (id_alamat == null)
            {
                MessageBox.Show("Gagal menambahkan alamat.");
                return;
            }

            akunControllers.Daftar(nama, NomorHp, username, password, 2, Convert.ToInt32(id_alamat), 1);

            MessageBox.Show($"Data anda berhasil ditambahkan");
            this.Hide();
            MasukPengepul lp = new MasukPengepul();
            lp.ShowDialog();
        }
    }
}
