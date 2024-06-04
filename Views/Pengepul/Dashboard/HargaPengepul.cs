using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    public partial class HargaPengepul : UserControl
    {
        public HargaPengepul()
        {
            InitializeComponent();
        }

        private void HargaPengepul_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //brndpngpl br = new brndpngpl();
            
            lblhrgterbaru.Text = txtharga.Text;
            lblkapasitas.Text = txtkapasitas.Text;
            
        }
    }
}
