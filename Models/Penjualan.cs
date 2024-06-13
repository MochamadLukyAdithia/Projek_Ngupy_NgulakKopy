using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class Penjualan
    {
        public int id_penjualan { get; set; }
        public int jumlah_kopi { get; set; }
        public int id_user { get; set;}
        public int total {  get; set;}
        public int harga { get; set;}
        public int id_harga { get; set;}
    }
}
