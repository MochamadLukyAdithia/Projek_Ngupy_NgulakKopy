using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class PegawaiModels
    {
        private int id_pegawai_penjemputan {  get; set; }
        private string nama_pegawai { get; set; }
        private string nomor_telepon { get; set; }
        private int id_alamat {  get; set; }

        public string NAMA_pegawai
        {
            get { return nama_pegawai; }
            set { this.nama_pegawai = value; }
        }
    }
}
