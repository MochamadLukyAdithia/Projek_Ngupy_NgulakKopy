using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngupy_NgulakKopy.Tools;
using Ngupy_NgulakKopy.Views.Petani;

namespace Ngupy_NgulakKopy.Models
{
    internal class PenjemputanPetaniContext
    {
        private PetaniPenjemputan penjemputan;
        public PenjemputanPetaniContext()
        {
            penjemputan = new PetaniPenjemputan();
        }

        public void tambah_penjemputan(int id_user)
        {
            penjemputan.insert(id_user);
        }
        public int Getidpenjemputan(string username)
        {
            return penjemputan.Get_Id(username);
        }

        
    }
}
