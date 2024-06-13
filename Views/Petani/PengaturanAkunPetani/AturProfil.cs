using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ngupy_NgulakKopy.Controllers;
using Ngupy_NgulakKopy.Tools;
using Ngupy_NgulakKopy.Views.Petani.Dashboard.PengaturanProfilPetani;
using Npgsql;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ngupy_NgulakKopy.Views.Petani.ProfilPetani
{
    public partial class AturProfil : Form

    {
        
        public AturProfil()
        {
            InitializeComponent();
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void UbahProfilPetani_Click(object sender, EventArgs e)
        {
            string username = usernameP.Text;
            string nomorHp = nohpP.Text;
            string jalan = JalanP.Text;
            string desa = desaP.Text;
            string kecamatan = KecamatanP.Text;
            string noRekening = norekP.Text;

            var controller = new UserControllers();
            string result = controller.UpdateUserProfile(LoginPetani.username, username, nomorHp, jalan, desa, kecamatan, noRekening);

            MessageBox.Show(result, result.Contains("successfully") ? "Success" : "Error");
            DisplayUsernamePetani();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PengaturanPetani profil = new PengaturanPetani();
            profil.Show();
            this.Hide();
        }

        private void norekP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Jalan_TextChanged(object sender, EventArgs e)
        {

        }

        private void AturProfil_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            DisplayUsernamePetani();
           


        }
        private void refresh_Click(object sender, EventArgs e)
        {

        }
        public void DisplayUsernamePetani()
        {

            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT u.username, u.nomor_telepon, a.nama_jalan, a.desa, a.kecamatan, u.nomor_rekening FROM alamat a join \"User\" u on (a.id_alamat = u.id_alamat) where u.username = '{LoginPetani.username}'", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DisplayUsernameP.Text = $"{reader.GetString(0)}";
                            DisplayNoHP.Text = $"{reader.GetString(1)}";
                            DisplayJalan.Text = $"{reader.GetString(2)}";
                            DisplayDesaP.Text = $"{reader.GetString(3)}";
                            DisplayKecamatanP.Text = $"{reader.GetString(4)}";
                            DisplayNoRek.Text = $"{reader.GetString(5)}";
                        }
                        conn.Close();
                    }
                }
            }

        }







        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayusername_Click(object sender, EventArgs e)
        {

        }

        private void RefreshProfil_Click(object sender, EventArgs e)
        {

        }

        private void displayU_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DisplayNoRek_Click(object sender, EventArgs e)
        {

        }
    }
}