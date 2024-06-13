using Ngupy_NgulakKopy.Tools;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace Ngupy_NgulakKopy.Models
{
    internal class PenjualanContext
    {
        public List<Penjualan> listPenjualan = new List<Penjualan>();
        private Penjualan penjualan;

        public PenjualanContext()
        {
            penjualan = new Penjualan();
        }

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


        public DataTable ReadPenjualan()
        {
            DataTable dataPenjualan = new DataTable();
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Connection.connect))
                {
                    string sql = "SELECT p.id_penjualan, p.jumlah_kopi, (p.jumlah_kopi * hp.harga) AS Total, hp.harga, p.id_user " +
                                     "FROM \"Penjualan\" p " +
                                     "JOIN \"User\" u ON u.id_user = p.id_user " +
                                     "JOIN harga_kopi hp ON p.id_harga = hp.id_harga " +
                                     "ORDER BY hp.id_harga DESC LIMIT 1"; 

                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                {
                                    dataPenjualan.Load(reader); 
                                }
                            }
                        }
                    }
                }
            }
            return dataPenjualan;
        }

        public void Penjualan_petani()
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();

                string sql = "INSERT INTO \"Penjualan\" (jumlah_kopi, id_user, id_harga) VALUES (@jumlah_kopi, @id_user, @id_harga)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("jumlah_kopi", penjualan.jumlah_kopi);
                    cmd.Parameters.AddWithValue("id_user", penjualan.id_user);
                    cmd.Parameters.AddWithValue("id_harga", penjualan.id_harga);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void tambah_penjualan(int jumlah_kopi, int id_user, int id_harga)
        {
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"insert into \"Penjualan\" (jumlah_kopi,id_user,id_harga) values (@jumlah_kopi,@id_user,@id_harga)";
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("jumlah_kopi", jumlah_kopi);
                cmd.Parameters.AddWithValue("id_user", id_user);
                cmd.Parameters.AddWithValue("id_harga", id_harga);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

