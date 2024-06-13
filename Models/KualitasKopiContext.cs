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
        public bool Insert(KualitasKopi newkualitasKopi)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
            {
                string sql = $"INSERT INTO kualitas_kopi(harga_terbaru) VALUES (@harga_terbaru)";
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("harga_terbaru", newkualitasKopi.harga_terbaru));
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    this.KopiList.Add(newkualitasKopi);
                }
                con.Close();
            }

            return true;
        }

        //public bool Insert(KualitasKopi newkualitasKopi)
        //{
        //    using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
        //    {
        //        string sql = $"INSERT INTO kualitas_kopi(kategori_kualitas_kopi, harga_kualitas, harga_terbaru) VALUES(@kategori_kualitas, @harga_baru, @harga_terbaru)";
        //        con.Open();
        //        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
        //        {
        //            cmd.Parameters.Add(new NpgsqlParameter("harga_baru", newkualitasKopi.harga_kualitas));
        //            cmd.Parameters.Add(new NpgsqlParameter("kategori_kualitas", newkualitasKopi.kategori_kualitas_kopi));
        //            cmd.Parameters.Add(new NpgsqlParameter("harga_terbaru", newkualitasKopi.harga_terbaru));
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.ExecuteNonQuery();
        //            this.KopiList.Add(newkualitasKopi);
        //        }
        //        con.Close();
        //    }

        //    return true;
        //} 


        public bool Update(KualitasKopi newkualitasKopi)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
            {
                string sql = $"UPDATE kualitas_kopi set harga_kualitas = @harga_baru, kategori_kualitas_kopi = @kategori_kualitas where id_kualitas_kopi =(SELECT MAX(id_kualitas_kopi) FROM kualitas_kopi)";
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("harga_baru", newkualitasKopi.harga_kualitas));
                    cmd.Parameters.Add(new NpgsqlParameter("kategori_kualitas", newkualitasKopi.kategori_kualitas_kopi));
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    this.KopiList.Add(newkualitasKopi);
                }
                con.Close();
            }

            return true;
        }


    }
}
