using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Ngupy_NgulakKopy.Models
{
    internal class PenjualanContext
    {
        public List<Penjualan> listPenjualan = new List<Penjualan>();

        public bool Insert(Penjualan newPenjualan)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Connection.connect))
                {
                    conn.Open();

                    // Get the latest harga
                    int id_harga;
                    using (var cmd = new NpgsqlCommand("SELECT id_harga FROM harga_kopi ORDER BY id_harga DESC LIMIT 1", conn))
                    {
                        id_harga = (int)cmd.ExecuteScalar();
                    }

                    // Insert new Penjualan
                    string sql = "INSERT INTO \"Penjualan\" (jumlah_kopi, id_user, id_harga) VALUES (@jumlah_kopi, @id_user, @id_harga)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("jumlah_kopi", newPenjualan.jumlah_kopi);
                        cmd.Parameters.AddWithValue("id_user", newPenjualan.id_user);
                        cmd.Parameters.AddWithValue("id_harga", id_harga);

                        cmd.ExecuteNonQuery();
                    }

                    this.listPenjualan.Add(newPenjualan);
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log exception or handle accordingly
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
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
                                     "JOIN harga_kopi hp ON p.id_harga = hp.id_harga " +
                                     "ORDER BY hp.id_harga DESC LIMIT 1";

                        con.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                        {
                            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                            {
                                listPenjualan.Clear();
                                while (reader.Read())
                                {
                                    Penjualan penjualan = new Penjualan
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

