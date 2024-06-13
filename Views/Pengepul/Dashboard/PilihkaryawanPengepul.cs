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

namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    public partial class PilihkaryawanPengepul : Form
    {
        string constr = $"Server=localhost;Username=postgres;Password=jember110605;Database=luky_database;Port=5432;Pooling=True";
        public PilihkaryawanPengepul()
        {
            InitializeComponent();
            GetPegawaiPengepul1();
            GetPegawaiPengepul2();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PilihkaryawanPengepul_Load(object sender, EventArgs e)
        {

            // Maximize the form to fill the screen
            this.WindowState = FormWindowState.Maximized;

            // Optionally, set the bounds to the screen bounds (if you want to be explicit)
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardPengepul dashboardPengepul = new DashboardPengepul();
            dashboardPengepul.ShowDialog();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetPegawaiPengepul1()
        {
            string noPegawai1 = " ";
            string namaPegawai1 = " ";
            string noTelppegawai1 = " ";
            string alamatPegawai1 = " ";

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                try
                {
                    conn.Open();

                    string querynoPegawai1 = "SELECT id_pegawai_penjemputan\r\nFROM pegawai_penjemputan\r\nORDER BY id_pegawai_penjemputan\r\nLIMIT 1\r\nOFFSET 0";
                    string querynamaPegawai1 = "SELECT nama_pegawai\r\nFROM pegawai_penjemputan\r\nORDER BY id_pegawai_penjemputan\r\nLIMIT 1\r\nOFFSET 0";
                    string queryNotelppegawai1 = "SELECT nomor_telepon\r\nFROM pegawai_penjemputan\r\nORDER BY id_pegawai_penjemputan\r\nLIMIT 1\r\nOFFSET 0";
                    string queryAlamatpegawai1 = "\r\nSELECT nama_jalan || ',' || desa || ',' || kecamatan AS \"alamat\"\r\nFROM alamat\r\nORDER BY id_alamat\r\nLIMIT 1\r\nOFFSET 0";
                    NpgsqlCommand cmdNopegawai1 = new NpgsqlCommand(querynoPegawai1, conn);
                    NpgsqlCommand cmdNamapegawai1 = new NpgsqlCommand(querynamaPegawai1, conn);
                    NpgsqlCommand cmdNotelppegawai = new NpgsqlCommand(queryNotelppegawai1, conn);
                    NpgsqlCommand cmdAlamatpegawai = new NpgsqlCommand(queryAlamatpegawai1, conn);




                    using (NpgsqlDataReader reader = cmdNopegawai1.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                noPegawai1 = reader.GetInt32(0).ToString(); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }

                    using (NpgsqlDataReader reader = cmdNamapegawai1.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                namaPegawai1 = reader.GetString(0); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }
                    using (NpgsqlDataReader reader = cmdNotelppegawai.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                noTelppegawai1 = reader.GetString(0); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }
                    using (NpgsqlDataReader reader = cmdAlamatpegawai.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                alamatPegawai1 = reader.GetString(0); //assuming harga is the first column
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
            label6.Text = $"{noPegawai1}";
            label7.Text = $"{namaPegawai1}";
            label8.Text = $"{noTelppegawai1}";
            label9.Text = $"{alamatPegawai1}";



        }
        private void GetPegawaiPengepul2()
        {
            string noPegawai2 = " ";
            string namaPegawai2 = " ";
            string noTelppegawai2 = " ";
            string alamatPegawai2 = " ";

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                try
                {
                    conn.Open();

                    string querynoPegawai2 = "SELECT id_pegawai_penjemputan FROM pegawai_penjemputan ORDER BY id_pegawai_penjemputan LIMIT 1 OFFSET 1\r\n";
                    string querynamaPegawai2 = "SELECT nama_pegawai FROM pegawai_penjemputan ORDER BY id_pegawai_penjemputan LIMIT 1 OFFSET 1\r\n";
                    string queryNotelppegawai2 = "SELECT nomor_telepon FROM pegawai_penjemputan ORDER BY id_pegawai_penjemputan LIMIT 1 OFFSET 1";
                    string queryAlamatpegawai2 = "\r\nSELECT nama_jalan || ',' || desa || ',' || kecamatan AS \"alamat\"\r\nFROM alamat\r\nORDER BY id_alamat\r\nLIMIT 1\r\nOFFSET 0";
                    NpgsqlCommand cmdNopegawai2 = new NpgsqlCommand(querynoPegawai2, conn);
                    NpgsqlCommand cmdNamapegawai2 = new NpgsqlCommand(querynamaPegawai2, conn);
                    NpgsqlCommand cmdNotelppegawai2 = new NpgsqlCommand(queryNotelppegawai2, conn);
                    NpgsqlCommand cmdAlamatpegawai2 = new NpgsqlCommand(queryAlamatpegawai2, conn);




                    using (NpgsqlDataReader reader = cmdNopegawai2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                noPegawai2 = reader.GetInt32(0).ToString(); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }

                    using (NpgsqlDataReader reader = cmdNamapegawai2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                namaPegawai2 = reader.GetString(0); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }
                    using (NpgsqlDataReader reader = cmdNotelppegawai2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                noTelppegawai2 = reader.GetString(0); //assuming harga is the first column
                                break; // Get only the first row (assuming latest price)
                            }
                        }
                    }
                    using (NpgsqlDataReader reader = cmdAlamatpegawai2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                alamatPegawai2 = reader.GetString(0); //assuming harga is the first column
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
            label13.Text = $"{noPegawai2}";
            label12.Text = $"{namaPegawai2}";
            label11.Text = $"{noTelppegawai2}";
            label10.Text = $"{alamatPegawai2}";



        }
        //private void GetPegawaiPengepul2()
        //{
        //    string noPegawai3 = " ";
        //    string namaPegawai3 = " ";
        //    string noTelppegawai3 = " ";
        //    string alamatPegawai3 = " ";

        //    using (NpgsqlConnection conn = new NpgsqlConnection(constr))
        //    {
        //        try
        //        {
        //            conn.Open();

        //            string querynoPegawai3 = "SELECT id_pegawai_penjemputan FROM pegawai_penjemputan ORDER BY id_pegawai_penjemputan LIMIT 1 OFFSET 1\r\n";
        //            string querynamaPegawai3 = "SELECT nama_pegawai FROM pegawai_penjemputan ORDER BY id_pegawai_penjemputan LIMIT 1 OFFSET 1\r\n";
        //            string queryNotelppegawai3 = "SELECT nomor_telepon FROM pegawai_penjemputan ORDER BY id_pegawai_penjemputan LIMIT 1 OFFSET 1";
        //            string queryAlamatpegawai3 = "\r\nSELECT nama_jalan || ',' || desa || ',' || kecamatan AS \"alamat\"\r\nFROM alamat\r\nORDER BY id_alamat\r\nLIMIT 1\r\nOFFSET 0";
        //            NpgsqlCommand cmdNopegawai3 = new NpgsqlCommand(querynoPegawai3, conn);
        //            NpgsqlCommand cmdNamapegawai3 = new NpgsqlCommand(querynamaPegawai3, conn);
        //            NpgsqlCommand cmdNotelppegawai3 = new NpgsqlCommand(queryNotelppegawai3, conn);
        //            NpgsqlCommand cmdAlamatpegawai3 = new NpgsqlCommand(queryAlamatpegawai3, conn);




        //            using (NpgsqlDataReader reader = cmdNopegawai3.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        noPegawai3 = reader.GetInt32(0).ToString(); //assuming harga is the first column
        //                        break; // Get only the first row (assuming latest price)
        //                    }
        //                }
        //            }

        //            using (NpgsqlDataReader reader = cmdNamapegawai3.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        namaPegawai3 = reader.GetString(0); //assuming harga is the first column
        //                        break; // Get only the first row (assuming latest price)
        //                    }
        //                }
        //            }
        //            using (NpgsqlDataReader reader = cmdNotelppegawai3.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        noTelppegawai3 = reader.GetString(0); //assuming harga is the first column
        //                        break; // Get only the first row (assuming latest price)
        //                    }
        //                }
        //            }
        //            using (NpgsqlDataReader reader = cmdAlamatpegawai3.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        alamatPegawai3 = reader.GetString(0); //assuming harga is the first column
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
        //    label17.Text = $"{noPegawai3}";
        //    label16.Text = $"{namaPegawai3}";
        //    label15.Text = $"{noTelppegawai3}";
        //    label10.Text = $"{alamatPegawai3}";



        //}































        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private int? idPegawai = null;
        private int? idPenjemputan = null;

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked && idPegawai.HasValue && idPenjemputan.HasValue)
            {
                SaveToDatabase(idPegawai.Value, idPenjemputan.Value);
            }
            else
            {
                MessageBox.Show("The checkbox is not checked or the IDs are not valid.");
            }
        }

        // Event handler for guna2CheckBox1 CheckedChanged
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox == guna2CheckBox1 && checkBox.Checked)
            {
                string idPegawaiString = GetPegawaiId();
                if (int.TryParse(idPegawaiString, out int parsedIdPegawai))
                {
                    idPegawai = parsedIdPegawai;
                }
                else
                {
                    MessageBox.Show("Invalid Pegawai ID format. Please ensure the ID is a valid integer.");
                    idPegawai = null; // Reset if invalid
                }

                string idPenjemputanString = GetPenjemputanId();
                if (int.TryParse(idPenjemputanString, out int parsedIdPenjemputan))
                {
                    idPenjemputan = parsedIdPenjemputan;
                }
                else
                {
                    MessageBox.Show("Invalid Penjemputan ID format. Please ensure the ID is a valid integer.");
                    idPenjemputan = null; // Reset if invalid
                }
            }
            else
            {
                idPegawai = null; // Reset if checkbox is unchecked
                idPenjemputan = null; // Reset if checkbox is unchecked
            }
        }

        // Method to save data to the database
        private void SaveToDatabase(int idPegawai, int idPenjemputan)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    string query = "INSERT INTO detail_penjemputan (id_pegawai_penjemputan, id_penjemputan) VALUES (@idPegawai, @idPenjemputan)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn, transaction))
                    {
                        try
                        {
                            // Log the idPegawai and idPenjemputan values and query
                            Console.WriteLine($"Executing query: {query} with idPegawai = {idPegawai}, idPenjemputan = {idPenjemputan}");

                            // Clear previous parameters just in case
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idPegawai", idPegawai);
                            cmd.Parameters.AddWithValue("@idPenjemputan", idPenjemputan);

                            // Log the parameter binding
                            Console.WriteLine("Parameters bound: @idPegawai = " + idPegawai + ", @idPenjemputan = " + idPenjemputan);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Berhasil ditugaskan!");
                                Console.WriteLine("Berhasil ditugaskan!");
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Data was not saved.");
                                Console.WriteLine("Data was not saved.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Database error: {ex.Message}");
                            Console.WriteLine($"Database error: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"An error occurred: {ex.Message}");
                            Console.WriteLine($"An error occurred: {ex.Message}");
                        }
                    }
                }
            }
        }

        // Method to get the Pegawai ID value
        private string GetPegawaiId()
        {
            return label6.Text; // Assuming label6 contains the Pegawai ID
        }

        // Method to get the Penjemputan ID value
        private string GetPenjemputanId()
        {
            return label6.Text; // Assuming label7 contains the Penjemputan ID
        }

        private void guna2ShadowPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
