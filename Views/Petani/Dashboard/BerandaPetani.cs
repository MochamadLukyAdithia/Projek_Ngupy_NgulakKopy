using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Ngupy_NgulakKopy.Views.Petani;
using Ngupy_NgulakKopy.Models;

namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class BerandaPetani : UserControl
    {
        private GudangContext Gcontext;
        private DetailPenjemputanContext DPcontext;
        private UserContext Ucontext;
        private User user;
        private Gudang gudang;

        private DetailPenjemputan detailpenjemputan;

        public BerandaPetani()
        {
            InitializeComponent();
            Getstok_kopi();
            Getnamauser();


            DPcontext = new DetailPenjemputanContext();



        }

        private void BerandaPetani_Load(object sender, EventArgs e)
        {
            Getstok_kopi();
            Getnamauser();
        }

        private void Getstok_kopi()
        {
            Ucontext = new UserContext();
            Gcontext = new GudangContext();
            detailpenjemputan = new DetailPenjemputan();
            string username = LoginPetani.username;
            Gudang gudang = new Gudang();
            User user = new User();

            user.GetId = Ucontext.Getid(username);
            int id_user = user.GetId;
            lblkaryawan.Text = detailpenjemputan.NamapegawaiById(id_user);
            gudang.get_stokkopi = Gcontext.Getstok_kopi();
            lblkapasitas.Text = gudang.get_stokkopi.ToString() + "kg/50 Ton";
        }

        private void Getnamauser()
        {
            User user = new User();
            string username = LoginPetani.username;
            user.Getnama = Ucontext.Getnama(username);
            lblusername.Text = user.Getnama;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }
    }
}
