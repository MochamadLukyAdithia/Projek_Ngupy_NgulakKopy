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
        private int id_detail_penjemputan {  get; set; }
        private string keterangan { get; set; }
        private int id_pegawai { get; set; }
        private int id_penjemputan { get; set; }

        public string NamapegawaiById(int id_user)
        {
            string nama_pegawai = "";
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query_id = $"select pp.nama_pegawai from pegawai_penjemputan pp join detail_penjemputan dp on(pp.id_pegawai_penjemputan=dp.id_pegawai_penjemputan) join penjemputan p on(p.id_penjemputan=dp.id_penjemputan) \r\nwhere p.id_user = @id_user and p.status = 1 order by dp.id_detail_penjemputan desc limit 1";
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
