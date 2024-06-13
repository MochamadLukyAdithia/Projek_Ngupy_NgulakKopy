using Guna.UI2.WinForms;
using Ngupy_NgulakKopy.Views.Petani;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ngupy_NgulakKopy.Models
{
    internal class User
    {
        public string nama { get; set; }
        public string nomor_telepon { get; set; }
        public string nomor_rekening { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int id_user { get; set; }
        public int id_peran { get; set; }
        public int id_alamat { get; set; }
        public int id_kualitas_kopi { get; set; }
        private string koneksi = "Host=localhost;Username=postgres;Password=wahyuok234;Database=Ngupy_Database";

        public bool ValidateCurrentPassword(string currentPassword)
        {
            using (var conn = new NpgsqlConnection(koneksi))
            {
                conn.Open();
                var query = $"SELECT password FROM \"User\" WHERE username = '{LoginPetani.username}'";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                using (var reader = cmd.ExecuteReader())
                {
                    return reader.Read() && reader.GetString(0) == currentPassword;
                }
            }
        }

        public bool UpdatePassword(string newPassword)
        {
            using (var conn = new NpgsqlConnection(koneksi))
            {
                conn.Open();
                var query = $"UPDATE \"User\" SET password = @newPassword WHERE username = '{LoginPetani.username}'";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@username", username);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public int? GetAlamatId()
        {
            using (var conn = new NpgsqlConnection(koneksi))
            {
                conn.Open();
                var query = $"SELECT id_alamat FROM \"User\" WHERE username = @username";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int id_alamat = reader.GetInt32(0);
                        return id_alamat;
                    }
                }
            }
            return null;
        }

        public bool UpdateProfile(string newUsername, string newNomorHp, string newJalan, string newDesa, string newKecamatan, string newNoRekening)
        {
            using (var conn = new NpgsqlConnection(koneksi))
            {
                

                conn.Open();
                using (var execute = conn.BeginTransaction())
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(newUsername) && newUsername.Length > 3)
                        {
                            var query = $"UPDATE \"User\" SET username = @newUsername WHERE username = '{LoginPetani.username}'";
                            var cmd = new NpgsqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@newUsername", newUsername);
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.ExecuteNonQuery();
                            LoginPetani.username = newUsername;
                        }
                       
                         
                        if (!string.IsNullOrEmpty(newNomorHp))
                        {
                            var query = $"UPDATE \"User\" SET nomor_telepon = @newNomorHp WHERE username = '{LoginPetani.username}'";
                            var cmd = new NpgsqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@newNomorHp", newNomorHp);
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.ExecuteNonQuery();
                        }
                     

                        var alamatId = GetAlamatId();
                        if (alamatId != null && alamatId != 0)
                        {
                            if (!string.IsNullOrEmpty(newJalan))
                            {
                                var query = $"UPDATE alamat SET nama_jalan = @newJalan WHERE id_alamat = @alamatId";
                                var cmd = new NpgsqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@newJalan", newJalan);
                                cmd.Parameters.AddWithValue("@alamatId", alamatId);
                                cmd.ExecuteNonQuery();
                            }

                            if (!string.IsNullOrEmpty(newDesa))
                            {
                                var query = $"UPDATE alamat SET desa = @newDesa WHERE id_alamat = @alamatId";
                                var cmd = new NpgsqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@newDesa", newDesa);
                                cmd.Parameters.AddWithValue("@alamatId", alamatId);
                                cmd.ExecuteNonQuery();
                            }

                            if (!string.IsNullOrEmpty(newKecamatan))
                            {
                                var query = $"UPDATE alamat SET kecamatan = @newKecamatan WHERE id_alamat = @alamatId";
                                var cmd = new NpgsqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@newKecamatan", newKecamatan);
                                cmd.Parameters.AddWithValue("@alamatId", alamatId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        if (!string.IsNullOrEmpty(newNoRekening))
                        {
                            var query = $"UPDATE \"User\" SET nomor_rekening = @newNoRekening WHERE username = '{LoginPetani.username}'";
                            var cmd = new NpgsqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@newNoRekening", newNoRekening);
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.ExecuteNonQuery();
                        }
                      
                        execute.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        execute.Rollback();
                        return false;
                    }
                }
            }
        }
    }

}
