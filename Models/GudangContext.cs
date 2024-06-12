using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngupy_NgulakKopy.Models
{
    internal class GudangContext
    {
        private Gudang _gudang;

        public GudangContext()
        {
            _gudang = new Gudang();
        }

        public void update_stok(int stok_kopi)
        {
            _gudang.update_stok(stok_kopi);
        }

        public int Getstok_kopi()
        {
            return _gudang.Getstok_kopi();
        }

        public void updatestok(int stok_kopi)
        {
            _gudang.updatestok(stok_kopi);
        }
    }
}
