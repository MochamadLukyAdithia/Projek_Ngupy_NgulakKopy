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
        public int id_user {  get; set; }
        public int id_peran { get; set; }
        public int id_alamat { get; set; }
        public int id_kualitas_kopi { get; set; }
    }
}
