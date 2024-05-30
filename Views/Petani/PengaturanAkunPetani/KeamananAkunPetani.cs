using Ngupy_NgulakKopy.Views.Petani.Dashboard.PengaturanProfilPetani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Petani.PengaturanAkunPetani
{
    public partial class KeamananAkunPetani : Form
    {
        public KeamananAkunPetani()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PengaturanPetani profil = new PengaturanPetani();
            profil.Show();
            this.Hide();
        }
    }
}
