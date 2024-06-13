using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Models;

namespace Ngupy_NgulakKopy.Controllers
{
    internal class GudangControllers
    {
        private Gudang gudang;

        public GudangControllers()
        {
            gudang = new Gudang();
        }

        public string get_stok()
        {
            return Convert.ToString(gudang.Getstok_kopi());
        }
    }
}
