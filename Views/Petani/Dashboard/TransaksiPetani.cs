
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
        private TransaksiContext Tcontext;
        private UserContext Ucontext;
        private User user;
        
        public TransaksiPetani()
        {
            InitializeComponent();
            Pcontext = new PenjemputanPetaniContext();
            penjemputan = new PetaniPenjemputan(); 
            Tcontext = new TransaksiContext();
            Ucontext = new UserContext();
            user = new User();
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {
            
            
        }



        private void guna2Button6_Click(object sender, EventArgs e)
        {
            penjemputan.Getpenjemputan = Pcontext.Getidpenjemputan(username);
            id_penjemputan = Pcontext.Getidpenjemputan(username);
            user.GetId = Ucontext.Getid(username);
            id_user = user.GetId;
            Tcontext.insert_transaksi(id_penjemputan, id_pembayaran, id_user);
        }

        

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            id_pembayaran = 1;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            id_pembayaran = 2;
        }

        private void TransaksiPetani_Load(object sender, EventArgs e)
        {

        }
    }
}
