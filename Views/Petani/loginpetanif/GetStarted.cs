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
    public partial class GetStarted : Form
    {
        private string username;
        public GetStarted(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.DashboardPetani dashboardPetani = new Dashboard.DashboardPetani(username);
            dashboardPetani.ShowDialog();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void GetStarted_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
