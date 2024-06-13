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
using Ngupy_NgulakKopy.Models;
using Ngupy_NgulakKopy.Tools;
using Npgsql;

namespace Ngupy_NgulakKopy.Views.Petani
{
    public partial class DaftarPusat : Form
    {

        Models.AlamatContext alamatContext;
        Tools.Connection connection = new Tools.Connection();
        public DaftarPusat()
        {
            InitializeComponent();
            alamatContext = new Models.AlamatContext();
        }


        private void btnDaftar_Click(object sender, EventArgs e)
        {
            Models.Alamat newAlamat = GetalamatNew();
            alamatContext.Insert(newAlamat);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
        private Models.Alamat GetalamatNew()
        {
            Models.Alamat newAlamat = new Models.Alamat();
            newAlamat.kecamatan = cbKec.SelectedItem.ToString();
            newAlamat.desa = cbdesa.SelectedItem.ToString();
            newAlamat.jalan = txtJalan.Text;
            return newAlamat;
        }      
        private void btnLoginPetani_Click(object sender, EventArgs e)
        {
            Models.Alamat newAlamat = GetalamatNew();
            alamatContext.Insert(newAlamat);
        }


        //string nama = txtNamaPetani.Text;
        //string username = txtUsernamePusat.Text;
        //string password = txtPassword.Text;
        //string NomorHp = txtHandphonePusat.Text;
        //string Desa = cbdesa.SelectedItem.ToString();
        //string Jalan = txtJalan.Text;
        //string Kecamatan = cbKec.SelectedItem.ToString();
        //string KonfirPassword = txtKonfirmasiPasword.Text;
        //string connect = $"Server=localhost;Username=postgres;Password=moluka;Database=ngupy;Port=5432;Pooling=True;";
        //string idalamat = $"select id_alamat from alamat where nama_jalan ilike '{Jalan}'";
        //string queryalamat = $"insert into alamat(nama_jalan,desa,kecamatan) values('{Jalan}','{Desa}','{Kecamatan}')";
        //string queryusername = $"select username from \"User\" where username like '{username}'";

        //NpgsqlConnection conn = new NpgsqlConnection(connect);

        //conn.Open();
        //NpgsqlCommand select_username = new NpgsqlCommand(queryusername, conn);
        //NpgsqlDataReader pick_uname = select_username.ExecuteReader();

        //if (pick_uname.Read())
        //{
        //    if (KonfirPassword == password)
        //    {
        //        string uname = pick_uname[0].ToString();
        //        conn.Close();
        //        if (username == uname)
        //        {
        //            MessageBox.Show($"Username sudah ada!");
        //        }
        //    }
        //}
        //else
        //{
        //    conn.Close();
        //    conn.Open();
        //    NpgsqlCommand insertalamat = new NpgsqlCommand(queryalamat, conn);
        //    insertalamat.ExecuteNonQuery();
        //    conn.Close();
        //    conn.Open();
        //    NpgsqlCommand ambilid = new NpgsqlCommand(idalamat, conn);
        //    NpgsqlDataReader reader = ambilid.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        int ID = reader.GetInt32(0);
        //        conn.Close();
        //        conn.Open();
        //        string queryuser = $"insert into \"User\"(nama,nomor_telepon,username,password,id_peran,id_alamat,id_kualitas_kopi) values ('{nama}','{NomorHp}','{username}','{password}','2',{ID},1)";
        //        NpgsqlCommand insertuser = new NpgsqlCommand(queryuser, conn);
        //        insertuser.Parameters.AddWithValue("desa_id_desa", ID);
        //        insertuser.ExecuteNonQuery();
        //        MessageBox.Show($"Data anda berhasil ditambahkan");
        //        this.Hide();
        //        LoginPetani lp = new LoginPetani();
        //        lp.ShowDialog();
        //    }


        //}

        private void DaftarPusat_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pusat.MasukPusat masukPusat = new Pusat.MasukPusat();
            masukPusat.Show();
        }
    }
    
}
