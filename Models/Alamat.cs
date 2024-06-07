using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class Alamat
    {
        public int id_alamat { get; set; }
        public string jalan { get; set; }
        public string desa { get; set; }
        public string kecamatan { get; set; }

        private string koneksi = "Host=localhost;Username=postgres;Password=c4peKBgt!;Database=Ngupy";

        public int? insert_alamat(string jalan, string desa, string kecamatan)
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                var cmd = new NpgsqlCommand($"INSERT INTO Alamat (nama_jalan, desa, kecamatan) VALUES ('{jalan}', '{desa}', '{kecamatan}') RETURNING Id_Alamat", con);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Mendapatkan username dan password dari reader
                        int ID_alamat = reader.GetInt32(0);
                        return ID_alamat;
                    }
                    else
                    {
                        // jika ga ada username yang sama
                        return null;
                    }
                }
            }
        }
    }
}
