using Ngupy_NgulakKopy.Models;
using Ngupy_NgulakKopy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ngupy_NgulakKopy.Models;


namespace Ngupy_NgulakKopy.Controllers
{
    internal class AkunControllers
    {
        private User user;
        public string username_now { get; private set; }
        public int id_peran_now { get; private set; }
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
                    username_now = username;
                    id_peran_now = idPeran;
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

        public void Daftar(string nama, string nomor_telepon, string username, string password, int id_peran, int id_alamat)
        {
            user.Daftar(nama, nomor_telepon, username, password, id_peran, id_alamat);
        }

        public void Daftar_Petani(string nama, string nomor_telepon, string username, string password, int id_alamat, int id_kualitas_kopi)
        {
            user.Daftar_Petani(nama, nomor_telepon, username, password, 1, id_alamat, id_kualitas_kopi);
        }

        public string UbahPassword(string username, string currentPassword, string newPassword, string confirmPassword)
        {
            var user = new User { username = username };

            if (!user.ValidateCurrentPassword(currentPassword, username))
            {
                return "Kata sandi lama anda salah atau user tidak ditemukan";
            }

            if (newPassword != confirmPassword)
            {
                return "Password baru dan Pasword lama tidak sama";
            }

            if (user.UpdatePassword(newPassword, username))
            {
                return "Password Berhasil di ubah";
            }
            else
            {
                return "Gagal Mengubah Password";
            }
        }
        public string UpdateUserProfile(string currentUsername, string newUsername, string newNomorHp, string newJalan, string newDesa, string newKecamatan, string newNoRekening)
        {
            var user = new User
            {
                username = currentUsername
            };

            bool isUpdated = true; /*user.UpdateProfile(newUsername, newNomorHp, newJalan, newDesa, newKecamatan, newNoRekening);*/
            return isUpdated ? "Profile updated successfully" : "Failed to update profile";
        }
    }
}
