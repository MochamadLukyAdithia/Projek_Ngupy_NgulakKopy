using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class Pembelian
    {
        public int id_pegawai_penjemputan { get; set; }
        public string nama_pegawai { get; set; }
        public DateTime waktu_penjemputan { get; set; }
        public DateTime tanggal_transaksi { get; set; }
        public int jumlah_kopi { get; set; } 
       
    }
}
