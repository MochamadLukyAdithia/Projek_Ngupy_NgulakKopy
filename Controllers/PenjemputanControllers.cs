using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Models;

namespace Ngupy_NgulakKopy.Controllers
{
    internal class PenjemputanControllers
    {
        private Penjemputan penjemputan;

        public PenjemputanControllers()
        {
            penjemputan = new Penjemputan();
        }

        public (string nama, string waktu_penjemputan, List<string> nama_pegawai)? get_data_penjemputan(string username)
        {
            var data = penjemputan.get_data_penjemputan(username);
            if (data.HasValue)
            {
                var (nama_user, tgl_penjemputan, nama_pegawai_list) = data.Value;
                return (nama_user, tgl_penjemputan, nama_pegawai_list);
            }
            else
            {
                return null;
            }

        }


    }

}
