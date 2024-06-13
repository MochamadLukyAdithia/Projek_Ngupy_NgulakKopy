using Ngupy_NgulakKopy.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Ngupy_NgulakKopy.Controllers;

namespace Ngupy_NgulakKopy.Models
{
    internal class KualitasKopi
    {
        public int id_kualitasid_kualitas_kopi { get; set; }
        public string kategori_kualitas_kopi { get; set; }
        public int harga_kualitas { get; set; }
        public string keterangan { get; set; }
        public string harga_terbaru { get; set; }

        private string koneksi = Connection.connect;

        private HargaKopiControllers hargakopicontrollers;

        public KualitasKopi()
        {
            hargakopicontrollers = new HargaKopiControllers();
        }

        public int? insert_kualitas_baru()
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                int harga_update = hargakopicontrollers.get_harga_terbaru() ?? 0;
                string query_insert = $"INSERT INTO Kualitas_Kopi (kategori_kualitas_kopi, harga_kualitas) VALUES ('Baik', {harga_update}) RETURNING ID_Kualitas_Kopi"; 
                var cmd = new NpgsqlCommand(query_insert, con);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int ID_kualitas = reader.GetInt32(0);
                        return ID_kualitas;
                    }
                    else
                    {
                        return null;
                    }
                }

            }
        }

        public (string kategori_kualitas,string keterangan, string harga_kualitas)? select_kualitas_kopi(string username)
        {
            using (var con = new NpgsqlConnection(koneksi)) 
            {
                con.Open();
                string select_kualitas = $"SELECT Harga_Kualitas || '/kg', Kategori_Kualitas_Kopi, Keterangan From Kualitas_Kopi kp join \"User\" u on (kp.id_kualitas_kopi = u.id_kualitas_kopi) Where u.username ilike '{username}'";
                var cmd = new NpgsqlCommand(select_kualitas, con);
                using (var reader = cmd.ExecuteReader()) 
                { 
                    if (reader.Read()) 
                    { 
                        string harga_kualitas = reader.GetString(0);
                        string kategori_kualitas = reader.GetString(1);
                        string keterangan = reader.IsDBNull(2) ? "-" : reader.GetString(2);
                        return (harga_kualitas, kategori_kualitas, keterangan);
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
