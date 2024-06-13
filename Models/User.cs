using Ngupy_NgulakKopy.Views.Petani;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ngupy_NgulakKopy.Tools;

namespace Ngupy_NgulakKopy.Models
{
    internal class User
    {
        public string nama { get; set; }
        public string nomor_telepon { get; set; }
        public string nomor_rekening { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int id_user {  get; set; }
        public int id_peran { get; set; }
        public int id_alamat { get; set; }
        public int id_kualitas_kopi { get; set; }


        private string koneksi = Connection.connect;

        public (string username, string password)? login(int id_peran)
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                var select_login = new NpgsqlCommand($"SELECT Username, Password FROM \"User\" Where Username ilike '{this.username}' and id_peran = {id_peran}", con);
                using (var reader = select_login.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Mendapatkan username dan password dari reader
                        string Username = reader.GetString(0);
                        string Password = reader.GetString(1);
                        return (Username, Password);
                    }
                    else
                    {
                        // jika ga ada username yang sama
                        return null;
                    }
                }
            }
        }


        public bool Cek_Username(string username)
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                var cek_username = new NpgsqlCommand($"SELECT Username From \"User\" Where Username = '{username}'", con);
                using (var reader = cek_username.ExecuteReader())
                {
                    return reader.HasRows;
                }

            }
        }

        public void Daftar(string nama, string nomor_telepon, string username, string password, int id_peran, int id_alamat)
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                var insert_user = new NpgsqlCommand($"INSERT INTO \"User\" (nama,nomor_telepon,username,password,id_peran,id_alamat) VALUES ('{nama}', '{nomor_telepon}', '{username}', '{password}', {id_peran}, {id_alamat})", con);
                insert_user.ExecuteNonQuery();
            }
        }        
        public void Daftar_Petani(string nama, string nomor_telepon, string username, string password, int id_peran, int id_alamat, int id_kualitas_kopi )
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                var insert_user = new NpgsqlCommand($"INSERT INTO \"User\" (nama,nomor_telepon,username,password,id_peran,id_alamat,id_kualitas_kopi) VALUES ('{nama}', '{nomor_telepon}', '{username}', '{password}', {id_peran}, {id_alamat}, {id_kualitas_kopi})", con);
                insert_user.ExecuteNonQuery();
            }
        }

        public bool ValidateCurrentPassword(string currentPassword, string username)
        {
            using (var conn = new NpgsqlConnection(koneksi))
            {
                conn.Open();
                var query = $"SELECT password FROM \"User\" WHERE username = '{username}'";
                var cmd = new NpgsqlCommand(query, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    return reader.Read() && reader.GetString(0) == currentPassword;
                }
            }
        }

        public bool UpdatePassword(string newPassword,string username)
        {
            using (var conn = new NpgsqlConnection(koneksi))
            {
                conn.Open();
                var query = $"UPDATE \"User\" SET password = '{newPassword}' WHERE username = '{username}'";
                var cmd = new NpgsqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public string GetAlamatId(string username)
        {
            using (var conn = new NpgsqlConnection(koneksi))
            {
                conn.Open();
                var query = $"SELECT id_alamat FROM \"User\" WHERE username = '{username}'";
                var cmd = new NpgsqlCommand(query, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return reader[0].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public bool UpdateProfile(string newUsername, string newNomorHp, string newJalan, string newDesa, string newKecamatan, string newNoRekening, string username)
        {
            using (var conn = new NpgsqlConnection(koneksi))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(newUsername))
                        {
                            var query = $"UPDATE \"User\" SET username = '{newUsername}' WHERE username = '{username}'";
                            var cmd = new NpgsqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }

                        if (!string.IsNullOrEmpty(newNomorHp))
                        {
                            var query = $"UPDATE \"User\" SET nomor_telepon = '{newNomorHp}' WHERE username = '{username}'";
                            var cmd = new NpgsqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }

                        var alamatId = GetAlamatId(username);
                        if (!string.IsNullOrEmpty(alamatId))
                        {
                            if (!string.IsNullOrEmpty(newJalan))
                            {
                                var query = $"UPDATE alamat SET nama_jalan = '{newJalan}' WHERE id_alamat = {alamatId}";
                                var cmd = new NpgsqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                            }

                            if (!string.IsNullOrEmpty(newDesa))
                            {
                                var query = $"UPDATE alamat SET desa = '{newDesa}' WHERE id_alamat = {alamatId}";
                                var cmd = new NpgsqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                            }

                            if (!string.IsNullOrEmpty(newKecamatan))
                            {
                                var query = $"UPDATE alamat SET kecamatan = @newKecamatan WHERE id_alamat = {alamatId}";
                                var cmd = new NpgsqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        if (!string.IsNullOrEmpty(newNoRekening))
                        {
                            var query = $"UPDATE \"User\" SET nomor_rekening = @newNoRekening WHERE username = '{username}'";
                            var cmd = new NpgsqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
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
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query_nama = $"select nama from \"User\" where username = @username";
                using (var cmd = new NpgsqlCommand(query_nama, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
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
