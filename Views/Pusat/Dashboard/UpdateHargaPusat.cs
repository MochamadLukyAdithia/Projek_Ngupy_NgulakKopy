using Ngupy_NgulakKopy.Models;
using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pusat.Dashboard
{
    public partial class UpdateHargaPusat : UserControl

    {
        //public static UpdateHargaPusat instance;
        private List<string> dataharga = new List<string>();
        HargaKopiContext listHargaKopi;
        public UpdateHargaPusat()
        {
            InitializeComponent();
            listHargaKopi = new HargaKopiContext();
            //instance = this;


        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Models.HargaKopi hargaKopi = GethargaNew();
            listHargaKopi.Insert(hargaKopi);
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Question);
            DisplayLatestPrice();
            DisplayLatestPricet();
            BerandaPusat berandaPusat = new BerandaPusat();
            

        }
        private Models.HargaKopi GethargaNew()
        {
            Models.HargaKopi hargaKopi = new Models.HargaKopi();
            hargaKopi.harga = int.Parse(txthargaPusat.Text);
            return hargaKopi;
        }
        //private void btnSaveInput_Click(object sender, EventArgs e)
        //{
        //    string inputData = txthargaPusat.Text;
        //    dataharga.Add(inputData);
        //    txthargaPusat.Clear();
        //}

        //private void btnOpenForm2_Click(object sender, EventArgs e)
        //{
        //    Form2 form2 = new Form2(this);
        //    form2.ShowDialog();
        //}

        public List<string> GetDataList()
        {
            return dataharga;
        }


        private void UpdateHargaPusat_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbltgl.Text = dt.ToString("dd/MM/yyyy");
            DisplayLatestPricet();
            DisplayLatestPricelbl2();
        }

        private void label11_Click(object sender, EventArgs e)
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
                            lblhrgterbaru.Text = $"{reader.GetInt32(0)}";
                        }
                        conn.Close();
                    }
                }
            }
        }
        public void DisplayLatestPricelbl2()
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
                            using (var lbl2 = new BerandaPusat())
                                lbl2.label2.Text = $"{reader.GetInt32(0)}";
                        }
                        conn.Close();
                    }
                }
            }
        }
        public void DisplayLatestPricet()
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
                            label10.Text = $"{reader.GetInt32(0)}";
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
