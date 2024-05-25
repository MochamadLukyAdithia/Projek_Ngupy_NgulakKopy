using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Petani
{
    public partial class DaftarPetani : Form
    {
        public DaftarPetani()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data anda berhasil disimpan");
            this.Hide();
            LoginPetani lp = new LoginPetani();
            lp.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPetani lp = new LoginPetani();
            lp.ShowDialog();
        }
    }
}
