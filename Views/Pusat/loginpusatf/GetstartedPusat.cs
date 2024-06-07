using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pusat
{
    public partial class GetstartedPusat : Form
    {
        public GetstartedPusat()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.DashboardPusat dashboardPusat = new Dashboard.DashboardPusat();
            dashboardPusat.ShowDialog();
        }
    }
}
