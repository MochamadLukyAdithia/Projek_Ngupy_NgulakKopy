
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Ngupy_NgulakKopy.Models;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Ngupy_NgulakKopy.Tools;
using Ngupy_NgulakKopy.Controllers;

namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class TransaksiPetani : UserControl
    {
        
        private string username = LoginPetani.username;
        private int id_pembayaran;
        private int id_penjemputan;
        private int id_user;
        private PenjemputanPetaniContext Pcontext;
        private PetaniPenjemputan penjemputan;
        private UserContext Ucontext;
        private PenjualanContext Penjualan;
        private HargaKopiControllers hargacontrollers;
        private User user;
        private TransaksiControllers transaksicontrollers;
        private KualitasKopiControllers kualitaskopicontrollers;
        
        public TransaksiPetani()
        {
            InitializeComponent();
            Pcontext = new PenjemputanPetaniContext();
            penjemputan = new PetaniPenjemputan(); 
            transaksicontrollers = new TransaksiControllers();
            Ucontext = new UserContext();
            user = new User();
            Penjualan = new PenjualanContext();
            hargacontrollers = new HargaKopiControllers();
            kualitaskopicontrollers = new KualitasKopiControllers();
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {
            
            
        }



        private void guna2Button6_Click(object sender, EventArgs e)
        {
            penjemputan.Getpenjemputan = Pcontext.Getidpenjemputan(username);
            id_penjemputan = Pcontext.Getidpenjemputan(username);
            user.id_user = Ucontext.Getid(username);
            id_user = user.id_user;
            transaksicontrollers.insertTransaksi(id_penjemputan, id_pembayaran, id_user);

            string no_rekening = txtNoRek.Text;
            int id_harga = Convert.ToInt32(hargacontrollers.getIDharga());
            int jumlah_kopi = PenjemputanPetani.jumlah_kopi;
            transaksicontrollers.updaterekening(no_rekening,username);
            Penjualan.tambah_penjualan(jumlah_kopi,id_user,id_harga);
        }

        

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            id_pembayaran = 2;
            guna2Button10.BringToFront();
            guna2Button10.FillColor = Color.FromArgb(255, 218, 154);
            guna2Button9.FillColor = Color.FromArgb(255, 255, 255);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            id_pembayaran = 1;
            guna2Button9.BringToFront();
            guna2Button9.FillColor = Color.FromArgb(255, 218, 154);
            guna2Button10.FillColor = Color.FromArgb(255, 255, 255);
        }

        private void TransaksiPetani_Load(object sender, EventArgs e)
        {
            lblhrgterbaru.Text = Convert.ToString(hargacontrollers.get_harga_terbaru());
            lblKuallitas.Text = kualitaskopicontrollers.getkualitas();
        }
    }
}
