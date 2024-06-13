using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pusat.Dashboard
{
    public partial class BerandaPusat : UserControl
    {
        public BerandaPusat()
        {
            InitializeComponent();
            DisplayLatestPrice();
            DateTime dt = DateTime.Now;
            lblTanggal.Text = dt.ToString("dd/MM/yyyy");
            //UpdateHargaPusat up = new UpdateHargaPusat();
            //up.DisplayLatestPricelbl2();
            //DisplayLatestPrice();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlHarga_Paint(object sender, PaintEventArgs e)
        {

        }
        public void DisplayLatestPrice()
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
                            label5.Text = $"{reader.GetInt32(0)}";
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void BerandaPusat_Load(object sender, EventArgs e)
        {
            
        }

        private void lblTanggal_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
