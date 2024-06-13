using Ngupy_NgulakKopy.Models;
using Ngupy_NgulakKopy.Tools;
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

namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    public partial class TransaksiPengpul : UserControl
    {


        private List<string> rekeningbaru = new List<string>();
        UpdateRekeningContext rekeninglist;

        private bool isButton9Clicked = false;

        private TransaksiPengepul transaksiPengepul;

        public TransaksiPengpul()
        {
            InitializeComponent();
            rekeninglist = new UpdateRekeningContext();
            transaksiPengepul = new TransaksiPengepul();

            RekPetaniDataGridView1.EnableHeadersVisualStyles = false;
            RekPetaniDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            RekPetaniDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RekPetaniDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            RekPetaniDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            RekPetaniDataGridView1.ColumnHeadersHeight = 30;
            RekPetaniDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RekPetaniDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            RekPetaniDataGridView1.RowHeadersWidth = 30;

            CashDataGridView.EnableHeadersVisualStyles = false;
            CashDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            CashDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CashDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CashDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CashDataGridView.ColumnHeadersHeight = 30;
            CashDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CashDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            CashDataGridView.RowHeadersWidth = 30;

        }

        private void TransaksiPengpul_Load(object sender, EventArgs e)
        {
            DisplayHargaPetani();
            DisplayKualitasKopi();
            DisplayNoRekening();
            DisplayTabel();
            RekPetaniDataGridView1.BringToFront();
           

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //private void GetTanggal()
        //{
        //    DateTime today = DateTime.Now;
        //    string formattedDate = today.ToString("MM/dd/yyyy");
        //    labelTanggal1.Text = $"{formattedDate}";
        //}


        private Models.UpdateRekening GetRekeningNew()
        {
            Models.UpdateRekening rekening = new Models.UpdateRekening();
            rekening.nomor_rekening = guna2TextBox3.Text;
            return rekening;

        }


        public List<string> GetDataList()
        {
            return rekeningbaru;

        }








        public void DisplayHargaPetani()
        {
            DateTime dt = DateTime.Now;
            labelTanggal1.Text = dt.ToString("dd/MM/yyyy");

            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT harga_kualitas from kualitas_kopi order by id_kualitas_kopi desc limit 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int hargaKualitas = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            if (hargaKualitas > 0)
                            {
                                lblhrgterbaru.Text = hargaKualitas.ToString();
                                lblhrgterbaru.Visible = true;
                            }
                            else
                            {
                                lblhrgterbaru.Text = string.Empty;
                                lblhrgterbaru.Visible = false;
                            }
                        }
                    }
                }
            }
        }


        public void DisplayKualitasKopi()
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("select kategori_kualitas_kopi FROM kualitas_kopi order by id_kualitas_kopi desc limit 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string kualitasKopi = reader.IsDBNull(0) ? null : reader.GetString(0);
                            if (kualitasKopi != null)
                            {
                                kualitaslabel.Text = kualitasKopi;
                                kualitaslabel.Visible = true;
                            }
                            else
                            {
                                kualitaslabel.Text = string.Empty;
                                kualitaslabel.Visible = false;
                            }
                        }
                    }
                }
            }
        }



        public void DisplayTabel()
        {
            transaksiPengepul.ReadRekeningPetani();
            RekPetaniDataGridView1.DataSource = transaksiPengepul.ReadRekeningPetani();

            transaksiPengepul.ReadCashPetani();
            CashDataGridView.DataSource = transaksiPengepul.ReadCashPetani();
        }

        public void DisplayNoRekening()
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT nomor_rekening from \"User\" WHERE \"User\".id_peran = 2", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblRekening.Text = $"{reader.GetString(0)}";
                        }
                        conn.Close();
                    }
                }
            }
        }



        private void lblhrgterbaru_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlTransaksi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

            RekeningBttn.BringToFront();
            RekeningBttn.FillColor = Color.FromArgb(255, 218, 154);
            TempatBttn.FillColor = Color.FromArgb(255, 255, 255);
            RekPetaniDataGridView1.BringToFront();

            isButton9Clicked = false;

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

            TempatBttn.BringToFront();
            TempatBttn.FillColor = Color.FromArgb(255, 218, 154);
            RekeningBttn.FillColor = Color.FromArgb(255, 255, 255);
            CashDataGridView.BringToFront();

            isButton9Clicked = true;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void KonfirButton_Click(object sender, EventArgs e)
        {
            Models.UpdateRekening rekening = GetRekeningNew();
            rekeninglist.Insert(rekening);
            MessageBox.Show("Rekening Berhasil di Update", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Question);
            DisplayNoRekening();
            DisplayHargaPetani();
            DisplayKualitasKopi();
            BerandaPengepul berandaPengepul = new BerandaPengepul();
        }

        private void lblhrgterbaru_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint_1(object sender, PaintEventArgs e)
        {
            DisplayHargaPetani();
            DisplayKualitasKopi();

        }

        private void lblRekening_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (isButton9Clicked)
            {
                updateCash();
            }
            else
            {
                updateDebit();
            }
            DisplayTabel();
        }


        private void updateCash()
        {
            if (CashDataGridView.SelectedRows.Count > 0)
            {
                int id_user = Convert.ToInt32(CashDataGridView.SelectedRows[0].Cells["id_user"].Value);
                transaksiPengepul.UpdateCash(id_user, 1);
                MessageBox.Show("Status transaksi berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pilih ID User terlebih dahulu");
            }
        }


        private void updateDebit()
        {
            {
                if (RekPetaniDataGridView1.SelectedRows.Count > 0)
                {
                    int id_transaksi = Convert.ToInt32(RekPetaniDataGridView1.SelectedRows[0].Cells["id_transaksi"].Value);
                    transaksiPengepul.UpdateTransaksiStatus(id_transaksi, 1);
                    MessageBox.Show("Status transaksi berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pilih ID transaksi terlebih dahulu");
                }
                
            }
        }


        private void panelDitempat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDitempat_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void guna2HtmlLabel1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void RekPetaniDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
