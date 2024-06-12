using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Tools;
using System.Data;
namespace Ngupy_NgulakKopy.Models
{
    internal class DetailPenjemputan
    {
        public int id_detail_penjemputan {  get; set; }
        public string keterangan { get; set; }
        public int id_pegawai { get; set; }
        public int id_penjemputan { get; set; }

        public string NamapegawaiById(int id_user)
        {
            string nama_pegawai = null;
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query_id = $"select pp.nama_pegawai from detail_penjemputan dp join pegawai_penjemputan pp on(pp.id_pegawai_penjemputan=dp.id_pegawai_penjemputan) join penjemputan p on(p.id_penjemputan=dp.id_penjemputan) where p.id_user = @id_user";
                using (var cmd = new NpgsqlCommand(query_id, conn))
                {
                    cmd.Parameters.AddWithValue("id_user", id_user);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nama_pegawai = reader.GetString(0);
                        }
                      
                    }
                }
            }
            return nama_pegawai;
        }
    }
}
