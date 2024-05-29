using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Ngupy_NgulakKopy.Views.Petani
{
    public partial class DaftarPetani : Form
    {
        public DaftarPetani()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string NomorHp = txtNomorHandphone.Text;
            string Desa = txtDesa.SelectedItem.ToString();
            string Jalan = txtJalan.Text;
            string Kecamatan = txtKecamatan.SelectedItem.ToString();
            string KonfirPassword = txtKonfirmasiPassword.Text;
            string connect = $"Server=localhost;Username=postgres;Password=Harsa_05;Database=Ngupy_Database;Port=5432;Pooling=True;";
            string idalamat = $"select id_alamat from alamat where nama_jalan ilike '{Jalan}'";
            string queryalamat = $"insert into alamat(nama_jalan,desa,kecamatan) values('{Jalan}','{Desa}','{Kecamatan}')";
            string queryusername = $"select username from \"User\" where username like '{username}'";
            
            NpgsqlConnection conn = new NpgsqlConnection(connect);
            
            conn.Open();
            NpgsqlCommand select_username = new NpgsqlCommand(queryusername, conn);
            NpgsqlDataReader pick_uname = select_username.ExecuteReader();
            
            if (pick_uname.Read())
            {
                if (KonfirPassword == password)
                {
                    string uname = pick_uname[0].ToString();
                    conn.Close();
                    if (username == uname)
                    {
                        MessageBox.Show($"Username sudah ada!");
                    }
                }
            }
            else
            {
                conn.Close();
                conn.Open();
                NpgsqlCommand insertalamat = new NpgsqlCommand(queryalamat, conn);
                insertalamat.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                NpgsqlCommand ambilid = new NpgsqlCommand(idalamat, conn);
                NpgsqlDataReader reader = ambilid.ExecuteReader();

                if (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    conn.Close();
                    conn.Open();
                    string queryuser = $"insert into \"User\"(nama,nomor_telepon,username,password,id_peran,id_alamat,id_kualitas_kopi) values ('{nama}','{NomorHp}','{username}','{password}','1',{ID},1)";
                    NpgsqlCommand insertuser = new NpgsqlCommand(queryuser, conn);
                    insertuser.Parameters.AddWithValue("desa_id_desa", ID);
                    insertuser.ExecuteNonQuery();
                    MessageBox.Show($"Data anda berhasil ditambahkan");
                    this.Hide();
                    LoginPetani lp = new LoginPetani();
                    lp.ShowDialog();
                }


            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPetani lp = new LoginPetani();
            lp.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
