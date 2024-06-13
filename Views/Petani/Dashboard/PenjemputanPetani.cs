﻿using Ngupy_NgulakKopy.Tools;
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
using Ngupy_NgulakKopy.Models;


namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class PenjemputanPetani : UserControl
    {
        private PenjemputanPetaniContext pcontext;
        private UserContext Ucontext;
        string username = LoginPetani.username;
        private Gudang Gcontext;
        static public int jumlah_kopi;
        public PenjemputanPetani()
        {
            InitializeComponent();
            pcontext = new PenjemputanPetaniContext();
            Ucontext = new UserContext();
            Gcontext = new Gudang();
            getnama();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void txtkapasitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            
        }



       

      

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            
            string username = LoginPetani.username;
            PenjemputanPetaniContext addpenjemputan = new PenjemputanPetaniContext();
            User user = new User();
            user.id_user = Ucontext.Getid(username);
            int id_user = user.id_user;
            addpenjemputan.tambah_penjemputan(id_user);

            jumlah_kopi = Convert.ToInt32(txtjmlhkopi.Text);
            Gcontext.get_stokkopi = Gcontext.Getstok_kopi();
            int current_stok = Gcontext.get_stokkopi;
            int stok_kopi = jumlah_kopi + current_stok;

            Gcontext.updatestok(stok_kopi);

            MessageBox.Show("Request telah berhasil dikirim");
            

        }

        private void getnama()
        {
            string nama = Ucontext.GetName(username);
            lblnama.Text = nama;
        }


    }
}