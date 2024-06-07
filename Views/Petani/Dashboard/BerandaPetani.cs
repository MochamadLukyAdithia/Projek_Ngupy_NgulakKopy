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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class BerandaPetani : UserControl
    {
        public BerandaPetani()
        {
            InitializeComponent();
            this.VisibleChanged += BerandaPetani_VisibleChanged;
        }

        private void BerandaPetani_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                /*readDashboard(); */// Call readDashboard() when the UserControl becomes visible
            }
        }

        private void BerandaPetani_Load(object sender, EventArgs e)
        {

        }

        //private void readDashboard()
        //{
        //    lblusername.Text = LoginPetani.username;
        //    string database = "Host=localhost;Username=postgres;Password=c4peKBgt!;Database=Ngupy;Port=5432;Pooling=True";

        //    try
        //    {
        //        using (NpgsqlConnection conn = new NpgsqlConnection(database))
        //        {
        //            conn.Open();
        //            string selectnow = $"SELECT TO_CHAR(CURRENT_DATE, 'dd/mm/yyyy')";
        //            NpgsqlCommand select_cd = new NpgsqlCommand(selectnow, conn);
        //            using (NpgsqlDataReader cd = select_cd.ExecuteReader())
        //            {
        //                cd.Read();
        //                lblTanggal.Text = cd[0].ToString();
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }

        //    try
        //    {
        //        using (NpgsqlConnection conn = new NpgsqlConnection(database))
        //        {
        //            conn.Open();
        //            string select_harga = $"SELECT Harga From Kualitas_Kopi kp join \"User\" u on (kp.id_kualitas_kopi = u.id_kualitas_kopi) Where u.username ilike '{LoginPetani.username}'";
        //            NpgsqlCommand select_cd = new NpgsqlCommand(select_harga, conn);
        //            using (NpgsqlDataReader cd = select_cd.ExecuteReader())
        //            {
        //                if (cd.Read()) { lblharga.Text = $"Rp. {cd[0].ToString()}"; }
        //                else { MessageBox.Show($"Error: error bang");  }
        //            }

        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }

        //    try
        //    {
        //        using (NpgsqlConnection conn = new NpgsqlConnection(database))
        //        {
        //            conn.Open();
        //            string select_kualitas = $"SELECT Kategori_Kualitas_Kopi, Keterangan From Kualitas_Kopi kp join \"User\" u on (kp.id_kualitas_kopi = u.id_kualitas_kopi) Where u.username ilike '{LoginPetani.username}'";
        //            NpgsqlCommand select_cd = new NpgsqlCommand(select_kualitas, conn);
        //            using (NpgsqlDataReader cd = select_cd.ExecuteReader())
        //            {
        //                if (cd.Read()) 
        //                {
        //                    lblkualitas.Text = cd[0].ToString();
        //                    lblketerangan.Text = cd["Keterangan"] != DBNull.Value ? cd["Keterangan"].ToString() : "-";
        //                }
        //                else { MessageBox.Show($"Error: error bang"); }
        //            }

        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }

        //    try
        //    {
        //        using (NpgsqlConnection conn = new NpgsqlConnection(database))
        //        {
        //            conn.Open();
        //            string select_kapasitas = $"SELECT Stok_Kopi || ' kg / ' || Kapasitas_Gudang || ' kg'  From Gudang";
        //            NpgsqlCommand select_cd = new NpgsqlCommand(select_kapasitas, conn);
        //            using (NpgsqlDataReader cd = select_cd.ExecuteReader())
        //            {
        //                if (cd.Read())
        //                {
        //                    lblkapasitas.Text = cd[0].ToString();
        //                }
        //                else { MessageBox.Show($"Error: error bang"); }
        //            }

        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }

        //    try
        //    {
        //        using (NpgsqlConnection conn = new NpgsqlConnection(database))
        //        {
        //            conn.Open();
        //            string select_penjemputan = $"select u.nama, TO_CHAR(p.waktu_penjemputan, 'dd/mm/yyy') as tanggal_penjemputan, pp.nama_pegawai from \"User\" u join Transaksi t on (u.id_user = t.id_user) join penjemputan p on (p.id_penjemputan =  t.id_penjemputan) join detail_penjemputan dp on (p.id_penjemputan = dp.id_penjemputan) join pegawai_penjemputan pp on (pp.id_pegawai_penjemputan = dp.id_pegawai_penjemputan) where u.username = '{LoginPetani.username}' order by p.waktu_penjemputan limit 1";

        //            NpgsqlCommand select_cd = new NpgsqlCommand(select_penjemputan, conn);
        //            using (NpgsqlDataReader cd = select_cd.ExecuteReader())
        //            {
        //                if (cd.Read())
        //                {
        //                    lblusername.Text = cd[0].ToString();
        //                    lbltglpenjemputan.Text = cd[1].ToString();
        //                    lblkaryawan.Text = cd[2].ToString();
        //                }
        //                else { MessageBox.Show($"Error: error bang"); }
        //            }

        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BerandaPetani_Load_1(object sender, EventArgs e)
        {

        }

        //private void guna2Button6_Click(object sender, EventArgs e)
        //{

        //}

        //private void lblusername_Click(object sender, EventArgs e)
        //{

        //}
    }
}

