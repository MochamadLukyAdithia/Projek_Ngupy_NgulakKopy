using Ngupy_NgulakKopy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Models;

namespace Ngupy_NgulakKopy.Controllers
{
    internal class AlamatControllers
    {
        private Alamat alamat;

        public AlamatControllers()
        {
            alamat = new Alamat();
        }

        public int? insert_alamat(string jalan, string desa, string kecamatan)
        {
            return alamat.insert_alamat(jalan, desa, kecamatan);
        }

    }
}
