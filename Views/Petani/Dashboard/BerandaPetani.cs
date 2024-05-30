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
using Ngupy_NgulakKopy.Views.Petani;

namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class BerandaPetani : UserControl
    {
        public BerandaPetani()
        {
            InitializeComponent();
            readHarga();
        }

        private void BerandaPetani_Load(object sender, EventArgs e)
        {
            readHarga();
        }

        private void readHarga()
        {
            lblusername.Text = LoginPetani.username;
            try
            {
                string database = "Host=localhost;Username=postgres;Password=c4peKBgt!;Database=Ngupy";
                NpgsqlConnection conn = new NpgsqlConnection(database);

                string selectnow = $"SELECT TO_CHAR(CURRENT_DATE, 'dd/mm/yyyy')";
                conn.Open();
                NpgsqlCommand select_cd = new NpgsqlCommand(selectnow, conn);
                NpgsqlDataReader cd = select_cd.ExecuteReader();
                cd.Read();
                lblTanggal.Text = cd[0].ToString();
                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            try
            {
                string database = "Host=localhost;Username=postgres;Password=c4peKBgt!;Database=Ngupy";
                NpgsqlConnection conn = new NpgsqlConnection(database);

                string select_harga = "$SELECT ";

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



            //if (reader.HasRows)
            //{
            //    reader.Read();

            //    if (reader.GetString(1) == txtPassword.Text)
            //    {
            //        MessageBox.Show($"Berhasil login, Selamat datang, {txtUsername.Text}", "Success");
            //        username = txtUsername.Text;
            //        conn.Close();
            //        this.Hide();
            //        GetStarted getStarted = new GetStarted();
            //        getStarted.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Password salah", "Warning");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Username tidak dapat ditemukan", "Error");
            //}
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }
    }
}
