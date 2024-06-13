using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class PembelianContext
    {
        

        //public bool Insert(Pembelian newPembelian)
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(Connection.connect))
        //        {
        //            conn.Open();

        //            // Get the latest transaksi
        //            DateTime tanggal_transaksi;
        //            using (var cmd = new NpgsqlCommand("SELECT tanggal_transaksi FROM transaksi ORDER BY id_transaksi DESC LIMIT 1", conn))
        //            {
        //                tanggal_transaksi = (DateTime)cmd.ExecuteScalar();
        //            }

        //            // Insert new Penjualan
        //            string sql = "INSERT INTO \"Penjualan\" (jumlah_kopi, id_user, id_harga) VALUES (@jumlah_kopi, @id_user, @id_harga)";
        //            using (var cmd = new NpgsqlCommand(sql, conn))
        //            {
        //                cmd.Parameters.AddWithValue("jumlah_kopi", newPenjualan.jumlah_kopi);
        //                cmd.Parameters.AddWithValue("id_user", newPenjualan.id_user);
        //                cmd.Parameters.AddWithValue("id_harga", id_harga);

        //                cmd.ExecuteNonQuery();
        //            }

        //            this.listPenjualan.Add(newPenjualan);
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log exception or handle accordingly
        //        Console.WriteLine($"Error: {ex.Message}");
        //        return false;
        //    }
        //}


        public DataTable ReadPembelian()
        {
           DataTable table_pembelian = new DataTable();
                using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
                {
                    string sql = "select pp.id_pegawai_penjemputan, pp.nama_pegawai , p.waktu_penjemputan , t.tanggal_transaksi ,t.jumlah_kopi, pm.metode_pembayaran  from pegawai_penjemputan pp join detail_penjemputan dp on(pp.id_pegawai_penjemputan=dp.id_pegawai_penjemputan) join penjemputan p on (dp.id_penjemputan=p.id_penjemputan) join transaksi t on (p.id_penjemputan=t.id_penjemputan) join pembayaran pm on (t.id_pembayaran=pm.id_pembayaran) where t.status = 1 order by t.tanggal_transaksi desc\r\n";
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {  
                                table_pembelian.Load(reader);                         
                            }
                        }
                    }
                }
            return table_pembelian; 
           
        }
    }
}
