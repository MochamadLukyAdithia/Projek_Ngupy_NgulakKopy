using Ngupy_NgulakKopy.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Npgsql; 

namespace Ngupy_NgulakKopy.Models
{
    internal class HargaKopi
    {
        public int id_harga_kopi {  get; set; }
        public string update_at { get; set; }
        public int harga {  get; set; }

        private string koneksi = Connection.connect;

        public int? get_harga_terbaru()
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                string query_select = $"select harga from harga_kopi order by id_harga desc limit 1";
                var cmd = new NpgsqlCommand(query_select, con);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int harga = reader.GetInt32(0);
                        return harga;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

           
        }
        
        public int getID_hargaterbaru()
        {
            int id_harga = 0;
            using(var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"select id_harga from harga_kopi order by id_harga desc limit 1";
                var cmd = new NpgsqlCommand(query,conn);
                using(NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_harga = reader.GetInt32(0);
                    }
                }
            }
            return id_harga;
        }

    }
}
