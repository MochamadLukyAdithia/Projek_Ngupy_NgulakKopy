using Ngupy_NgulakKopy.Tools;
using Ngupy_NgulakKopy.Views.Petani;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class User
    {
        private string nama { get; set; }
        private string nomor_telepon { get; set; }
        private string nomor_rekening { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private int id_user {  get; set; }
        private int id_peran { get; set; }
        private int id_alamat { get; set; }
        private int id_kualitas_kopi { get; set; }

        public int GetId
        {
            get { return id_user; }
            set { id_user = value; }
        }
        public string Getnama
        {
            get { return nama; }
            set { nama = value;}
        }

        public List<User> ReadUser()
        {
            List<User> listUser = new List<User>();
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"select * from \"User\" ";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.id_user = reader.GetInt32(0);
                        user.nama = reader.GetString(1);
                        user.nomor_telepon = reader.GetString(2);
                        user.nomor_rekening = reader.GetString(3);
                        user.username = reader.GetString(4);
                        user.password = reader.GetString(5);
                        user.id_peran = reader.GetInt32(6);
                        user.id_alamat = reader.GetInt32(7);
                        user.id_kualitas_kopi = reader.GetInt32(8);
                    }
                }
            }
            return listUser;
        }

        public int GetIdbyUsername(string username)
        {
            int id_user = 0;
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query_id = $"select id_user from \"User\" where username = @username";
                using (var cmd = new NpgsqlCommand(query_id, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_user = reader.GetInt32(0);
                        }
                        
                    }


                }
            }
            return id_user;
        }

        public string GetnamaByusername(string username)
        {
            string nama = null;
            using(var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query_nama = $"select nama from \"User\" where username = @username";
                using(var cmd = new NpgsqlCommand(query_nama, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nama = reader.GetString(0);
                        }
                    }
                }
            }
            return nama;
        }
    }
}
