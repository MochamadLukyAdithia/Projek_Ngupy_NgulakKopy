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

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string database = "Host=localhost;Username=postgres;Password=moluka;Database=ngupy";
            NpgsqlConnection connect = new NpgsqlConnection(database);
            connect.Open();
            string query = $"UPDATE \"User\" SET nomor_rekening = '{guna2TextBox3.Text}' where \"User\".id_peran = 2";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
