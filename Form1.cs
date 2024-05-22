using Ngupy_NgulakKopy.Views.Pengepul;
using Ngupy_NgulakKopy.Views.Petani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedItem.ToString() == "Petani")
            {
                this.Hide();
                LoginPetani lp = new LoginPetani();
                lp.ShowDialog();
            }
            else if (guna2ComboBox1.SelectedItem.ToString() == "Pengepul")
            {
                this.Hide();
                MasukPengepul mp = new MasukPengepul();
                mp.ShowDialog();
            }
            else if (guna2ComboBox1.SelectedItem.ToString() == "Pusat")
            {
                this.Hide();
                Views.Pusat.MasukPusat mp = new Views.Pusat.MasukPusat();
                mp.ShowDialog();
            }


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
