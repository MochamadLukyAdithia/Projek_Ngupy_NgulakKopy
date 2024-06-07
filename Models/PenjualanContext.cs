using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Ngupy_NgulakKopy.Models
{
    internal class PenjualanContext
    {
        public List<Penjualan> listPenjualan = new List<Penjualan>();

        public bool Insert(Penjualan newPenjualan)
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT harga FROM harga_kopi ORDER BY id_haga DESC LIMIT 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                             int id_harga = reader.GetInt32(0);
                            conn.Close();
                            conn.Open();
                            try
                            {
                                using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
                                {
                                    string sql = $"INSERT INTO \"Penjualan\" (jumlah_kopi, id_user,id_harga) VALUES (@jumlah_kopi, @id_user, {id_harga})";
                                    con.Open();
                                    using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                                    {
                                        command.Parameters.AddWithValue("jumlah_kopi", newPenjualan.jumlah_kopi);
                                        command.Parameters.AddWithValue("id_user", newPenjualan.id_user);
                                        command.Parameters.AddWithValue("id_harga", newPenjualan.id_user);
                                        command.ExecuteNonQuery();
                                    }
                                    this.listPenjualan.Add(newPenjualan);
                                }
                                return true;
                            }
                            catch (Exception ex)
                            {
                                // Log exception or handle accordingly
                                Console.WriteLine($"Error: {ex.Message}");
                                return false;
                            }
                        }
                        conn.Close();
                    }
                }
            }
            return true ;
           
        }

        public bool ReadPenjualan()
        {
            bool isgud = false;
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
                {
                    string sql = "SELECT p.jumlah_kopi, (p.jumlah_kopi * hp.harga) AS Total, hp.harga " +
                                 "FROM \"Penjualan\" p " +
                                 "JOIN \"User\" u ON u.id_user = p.id_user " +
                                 "JOIN harga_kopi hp ON hp.id_haga = p.id_harga "  // Assuming there's an id_kopi field to join
                                 ;
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            listPenjualan.Clear();
                            while (reader.Read())
                            {
                                Penjualan penjualan = new Penjualan()
                                {
                                    jumlah_kopi = reader.GetInt32(reader.GetOrdinal("jumlah_kopi")),
                                    total = reader.GetInt32(reader.GetOrdinal("Total")),
                                    harga = reader.GetInt32(reader.GetOrdinal("harga"))
                                };
                                listPenjualan.Add(penjualan);
                                isgud = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error: {ex.Message}");
            }
            return isgud;
        }
    }
}
