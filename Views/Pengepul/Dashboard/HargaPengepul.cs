using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static Guna.UI2.Native.WinApi;

namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    public partial class HargaPengepul : UserControl
    {
        string constr = $"Server=localhost;Username=postgres;Password=321;Database=Ngupy;Port=5432;Pooling=True";

        public HargaPengepul()
        {
            InitializeComponent();
        }

        private void HargaPengepul_Load(object sender, EventArgs e)
        {

            GetTanggal();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            brndpngpl br = new brndpngpl();
            NpgsqlConnection conn = new NpgsqlConnection(constr);

            try
            {
                // Buka koneksi ke database
                conn.Open();

                // Query untuk memperbarui data
                string query = "UPDATE kualitas_kopi SET harga = @harga";
                string query2 = "UPDATE gudang SET kapasitas_gudang = @kapasitas_gudang";


                // Membuat perintah dengan query dan koneksi
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);


                // Mengatur parameter untuk menghindari SQL Injection
                cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(txtharga.Text)); // Ganti sesuai id yang ingin diupdate
                cmd2.Parameters.AddWithValue("@kapasitas_gudang", Convert.ToInt32(txtkapasitas.Text));

                // Menjalankan perintah
                int rowsAffected = cmd.ExecuteNonQuery();
                int rowsAffected2 = cmd2.ExecuteNonQuery();

                // Menampilkan pesan sukses
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Menangani kesalahan dan menampilkan pesan error
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Menutup koneksi
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            lblhrgterbaru.Text = txtharga.Text;
            lblkapasitas.Text = txtkapasitas.Text;
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            GetTanggal();
        }

        private void GetTanggal()
        {
            DateTime today = DateTime.Now;
            string formattedDate = today.ToString("MM/dd/yyyy");
            labelTanggal1.Text = $"{formattedDate}";

            labelTanggal2.Text = $"{formattedDate}";
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTanggal2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlUpdateHarga_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
