using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Models;
using Ngupy_NgulakKopy.Tools;

namespace Ngupy_NgulakKopy.Controllers
{
    internal class TransaksiControllers
    {
        private TransaksiModel _transaksiModel;

        public TransaksiControllers()
        {
            _transaksiModel = new TransaksiModel();
        }

        public void insertTransaksi(int id_penjemputan, int id_pembayaran, int id_user)
        {
            _transaksiModel.insert_transaksi(id_penjemputan, id_pembayaran, id_user);
        }

        public DataTable ReadRiwayat(int id_user)
        {
            return _transaksiModel.readriwayat(id_user);
        }

        public void updaterekening(string no_rekening, string username)
        {
            _transaksiModel.updaterekening(no_rekening, username);
        }
    }
}
