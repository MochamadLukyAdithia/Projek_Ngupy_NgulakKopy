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
            string constr = $"Server=localhost;Username=postgres;Password=wahyuok234;Database=Ngupy_Database;Port=5432;Pooling=true;";
            NpgsqlConnection conn = new NpgsqlConnection(constr);
            string query = $"UPDATE \"User\" SET username = '{usernameP.Text}', nomor_telepon = '{nohpP.Text}', nomor_rekening = '{norekP.Text}' WHERE username = '{LoginPetani.username}'";

            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader;
            reader = cmd.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        reader.Read();

        //        if (reader.GetString(1) == txtPassword.Text)
        //        {
        //            MessageBox.Show($"Berhasil login, Selamat datang, {txtUsername.Text}", "Success");
        //            username = txtUsername.Text;
        //            conn.Close();
        //            this.Hide();
        //            GetStarted getStarted = new GetStarted();
        //            getStarted.ShowDialog();
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Password salah", "Warning");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Username tidak dapat ditemukan", "Error");
        //    }
        //}

        MessageBox.Show("Data Berhasil Disimpan!", "Sukses", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
    }
}