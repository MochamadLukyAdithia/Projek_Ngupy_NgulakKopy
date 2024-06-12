using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Models
{
    
    internal class TransaksiContext
    {
        private TransaksiModel transaksi;
        public DataTable dataTable = new DataTable();

        public TransaksiContext()
        {
            transaksi = new TransaksiModel();
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

        public void readriwayat()
        {
          
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"select id_transaksi, tanggal_transaksi, id_penjemputan, id_pembayaran, id_user from transaksi";
                var cmd = new NpgsqlCommand(query, conn);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataTable.Load(reader);
                    }
                }
            }
        }

    }
}
