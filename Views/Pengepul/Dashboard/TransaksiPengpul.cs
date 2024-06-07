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
    public partial class TransaksiPengpul : UserControl
    {
        public TransaksiPengpul()
        {
            InitializeComponent();
        }

        private void TransaksiPengpul_Load(object sender, EventArgs e)
        {
            GetTanggal();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void GetTanggal()
        {
            DateTime today = DateTime.Now;
            string formattedDate = today.ToString("MM/dd/yyyy");
            labelTanggal1.Text = $"{formattedDate}";
        }

        private void lblhrgterbaru_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlTransaksi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            guna2Button10.BackColor = Color.Aqua;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
