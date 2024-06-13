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

namespace Ngupy_NgulakKopy.Views.Pusat.Dashboard
{
    public partial class TransaksiPusat : UserControl
    {
        public TransaksiPusat()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void guna2Button6_Click(object sender, EventArgs e)
        //{
        //    string database = "Host=localhost;Username=postgres;Password=moluka;Database=ngupy";
        //    NpgsqlConnection connect = new NpgsqlConnection(database);
        //    connect.Open();
        //    string query = $"UPDATE \"User\" SET nomor_rekening = '{txtRekening.Text}' where \"User\".id_peran = 2";
        //    NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
        //    cmd.ExecuteNonQuery();
        //    connect.Close();
        //}

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void DisplayNoRekening()
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT nomor_rekening from \"User\" WHERE \"User\".id_peran = 2", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtRekening.Text = $"{reader.GetString(0)}";
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void DisplayTotal()
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT (p.jumlah_kopi * hp.harga) Total\r\nFROM \"Penjualan\" p\r\nJOIN \"User\" u ON u.id_user = p.id_user \r\nJOIN harga_kopi hp ON p.id_harga = hp.id_haga\r\nORDER BY hp.id_haga desc limit 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblhrgterbaru.Text = $"{reader.GetInt32(0)}";
                        }
                        conn.Close();
                    }
                }
            }
        }
        private void TransaksiPusat_Load(object sender, EventArgs e)
        {
            DisplayNoRekening();
            DisplayTotal();
        }

        private void lblhrgterbaru_Click(object sender, EventArgs e)
        {

        }
    }
}
