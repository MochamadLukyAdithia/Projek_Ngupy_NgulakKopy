using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class KualitasKopi
    {
        public int id_kualitas_kopi { get; set; }
        public string kategori_kualitas_kopi { get; set; }
        public int harga_kualitas { get; set; }
        public string keterangan { get; set; }
        public string harga_terbaru { get; set; }
    }
}
