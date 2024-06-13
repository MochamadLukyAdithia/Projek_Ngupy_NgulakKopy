﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private string koneksi = "Host=localhost;Username=postgres;Password=jember110605;Database=luky_database";

        public (string username, string password)? login(int id_peran)
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                var cmd = new NpgsqlCommand($"SELECT Username, Password FROM \"User\" Where Username ilike '{this.username}' and id_peran = {id_peran}", con);
                using (var reader = cmd.ExecuteReader())
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
                var cmd = new NpgsqlCommand($"SELECT Username From \"User\" Where Username = '{username}'", con);
                using (var reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }

            }

        }

        public void Daftar(string nama, string nomor_telepon, string username, string password, int id_peran, int id_alamat, int id_kualitas_kopi)
        {
            using (var con = new NpgsqlConnection(koneksi))
            {
                con.Open();
                var cmd = new NpgsqlCommand($"INSERT INTO \"User\" (nama,nomor_telepon,username,password,id_peran,id_alamat,id_kualitas_kopi) VALUES ('{nama}', '{nomor_telepon}', '{username}', '{password}', {id_peran}, {id_alamat}, {id_kualitas_kopi})", con);
                cmd.ExecuteNonQuery();
            }
        }


    }

}  
