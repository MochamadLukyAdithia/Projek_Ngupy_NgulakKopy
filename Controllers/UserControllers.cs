using Ngupy_NgulakKopy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Controllers
{
    public class UserControllers
    {
        public string UbahPassword(string username, string currentPassword, string newPassword, string confirmPassword)
        {
            var user = new User { username = username };

            if (!user.ValidateCurrentPassword(currentPassword))
            {
                return "Kata sandi lama anda salah atau user tidak ditemukan";
            }

            if (newPassword != confirmPassword)
            {
                return "Password baru dan Pasword lama tidak sama";
            }

            if (user.UpdatePassword(newPassword))
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

            bool isUpdated = user.UpdateProfile(newUsername, newNomorHp, newJalan, newDesa, newKecamatan, newNoRekening);
            return isUpdated ? "Profile updated successfully" : "Failed to update profile";
        }
    }

}

