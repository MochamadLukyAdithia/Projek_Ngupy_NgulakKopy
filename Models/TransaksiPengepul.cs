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
    internal class TransaksiPengepul
    {
        public DataTable ReadRekeningPetani()
        {
            DataTable table_rekening = new DataTable();
            using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
            {
                string sql = "select t.id_transaksi, u.nomor_rekening, t.tanggal_transaksi from \"User\" u join transaksi t ON (u.id_user = t.id_user) where u.id_peran = 1 and t.status = 0 and t.id_pembayaran = 2 \r\norder by t.tanggal_transaksi asc";
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            table_rekening.Load(reader);
                        }
                    }
                }
            }
            return table_rekening;
        }

        public DataTable ReadCashPetani()
        {
            DataTable table_cash = new DataTable();
            using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
            {
                string sql = "select u.id_user, u.nama, t.tanggal_transaksi from \"User\" u join transaksi t ON (u.id_user = t.id_user) where u.id_peran = 1 and t.status = 0 and t.id_pembayaran = 1 order by t.tanggal_transaksi asc\r\n";
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            table_cash.Load(reader);
                        }
                    }
                }
            }
            return table_cash;
        }


        public void UpdateTransaksiStatus(int id_transaksi, int newStatus)
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE transaksi SET status = @status WHERE id_transaksi = @id_transaksi", conn))
                {
                    cmd.Parameters.AddWithValue("status", newStatus);
                    cmd.Parameters.AddWithValue("id_transaksi", id_transaksi);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }


        }

        public void UpdateCash(int id_user, int newstatus)
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE transaksi SET status = @status WHERE id_user = @id_user", conn))
                {
                    cmd.Parameters.AddWithValue("status", newstatus);
                    cmd.Parameters.AddWithValue("id_user", id_user);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    
                }

            }
        }



    }
}
