using Ngupy_NgulakKopy.Models;
using Ngupy_NgulakKopy.Tools;
using Ngupy_NgulakKopy.Views.Petani.Dashboard;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    public partial class HargaPengepul : UserControl
    {
        //string constr = $"Server=localhost;Username=postgres;Password=jember110605;Database=luky_database;Port=5432;Pooling=True";

        private List<string> hargakualitas = new List<string>();
        KualitasKopiContext Kopilist;
        public HargaPengepul()
        {
            InitializeComponent();
            Kopilist = new KualitasKopiContext();
        }

        private void HargaPengepul_Load(object sender, EventArgs e)
        {

            DisplayHargaPetani();
            DisplayHargaTerbaru();
            DisplayKualitasKopi();
            DisplayStokKopi();
          

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtKualitas.Text) || string.IsNullOrEmpty(txthargakualitas.Text))
            {
                MessageBox.Show("Harap isi semua field terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Models.KualitasKopi kualitasKopi = Getharga_kualitasNew();
                Kopilist.Update(kualitasKopi);
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Question);
                DisplayHargaPetani();
                DisplayHargaTerbaru();
                DisplayKualitasKopi();
                DisplayStokKopi();
                BerandaPengepul berandaPengepul = new BerandaPengepul();
            }

            



            //brndpngpl br = new brndpngpl();
            //NpgsqlConnection conn = new NpgsqlConnection(constr);

            //try
            //{
            //    // Buka koneksi ke database
            //    conn.Open();

            //    // Query untuk memperbarui data
            //    string query = "UPDATE kualitas_kopi SET harga = @harga";
            //    string query2 = "UPDATE gudang SET kapasitas_gudang = @kapasitas_gudang";


            //    // Membuat perintah dengan query dan koneksi
            //    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            //    NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);


            //    // Mengatur parameter untuk menghindari SQL Injection
            //    cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(txtharga.Text)); // Ganti sesuai id yang ingin diupdate
            //    cmd2.Parameters.AddWithValue("@kapasitas_gudang", Convert.ToInt32(txtkapasitas.Text));

            //    // Menjalankan perintah
            //    int rowsAffected = cmd.ExecuteNonQuery();
            //    int rowsAffected2 = cmd2.ExecuteNonQuery();

            //    // Menampilkan pesan sukses
            //    if (rowsAffected > 0)
            //    {
            //        MessageBox.Show("Data Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tidak ada data yang diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Menangani kesalahan dan menampilkan pesan error
            //    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    // Menutup koneksi
            //    if (conn != null && conn.State == System.Data.ConnectionState.Open)
            //    {
            //        conn.Close();
            //    }
            //}

            //lblhrgterbaru.Text = txtharga.Text;
            //lblkapasitas.Text = txtkapasitas.Text;

        }

        private Models.KualitasKopi Getharga_kualitasNew()
        {
            Models.KualitasKopi kualitasKopi = new Models.KualitasKopi();
            kualitasKopi.harga_kualitas = int.Parse(txthargakualitas.Text);
            kualitasKopi.kategori_kualitas_kopi = txtKualitas.Text;
            return kualitasKopi;

        }

        private Models.KualitasKopi GethargaNew()
        {
            Models.KualitasKopi kualitasKopi = new Models.KualitasKopi();
            kualitasKopi.harga_terbaru = txtharga.Text;
            return kualitasKopi;

        }

        public List<string> GetDataList()
        {
            return hargakualitas;
            
        }
        public void DisplayHargaPetani()
        {
            DateTime dt = DateTime.Now;
            labeltgl2.Text = dt.ToString("dd/MM/yyyy");

            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT harga_kualitas from kualitas_kopi order by id_kualitas_kopi desc limit 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int hargaKualitas = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            if (hargaKualitas > 0)
                            {
                                lblhargakualitas.Text = hargaKualitas.ToString();
                                lblhargakualitas.Visible = true;
                            }
                            else
                            {
                                lblhargakualitas.Text = string.Empty;
                                lblhargakualitas.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        public void DisplayHargaTerbaru()
        {
            DateTime dt = DateTime.Now;
            labelTanggal1.Text = dt.ToString("dd/MM/yyyy");

            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT harga_terbaru from kualitas_kopi order by id_kualitas_kopi desc limit 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hargaTerbaru = reader.IsDBNull(0) ? null : reader.GetString(0);
                            if (hargaTerbaru != null)
                            {
                                lblhrgterbaru.Text = hargaTerbaru;
                                lblhrgterbaru.Visible = true;
                            }
                            else
                            {
                                lblhrgterbaru.Text = string.Empty;
                                lblhrgterbaru.Visible = false;
                            }
                        }
                    }
                }
            }
        }

       




        public void DisplayKualitasKopi()
        {
           
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("select kategori_kualitas_kopi FROM kualitas_kopi order by id_kualitas_kopi desc limit 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string kualitasKopi = reader.IsDBNull(0) ? null : reader.GetString(0);
                            if (kualitasKopi != null)
                            {
                                kualitaslabel.Text = kualitasKopi;
                                kualitaslabel.Visible = true;
                            }
                            else
                            {
                                kualitaslabel.Text = string.Empty;
                                kualitaslabel.Visible = false;
                            }
                        }
                    }
                }
            }
        }


        public void DisplayStokKopi()
        {
            DateTime dt = DateTime.Now;
            labelTanggal2.Text = dt.ToString("dd/MM/yyyy");
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("select stok_kopi from gudang", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int stokKopi = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            if (stokKopi > 0)
                            {
                                lblkapasitas.Text = stokKopi.ToString(); ;
                                lblkapasitas.Visible = true;
                            }
                            else
                            {
                                lblkapasitas.Text = string.Empty;
                                lblkapasitas.Visible = false;
                            }
                        }
                    }
                }
            }
        }






        private void label11_Click(object sender, EventArgs e)
        {
            //GetTanggal();
        }

        private void GetTanggal()
        {
            //DateTime today = DateTime.Now;
            //string formattedDate = today.ToString("MM/dd/yyyy");
            //labelTanggal1.Text = $"{formattedDate}";

            //labelTanggal2.Text = $"{formattedDate}";
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTanggal2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {
            DisplayStokKopi();
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

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKualitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void kualitaslabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKualitas_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KonfirHargaTerbaru_Click(object sender, EventArgs e)
        {
            Models.KualitasKopi kualitasKopi = GethargaNew();
            Kopilist.Insert(kualitasKopi);
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Question);
            DisplayHargaTerbaru();
            DisplayKualitasKopi();
            DisplayHargaPetani();
            DisplayStokKopi();
            BerandaPengepul berandaPengepul = new BerandaPengepul();
        }

        private void ResetBttn_Click(object sender, EventArgs e)
        {
            
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE gudang SET stok_kopi = 0 WHERE id_gudang = 1", conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stok kopi berhasil di kirim.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayStokKopi();
                        }
                        else
                        {
                            MessageBox.Show("Tidak ada perubahan yang dilakukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void lblkapasitas_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
