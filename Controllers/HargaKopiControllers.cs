using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Models;

namespace Ngupy_NgulakKopy.Controllers
{
    internal class HargaKopiControllers
    {
        private HargaKopi hargakopi;

        public HargaKopiControllers() 
        { 
            hargakopi = new HargaKopi();
        }

        public int? get_harga_terbaru()
        {
            return hargakopi.get_harga_terbaru();
        }

    }
}
