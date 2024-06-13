using Ngupy_NgulakKopy.Models;
using Ngupy_NgulakKopy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ngupy_NgulakKopy.Controllers
{
    internal class AkunControllers
    {
        private User user;

        public AkunControllers()
        {
            user = new User();
        }

        public string login(string usn, string passwd, int idPeran)
        {
            user.username = usn;
            user.password = passwd;

            var hasil = user.login(idPeran);
            if (hasil.HasValue)
            {
                var (username, password) = hasil.Value;
                if (password == passwd)
                {
                    return "Login berhasil!";
                }
                else
                {
                    return "Password salah.";
                }
            }
            else
            {
                return "Username tidak ditemukan.";
            }
        }

        public bool Cek_Username(string usn)
        {
            return user.Cek_Username(usn);
        }

        public void Daftar(string nama, string nomor_telepon, string username, string password, int id_peran, int id_alamat, int id_kualitas_kopi)
        {
            user.Daftar(nama, nomor_telepon, username, password, id_peran, id_alamat, id_kualitas_kopi);
        }

    }
}

