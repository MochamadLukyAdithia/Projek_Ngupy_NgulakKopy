using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Tools;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace Ngupy_NgulakKopy.Models
{
    internal class TransaksiModel
    {
        private int id_transaksi {  get; set; }
        private DateTime tanggal_transaksi { get; set; }
        private int id_penjemputan {  get; set; }
        private int id_pembayaran { get; set; }
        private int id_gudang {  get; set; }
        private int id_user {  get; set; }

        public int id_t
        {
            get { return id_transaksi; }
            set { this.id_transaksi = value; }
        }
        public DateTime tanggal_t
        {
            get { return tanggal_transaksi; }
            set { this.tanggal_transaksi = value; }
        }
        public int ID_penjemputan
        {
            get { return id_penjemputan; }
            set { this.ID_penjemputan = value; }
        }
        public int ID_pembayaran
        {
            get { return id_pembayaran; }
            set { this.id_pembayaran = value; }
        }
        public int ID_gudang
        {
            get { return id_gudang; }
            set { this.ID_gudang = value;}
        }
        public int ID_user
        {
            get { return id_user; }
            set { this.ID_user = value;}
        }
    }
}
