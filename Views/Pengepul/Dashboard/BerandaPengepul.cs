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
using Ngupy_NgulakKopy;
using Ngupy_NgulakKopy.Views.Pengepul.Dashboard;
using Ngupy_NgulakKopy.Tools;

namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    public partial class BerandaPengepul : UserControl
    {
        string constr = $"Server=localhost;Username=postgres;Password=jember110605;Database=luky_database;Port=5432;Pooling=True";
        public BerandaPengepul()
        {
            InitializeComponent();


        }

        public void DisplayTanggal()
        {

            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT update_at FROM harga_kopi order by id_haga desc limit 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTanggal.Text = $"{reader.GetDateTime(0)}";
                        }
                        conn.Close();
                    }
                }
            }

        }


        public void DisplayHargaPusat()
        {
            

            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT harga FROM harga_kopi ORDER BY id_haga DESC LIMIT 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int hargaKualitas = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            if (hargaKualitas > 0)
                            {
                                label5.Text = hargaKualitas.ToString();
                                label5.Visible = true;
                            }
                            else
                            {
                                label5.Text = string.Empty;
                                label5.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        public void DisplayStokKopi()
        {
            
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("select sum(stok_kopi) from gudang", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int stokKopi = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            if (stokKopi > 0)
                            {
                                kapasitaslbl.Text = stokKopi.ToString(); ;
                                kapasitaslbl.Visible = true;
                            }
                            else
                            {
                                kapasitaslbl.Text = string.Empty;
                                kapasitaslbl.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        //private void GetTanggal()
        //{
        //    DateTime today = DateTime.Now;
        //    string formattedDate = today.ToString("MM/dd/yyyy");
        //    lblTanggal.Text = $"{formattedDate}";
        //}



        //private void GetHargaKopi()
        //{
        //    string harga = "";

        //    using (NpgsqlConnection conn = new NpgsqlConnection(constr))
        //    {
        //        try
        //        {
        //            conn.Open();

        //            string queryHarga = "SELECT harga FROM harga_kopi ORDER BY id_haga DESC LIMIT 1";
        //            NpgsqlCommand cmdHarga = new NpgsqlCommand(queryHarga, conn);

        //            using (NpgsqlDataReader reader = cmdHarga.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        harga = reader.GetInt32(0).ToString(); //assuming harga is the first column
        //                        break; // Get only the first row (assuming latest price)
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}");
        //        }
        //    }

        //    // Update the label text to display the retrieved harga
        //    label5.Text = $"{harga}"; // Format the label text
        //}

        private void BerandaPengepul_Load(object sender, EventArgs e)
        {
            DisplayHargaPusat();
            DisplayTanggal();
            DisplayStokKopi();
            GetPetani1();
            GetPetani2();
            GetPetani3();
        }

        //private void GetKapasitas()
        //{
        //    string kapasitas_gudang = " ";

        //    using (NpgsqlConnection conn = new NpgsqlConnection(constr))
        //    {
        //        try
        //        {
        //            conn.Open();

        //            string queryKapasitas_gudang = $"SELECT stok_kopi || ' Kg. / ' || kapasitas_gudang || ' ton'\r\nFROM gudang;\r\n";
        //            NpgsqlCommand cmdKapasitas = new NpgsqlCommand(queryKapasitas_gudang, conn);

        //            using (NpgsqlDataReader reader = cmdKapasitas.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        kapasitas_gudang = reader.GetString(0); //assuming harga is the first column
        //                        break; // Get only the first row (assuming latest price)
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}");
        //        }
        //    }

        //    // Update the label text to display the retrieved harga
        //    label9.Text = $"{kapasitas_gudang}"; 


        //}

        private void label5_Click(object sender, EventArgs e)
        {


        }
        private void lblTanggal_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlKapasitas_Paint(object sender, PaintEventArgs e)
        {
            DisplayStokKopi();
        }

        private void pnlHarga_Paint(object sender, PaintEventArgs e)
        {

        }



        internal void pictureBox2_Click(object sender, EventArgs e)
        {
            
            PilihkaryawanPengepul pilihKaryawanpengepul1 = new PilihkaryawanPengepul();
            pilihKaryawanpengepul1.ShowDialog();
            

        }


        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GetPetani1()
        {
            string namaPetani1 = " ";
            string tanggalPetani1 = " ";
            


            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                try
                {
                    conn.Open();

                    string queryNamapetani1 = "SELECT u.nama\r\nFROM \"User\" u\r\nJOIN Transaksi t ON (u.id_user = t.id_user)\r\nJOIN penjemputan p ON (p.id_penjemputan = t.id_penjemputan)\r\nORDER BY p.waktu_penjemputan\r\nLIMIT 1;";
                    string querytanggalPetani1 = "SELECT p.waktu_penjemputan\r\nFROM \"User\" u\r\nJOIN Transaksi t ON (u.id_user = t.id_user)\r\nJOIN penjemputan p ON (p.id_penjemputan = t.id_penjemputan)\r\nORDER BY p.waktu_penjemputan\r\nLIMIT 1;";
                    NpgsqlCommand cmdNamapetani1 = new NpgsqlCommand(queryNamapetani1, conn);
                    NpgsqlCommand cmdtanggalPetani1 = new NpgsqlCommand(querytanggalPetani1, conn);



                    using (NpgsqlDataReader reader = cmdNamapetani1.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                namaPetani1 = reader.GetString(0); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }

                    using(NpgsqlDataReader reader = cmdtanggalPetani1.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tanggalPetani1 = reader.GetDateTime(0).ToString(); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            // Update the label text to display the retrieved harga
            Petani1.Text = $"{namaPetani1}";
            label10.Text = $"{tanggalPetani1}";


        }
        private void GetPetani2()
        {
            string namaPetani2 = " ";
            string tanggalPetani2 = " ";



            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                try
                {
                    conn.Open();

                    string queryNamapetani2 = "SELECT u.nama\r\nFROM \"User\" u\r\nJOIN Transaksi t ON (u.id_user = t.id_user)\r\nJOIN penjemputan p ON (p.id_penjemputan = t.id_penjemputan)\r\nORDER BY p.waktu_penjemputan\r\nLIMIT 1\r\nOFFSET 1";
                    string querytanggalPetani2 = "SELECT p.waktu_penjemputan\r\nFROM \"User\" u\r\nJOIN Transaksi t ON (u.id_user = t.id_user)\r\nJOIN penjemputan p ON (p.id_penjemputan = t.id_penjemputan)\r\nORDER BY p.waktu_penjemputan\r\nLIMIT 1\r\nOFFSET 1";
                    NpgsqlCommand cmdNamapetani2 = new NpgsqlCommand(queryNamapetani2, conn);
                    NpgsqlCommand cmdtanggalPetani2 = new NpgsqlCommand(querytanggalPetani2, conn);



                    using (NpgsqlDataReader reader = cmdNamapetani2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                namaPetani2 = reader.GetString(0); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }

                    using (NpgsqlDataReader reader = cmdtanggalPetani2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tanggalPetani2 = reader.GetDateTime(0).ToString(); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            // Update the label text to display the retrieved harga
            Petani2.Text = $"{namaPetani2}";
            label11.Text = $"{tanggalPetani2}";

        }

        private void GetPetani3()
        {
            string namaPetani3 = " ";
            string tanggalPetani3 = " ";



            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                try
                {
                    conn.Open();

                    string queryNamapetani3 = "SELECT u.nama\r\nFROM \"User\" u\r\nJOIN Transaksi t ON (u.id_user = t.id_user)\r\nJOIN penjemputan p ON (p.id_penjemputan = t.id_penjemputan)\r\nORDER BY p.waktu_penjemputan\r\nLIMIT 2\r\nOFFSET 2;";
                    string querytanggalPetani3 = "SELECT p.waktu_penjemputan\r\nFROM \"User\" u\r\nJOIN Transaksi t ON (u.id_user = t.id_user)\r\nJOIN penjemputan p ON (p.id_penjemputan = t.id_penjemputan)\r\nORDER BY p.waktu_penjemputan\r\nLIMIT 2\r\nOFFSET 2";
                    NpgsqlCommand cmdNamapetani3 = new NpgsqlCommand(queryNamapetani3, conn);
                    NpgsqlCommand cmdtanggalPetani3 = new NpgsqlCommand(querytanggalPetani3, conn);



                    using (NpgsqlDataReader reader = cmdNamapetani3.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                namaPetani3 = reader.GetString(0); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }

                    using (NpgsqlDataReader reader = cmdtanggalPetani3.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tanggalPetani3 = reader.GetDateTime(0).ToString(); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            // Update the label text to display the retrieved harga
            Petani3.Text = $"{namaPetani3}";
            label12.Text = $"{tanggalPetani3}";

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Petani1_Click(object sender, EventArgs e)
        {
            
        }

        private void Petani2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Petani3_Click(object sender, EventArgs e)
        {

        }

        private void pnlPenjemptan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
