using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Petani
{
    public partial class LoginPetani : Form
    {
        static public string username;
        public LoginPetani()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLoginPetani_Click(object sender, EventArgs e)
        {
            string database = "Host=localhost;Username=postgres;Password=Harsa_05;Database=ngupy_projek;Port=5432;Pooling=True;";
            NpgsqlConnection conn = new NpgsqlConnection(database);
            string query_username = $"SELECT Username, Password FROM \"User\" Where Username ilike '{txtUsername.Text}' and id_peran = 1";
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
                    username = txtUsername.Text;
                    conn.Close();
                    this.Hide();
                    GetStarted getStarted = new GetStarted();
                    getStarted.ShowDialog();
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
            DaftarPetani dp = new DaftarPetani();
            dp.ShowDialog();
        }
    }
}