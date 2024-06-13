using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class KualitasKopiContext
    {
        public List<KualitasKopi> KopiList = new List<KualitasKopi>();
        public bool Insert(KualitasKopi kualitas)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
            {
                string sql = $"INSERT INTO kualitas_kopi(harga_terbaru) VALUES(@harga_baru)";
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("harga_baru", kualitas.harga_terbaru));
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    this.KopiList.Add(kualitas);
                }
                con.Close();
            }

            return true;
        }
    }
}
