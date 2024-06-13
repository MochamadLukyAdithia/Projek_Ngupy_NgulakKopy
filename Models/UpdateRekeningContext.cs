using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class UpdateRekeningContext
    {
        public List<UpdateRekening> rekeninglist= new List<UpdateRekening>();
        public bool Insert(UpdateRekening newrekening)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
            {
                string sql = $"UPDATE \"User\" SET nomor_rekening = @nomor_rekening_baru where id_peran = 2";
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("nomor_rekening_baru", newrekening.nomor_rekening));
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    this.rekeninglist.Add(newrekening);
                }
                con.Close();
            }

            return true;
        }
    }
}
