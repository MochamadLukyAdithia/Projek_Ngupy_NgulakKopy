using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Tools;

namespace Ngupy_NgulakKopy.Models
{
    public class Gudang
    {
        private int id_gudang { get; set; }
        private int kapasitas_gudang { get; set; }
        private int stok_kopi { get; set; }

        public void update_stok(int stok_kopi)
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query_update = $"update gudang set stok_kopi = @stok_kopi";
                var cmd = new NpgsqlCommand(query_update, conn);
                cmd.Parameters.AddWithValue("stok_kopi", stok_kopi);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public int get_stokkopi
        {
            get { return stok_kopi; }
            set { this.stok_kopi = value; }
        }

        public int Getstok_kopi()
        {
            int stok_kopi = 0;
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query_get = $"select stok_kopi from gudang";
                using (var cmd = new NpgsqlCommand(query_get, conn))
                {
                    stok_kopi = Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
            return stok_kopi;
        }

        public void updatestok(int stok_kopi)
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"update gudang set stok_kopi = @stok_kopi";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("stok_kopi", stok_kopi);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
