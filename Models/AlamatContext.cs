using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class AlamatContext
    {
        public List<Alamat> listalamat = new List<Alamat>();
        public bool Insert(Alamat alamat)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
            {
                string sql = $"insert into alamat(nama_jalan,desa,kecamatan) values(@jalan, @desa, @kecamatan)";
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("jalan", alamat.jalan));
                    cmd.Parameters.Add(new NpgsqlParameter("desa", alamat.desa));
                    cmd.Parameters.Add(new NpgsqlParameter("kecamatan", alamat.kecamatan));
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    this.listalamat.Add(alamat);
                }
                con.Close();
            }

            return true;
        }
    }
    
}
