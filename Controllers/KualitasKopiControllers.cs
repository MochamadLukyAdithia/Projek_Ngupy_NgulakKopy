using Ngupy_NgulakKopy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Ngupy_NgulakKopy.Controllers
{
    internal class KualitasKopiControllers
    {
        private KualitasKopi kualitasKopi;

        public KualitasKopiControllers()
        {
            kualitasKopi = new KualitasKopi();
        }

        public int? insert_kualitas()
        {
            return kualitasKopi.insert_kualitas_baru();
        }

        public (string harga, string kategori, string keterangan)? select_kualitas_kopi(string username)
        {
            var result = kualitasKopi.select_kualitas_kopi(username);
            if (result.HasValue)
            {
                var (harga_kualitas, kategori_kualitas, ket) = result.Value; 
                // Jika ket null, ganti dengan "-"
                ket = string.IsNullOrEmpty(ket) ? "-" : ket;
                return (harga_kualitas, kategori_kualitas, ket);
            }
            else
            {
                return null;
            }
        }
    }
}
