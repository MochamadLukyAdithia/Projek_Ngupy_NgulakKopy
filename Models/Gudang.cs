using Ngupy_NgulakKopy.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Ngupy_NgulakKopy.Models
{
    internal class Gudang
    {
        public int id_gudang { get; set; }
        public int kapasitas_kopi { get; set; }
        public int stok_kopi { get; set; }

        private string koneksi = Connection.connect;

        public string get_data_gudang()
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                string select_gudang = $"SELECT Stok_Kopi || ' kg / ' || Kapasitas_Gudang || ' kg'  From Gudang";
                var cmd = new NpgsqlCommand(select_gudang, con);
                using (var reader = cmd.ExecuteReader()) 
                {
                    if (reader.Read())
                    {
                        string data_gudang = reader.GetString(0);
                        return data_gudang;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
