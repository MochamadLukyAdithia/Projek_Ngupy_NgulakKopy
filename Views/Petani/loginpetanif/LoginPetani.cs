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
    public partial class LoginPetani : Form
    {
        public LoginPetani()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLoginPetani_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetStarted getStarted = new GetStarted();
            getStarted.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaftarPetani dp = new DaftarPetani();
            dp.ShowDialog();
        }
    }
}
