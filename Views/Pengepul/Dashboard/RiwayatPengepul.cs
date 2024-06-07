using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    public partial class RiwayatPengepul : UserControl
    {
        public RiwayatPengepul()
        {
            InitializeComponent();
        }

        private void RiwayatPengepul_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PembelianButton_Click(object sender, EventArgs e)
        {
            PembelianButton.BringToFront();
            PembelianButton.BackColor = Color.FromArgb(255, 218, 154);
            PenjualanButton.BackColor = Color.FromArgb(255,255,255);
            PembelianDataGridView1.BringToFront();
          
        }

        private void PenjualanButton_Click(object sender, EventArgs e)
        {
            PenjualanButton.BringToFront();
            PembelianButton.BackColor = Color.FromArgb(255, 255, 255);
            PenjualanButton.BackColor = Color.FromArgb(255, 218, 154);
            PenjualanDataGridView1.BringToFront();

        }
    }
}
