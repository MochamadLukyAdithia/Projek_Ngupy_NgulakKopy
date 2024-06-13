using Ngupy_NgulakKopy.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Ngupy_NgulakKopy.Models
{
    internal class Penjemputan
    {
        int id_penjemputan {  get; set; }
        int id_detail_penjemputan { get; set; }
        int  id_pegawai_penjemputan { get; set; }
        DateTime waktu_penjemputan { get; set; }
        string nama_pegawai { get; set; }
        string nomor_telepon { get; set; }
        private string koneksi = Connection.connect;

        public (string nama, string waktu_penjemputan, List<string> nama_pegawai)?  get_data_penjemputan(string username)
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                string select_data_penjemputan = $"select u.nama, TO_CHAR(p.waktu_penjemputan, 'dd/mm/yyy') as tanggal_penjemputan, pp.nama_pegawai from \"User\" u join penjemputan p on (p.id_user =  u.id_user) join detail_penjemputan dp on (p.id_penjemputan = dp.id_penjemputan) join pegawai_penjemputan pp on (pp.id_pegawai_penjemputan = dp.id_pegawai_penjemputan) where u.username = '{username}' order by p.waktu_penjemputan desc limit 4" +
                    $"";
                var cmd = new NpgsqlCommand(select_data_penjemputan, con);

                using (var reader = cmd.ExecuteReader()) 
                {
                    if (reader.HasRows)
                    {
                        string nama_user = null;
                        string waktu_penjemputan = null;
                        List<string> nama_pegawai_list = new List<string>();

                        while (reader.Read())
                        {
                            if (nama_user == null)
                            {
                                nama_user = reader.GetString(0);
                                waktu_penjemputan = reader.GetString(1);
                            }
                            nama_pegawai_list.Add(reader.GetString(2));
                        }

                        return (nama_user, waktu_penjemputan, nama_pegawai_list);
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
