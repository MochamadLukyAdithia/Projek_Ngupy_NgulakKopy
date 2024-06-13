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
            
            string username = usernameP.Text;
            string NomorHp = nohpP.Text;
            string Jalan = JalanP.Text;
            string Desa = desaP.Text;
            string NoRekening = norekP.Text;

        
            string constr = $"Server=localhost;Username=postgres;Password=jember110605;Database=luky_database;Port=5432;Pooling=true;";
            NpgsqlConnection conn = new NpgsqlConnection(constr);
            conn.Open();

            string Ambilid = $"Select id_alamat from \"User\" where username = '{LoginPetani.username}'";
            NpgsqlCommand queryid = new NpgsqlCommand(Ambilid, conn);
            NpgsqlDataReader id = queryid.ExecuteReader();
            id.Read();

            string id_alamat = id[0].ToString();
            conn.Close();
           

            string query = "UPDATE \"User\" SET ";

            if (!string.IsNullOrEmpty(username))
            {
                query += $"username = '{username}' WHERE username = '{LoginPetani.username}'";
            }

            if (!string.IsNullOrEmpty(NomorHp))
            {
                conn.Open();
                string query_nohp = query += $"nomor_telepon = '{NomorHp}' WHERE username = '{LoginPetani.username}'";
                NpgsqlCommand up_nohp = new NpgsqlCommand (query_nohp, conn);
                up_nohp.ExecuteNonQuery();
                conn.Close();
            }
    
            if (!string.IsNullOrEmpty(Jalan))

            {
                conn.Open();
                string UpdateJalan = $"Update alamat set nama_jalan = '{Jalan}' where id_alamat = '{id_alamat}'";
                NpgsqlCommand upjalan = new NpgsqlCommand(UpdateJalan, conn);
                upjalan.ExecuteNonQuery();
                conn.Close();

                // Anda mungkin perlu membuat query tambahan untuk mengupdate alamat pengguna
                // query += $"alamat = '{Jalan}', ";
            }

            if (!string.IsNullOrEmpty(Desa))
            {
                conn.Open();
                string UpdateDesa = $"Update alamat set desa = '{Desa}' where id_alamat = '{id_alamat}'";
                NpgsqlCommand updesa = new NpgsqlCommand(UpdateDesa, conn);
                updesa.ExecuteNonQuery();
                conn.Close();
            }

            if (!string.IsNullOrEmpty(NoRekening))
            {
                conn.Open();
                string query_norek = query += $"nomor_rekening = '{NoRekening}' WHERE username = '{LoginPetani.username}'";
                NpgsqlCommand up_norek = new NpgsqlCommand(query_norek, conn);
                up_norek.ExecuteNonQuery();
                conn.Close();
            }

            // Hapus koma terakhir jika ada
           
/*
            query += $" WHERE username = '{LoginPetani.username}'";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();*/
         


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

        private void Jalan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}