using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class HargaKopiContext
    {
       public List<HargaKopi> listHargaKopi = new List<HargaKopi>();
        public bool Insert(HargaKopi newHargaKopi)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
            {
                string sql = $"INSERT INTO harga_kopi(update_at,harga) VALUES(current_timestamp,@harga)";
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("harga", newHargaKopi.harga));
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    this.listHargaKopi.Add(newHargaKopi);
                }
                con.Close();
            }

            return true;
        }
    }
}
