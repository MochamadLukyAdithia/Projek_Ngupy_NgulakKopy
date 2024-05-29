using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Ngupy_NgulakKopy.Views.Petani.ProfilPetani
{
    public partial class AturProfil : Form
    {
        public AturProfil()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            string constr = $"Server=localhost;Username=postgres;Password=Harsa_05;Database=Ngupy_Database;Port=5432;Pooling=true;";
            NpgsqlConnection conn = new NpgsqlConnection(constr);
            string query = $"UPDATE \"User\" SET username = '{usernameP.Text}', nomor_telepon = '{nohpP.Text}', desa = '{desaP.Text}', nomor_rekening = '{norekP.Text}' WHERE id_user = 1";
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Disimpan!", "Sukses", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}