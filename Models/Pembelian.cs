using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ngupy_NgulakKopy.Tools;
using Npgsql;

namespace Ngupy_NgulakKopy.Models
{
    internal class Pembelian
    {
        public int id_pembelian { get; set; }
        public DateTime tanggal_transaksi { get; set; }
        public int id_penjemputan { get; set; }
        public int id_user {  get; set; }

        public void tambah_pembelian(int id_penjemputan, int id_user)
        {
            using(var conn = new NpgsqlConnection(Connection.connect))
            
            {
                var cmd = new NpgsqlCommand($"insert into pembelian (tanggal_transaksi,id_penjemputan,id_user) values (date.now(),@id_penjemputan,@id_user)", conn);
                cmd.Parameters.AddWithValue("id_penjemputan", id_penjemputan);
                cmd.Parameters.AddWithValue("id_user", id_user);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataGridView read_pembelian()
        {
            DataGridView pembelianview = new DataGridView();
            using(var conn = new NpgsqlConnection(Connection.connect))
            {
                using (var cmd = new NpgsqlCommand($"select * from pembelian", conn))
                {
                    using(var reader = cmd.ExecuteReader())
                    {
                       /* pembelianview.Load(reader);*/
                    }
                }
                
            }
            return pembelianview;
        }

    }
}
