using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Ngupy_NgulakKopy.Tools;
using Ngupy_NgulakKopy.Views.Petani;

namespace Ngupy_NgulakKopy.Models
{
    public class PetaniPenjemputan
    {
        private int id_penjemputan {  get; set; }
        private DateTime waktu_penjemputan {  set; get; }
        private int id_user {  get; set; }

        public int Getiduser
        {
            get { return id_user; }
            set { id_user = value; }
        }

        public int Getpenjemputan
        {
            get { return id_penjemputan; }
            set { id_penjemputan = value; }
        }

        public void insert(int id_user)
        {
            using(var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"insert into penjemputan (waktu_penjemputan,id_user,status) values (now(),@id_user,0" +
                    $")";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_user",id_user);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public int Get_Id(string username)
        {
            int id_penjemputan = 0;
            using(var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"select p.id_penjemputan from penjemputan p join \"User\" u on(u.id_user=p.id_user) where u.username like @username order by p.id_penjemputan desc limit 1";
                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_penjemputan = reader.GetInt32(0);
                        }
                    }
                }
            }
            return id_penjemputan;
        }

        /*public DateTime GetTanggal(string username)
        {
            DateTime tanggal;
            using (var conn = new NpgsqlConnection(Connection.connect))
            {
                conn.Open();
                string query = $"select p.id_penjemputan from penjemputan p join \"User\" u on(u.id_user=p.id_user) where u.username like @username order by p.id_penjemputan desc limit 1";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_penjemputan = reader.GetInt32(0);
                        }
                    }
                }
            }
            return id_penjemputan;
        }*/
    } 
}
