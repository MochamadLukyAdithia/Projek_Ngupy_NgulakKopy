using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ngupy_NgulakKopy.Models;
using Ngupy_NgulakKopy.Tools;
using Npgsql;

namespace Ngupy_NgulakKopy.Models
{
    public class PembelianContext
    {
        private Pembelian _pembelian;

        public PembelianContext()
        {
            _pembelian = new Pembelian();
        }

        public DataGridView read_pembelian()
        {
            return _pembelian.read_pembelian();
        }

        public void insert_pembelian(int id_penjemputan, int id_user)
        {
            _pembelian.tambah_pembelian(id_penjemputan, id_user);

        }
    }
}
