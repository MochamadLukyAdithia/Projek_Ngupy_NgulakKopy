using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class DetailPenjemputanContext
    {
        private DetailPenjemputan detailPenjemputan;

        public DetailPenjemputanContext()
        {
            detailPenjemputan = new DetailPenjemputan();
        }

        public string NamapegawaiById(int id_user)
        {
            return detailPenjemputan.NamapegawaiById(id_user);
        }
    }
}
