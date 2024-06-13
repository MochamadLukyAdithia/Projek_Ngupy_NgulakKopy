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
using Ngupy_NgulakKopy.Controllers;
using Ngupy_NgulakKopy.Tools;
using Guna.UI2.AnimatorNS;

namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class BerandaPetani : UserControl

    {
        private string username = LoginPetani.username;
        private AkunControllers akunController;
        private KualitasKopiControllers kualitaskopicontroller;
        private HargaKopiControllers hargakopicontrollers;
        private GudangControllers gudangcontroller;
        private PenjemputanControllers penjemputancontroller;

        public BerandaPetani()
        {
            InitializeComponent();
            kualitaskopicontroller = new KualitasKopiControllers();
            hargakopicontrollers = new HargaKopiControllers();
            gudangcontroller = new GudangControllers();
            penjemputancontroller = new PenjemputanControllers();

        }

        public void SetUsername(string username)
        {
            this.username = username;
            readDashboard(username);
        }

        private void BerandaPetani_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                //string username = akunController.username_now;
                //readDashboard(username);
            }
        }

        private void BerandaPetani_Load(object sender, EventArgs e)
        {
            //string username = akunController.username_now;
            //readDashboard(username);
            readDashboard(username);

        }

        public void readDashboard(string username)
        {
            string database = Connection.connect;

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(database))
                {
                    conn.Open();
                    string selectnow = $"SELECT TO_CHAR(CURRENT_DATE, 'dd/mm/yyyy')";
                    NpgsqlCommand select_cd = new NpgsqlCommand(selectnow, conn);
                    using (NpgsqlDataReader cd = select_cd.ExecuteReader())
                    {
                        cd.Read();
                        lblTanggal.Text = cd[0].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            try
            {
                var result = kualitaskopicontroller.select_kualitas_kopi(username);
                if (result.HasValue)
                {
                    lblharga.Text = $"Rp. {result.Value.harga}";
                    lblkualitas.Text = result.Value.kategori;
                    lblketerangan.Text = result.Value.keterangan;
                }
                else
                {
                    label1.Text = "-";
                    label2.Text = "-";
                    label3.Text = "-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            try
            {
                int harga_update = hargakopicontrollers.get_harga_terbaru() ?? 0;
                lblhargaterbaru.Text = $"Rp. {harga_update}/kg";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            try
            {
                lblkapasitas.Text = gudangcontroller.get_stok() + "Kg / 50 Ton";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            try
            {
                var result = penjemputancontroller.get_data_penjemputan(username);
                if (result.HasValue)
                {
                    lblusername.Text = result.Value.nama;
                    lbltglpenjemputan.Text = result.Value.waktu_penjemputan;
                    lblkaryawan.Text = string.Join(", ", result.Value.nama_pegawai);
                }
                else
                {
                    lblusername.Text = username;
                    DateTime dt = DateTime.Now;
                    lbltglpenjemputan.Text = dt.ToString("dd/MM/yyyy");
                    lblkaryawan.Text = "Belum ada request penjemputan";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //try
            //{
            //    using (NpgsqlConnection conn = new NpgsqlConnection(database))
            //    {
            //        conn.Open();
            //        string select_harga_kualitas = $"SELECT Harga_Kualitas || '/kg' From Kualitas_Kopi kp join \"User\" u on (kp.id_kualitas_kopi = u.id_kualitas_kopi) Where u.username ilike '{username}'";
            //        NpgsqlCommand select_cd = new NpgsqlCommand(select_harga_kualitas, conn);
            //        using (NpgsqlDataReader cd = select_cd.ExecuteReader())
            //        {
            //            if (cd.Read()) { lblharga.Text = $"Rp. {cd[0].ToString()}"; }
            //            else { MessageBox.Show($"Error: error bang"); }
            //        }

            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}

            //try
            //{
            //    using (NpgsqlConnection conn = new NpgsqlConnection(database))
            //    {
            //        conn.Open();
            //        string select_harga = $"SELECT harga || '/kg' FROM harga_kopi order by update_at desc limit 1";
            //        NpgsqlCommand select_cd = new NpgsqlCommand(select_harga, conn);
            //        using (NpgsqlDataReader cd = select_cd.ExecuteReader())
            //        {
            //            if (cd.Read()) { lblhargaterbaru.Text = $"Rp. {cd[0].ToString()}"; }
            //            else { MessageBox.Show($"Error: error bang"); }
            //        }

            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}

            //try
            //{
            //    using (NpgsqlConnection conn = new NpgsqlConnection(database))
            //    {
            //        conn.Open();
            //        string select_kualitas = $"SELECT Kategori_Kualitas_Kopi, Keterangan From Kualitas_Kopi kp join \"User\" u on (kp.id_kualitas_kopi = u.id_kualitas_kopi) Where u.username ilike '{username}'";
            //        NpgsqlCommand select_cd = new NpgsqlCommand(select_kualitas, conn);
            //        using (NpgsqlDataReader cd = select_cd.ExecuteReader())
            //        {
            //            if (cd.Read())
            //            {
            //                lblkualitas.Text = cd[0].ToString();
            //                lblketerangan.Text = cd["Keterangan"] != DBNull.Value ? cd["Keterangan"].ToString() : "-";
            //            }
            //            else { MessageBox.Show($"Error: error bang"); }
            //        }

            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}

            //try
            //{
            //    using (NpgsqlConnection conn = new NpgsqlConnection(database))
            //    {
            //        conn.Open();
            //        string select_kapasitas = $"SELECT Stok_Kopi || ' kg / ' || Kapasitas_Gudang || ' kg'  From Gudang";
            //        NpgsqlCommand select_cd = new NpgsqlCommand(select_kapasitas, conn);
            //        using (NpgsqlDataReader cd = select_cd.ExecuteReader())
            //        {
            //            if (cd.Read())
            //            {
            //                lblkapasitas.Text = cd[0].ToString();
            //            }
            //            else { MessageBox.Show($"Error: error bang"); }
            //        }

            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}

            //try
            //{
            //    using (NpgsqlConnection conn = new NpgsqlConnection(database))
            //    {
            //        conn.Open();
            //        string select_penjemputan = $"select u.nama, TO_CHAR(p.waktu_penjemputan, 'dd/mm/yyy') as tanggal_penjemputan, pp.nama_pegawai from \\\"User\\\" u join penjemputan p on (p.id_user =  t.id_user) join detail_penjemputan dp on (p.id_penjemputan = dp.id_penjemputan) join pegawai_penjemputan pp on (pp.id_pegawai_penjemputan = dp.id_pegawai_penjemputan) where u.username = '{{username}}' order by p.waktu_penjemputan desc limit 1";

            //        NpgsqlCommand select_cd = new NpgsqlCommand(select_penjemputan, conn);
            //        using (NpgsqlDataReader cd = select_cd.ExecuteReader())
            //        {
            //            if (cd.Read())
            //            {
            //                lblusername.Text = cd[0].ToString();
            //                lbltglpenjemputan.Text = cd[1].ToString();
            //                lblkaryawan.Text = cd[2].ToString();
            //            }
            //            else 
            //            {
            //                lblusername.Text = username;
            //                DateTime dt = DateTime.Now;
            //                lbltglpenjemputan.Text = dt.ToString("dd/MM/yyyy");
            //                lblkaryawan.Text = "Belum ada request penjemputan";
            //            }
            //        }

            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}
        }

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

