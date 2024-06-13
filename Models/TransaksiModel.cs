using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Tools;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace Ngupy_NgulakKopy.Models
{
    internal class TransaksiModel
    {
        private int id_transaksi {  get; set; }
        private DateTime tanggal_transaksi { get; set; }
        private int id_penjemputan {  get; set; }
        private int id_pembayaran { get; set; }
        private int id_gudang {  get; set; }
        private int id_user {  get; set; }
        

        public int id_t
        {
            get { return id_transaksi; }
            set { this.id_transaksi = value; }
        }
        public DateTime tanggal_t
        {
            get { return tanggal_transaksi; }
            set { this.tanggal_transaksi = value; }
        }
        public int ID_penjemputan
        {
            get { return id_penjemputan; }
            set { this.ID_penjemputan = value; }
        }
        public int ID_pembayaran
        {
            get { return id_pembayaran; }
            set { this.id_pembayaran = value; }
        }
        public int ID_gudang
        {
            get { return id_gudang; }
            set { this.ID_gudang = value;}
        }
        public int ID_user
        {
            get { return id_user; }
            set { this.ID_user = value;}
        }

        public void insert_transaksi(int id_penjemputan, int id_pembayaran, int id_user)
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"insert into transaksi (tanggal_transaksi,id_penjemputan,id_pembayaran,id_gudang,id_user,status) values (now(),@id_penjemputan,@id_pembayaran,1,@id_user,0)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_penjemputan", id_penjemputan);
                    cmd.Parameters.AddWithValue("id_pembayaran", id_pembayaran);
                    cmd.Parameters.AddWithValue("id_user", id_user);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Transaksi berhasil");
                }
            }
        }

        public DataTable readriwayat(int id_user)
        {
            DataTable dataTable = new DataTable();

            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"select p.id_penjualan, p.id_user,p.jumlah_kopi,h.harga,(h.harga*p.jumlah_kopi) as \"Total harga\" from \"Penjualan\" p join harga_kopi h on(h.id_harga=p.id_harga) join \"User\" u on(u.id_user=p.id_user)" +
                    $"join transaksi t on(u.id_user=t.id_user) where p.id_user = @id_user and t.status = 1";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_user", id_user);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
    }
}
