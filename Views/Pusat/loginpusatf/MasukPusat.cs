using Ngupy_NgulakKopy.Views.Petani;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ngupy_NgulakKopy.Views.Pusat
{
    public partial class MasukPusat : Form
    {
        public MasukPusat()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
     
      

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginPetani_Click(object sender, EventArgs e)
        {
            string database = "Host=localhost;Username=postgres;Password=moluka;Database=ngupy";
            NpgsqlConnection conn = new NpgsqlConnection(database);
            string query_username = $"SELECT Username, Password FROM \"User\" Where Username ilike '{txtUsername.Text}'and id_peran = 2";
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query_username, conn);
            NpgsqlDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                if (reader.GetString(1) == txtPassword.Text)
                {
                    MessageBox.Show($"Berhasil login, Selamat datang, {txtUsername.Text}", "Success");
                    string username = txtUsername.Text;
                    conn.Close();
                    this.Hide();
                    Views.Pusat.Dashboard.DashboardPusat dbp = new Dashboard.DashboardPusat();
                    dbp.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Password salah", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Username tidak dapat ditemukan", "Error");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaftarPusat dp = new DaftarPusat();
            dp.ShowDialog();
        }
    }
}
