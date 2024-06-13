using Ngupy_NgulakKopy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Controllers
{
    internal class DetailPenjemputanControllers
    {
        private DetailPenjemputan detailpenjemputan;

        public DetailPenjemputanControllers()
        {
            detailpenjemputan = new DetailPenjemputan();
        }

        public string NamapegawaiById(int id_user)
        {
            return detailpenjemputan.NamapegawaiById(id_user);
        }
    }
}
