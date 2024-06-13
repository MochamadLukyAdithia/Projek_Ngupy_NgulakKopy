using Ngupy_NgulakKopy.Controllers;
using Ngupy_NgulakKopy.Views.Petani;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ngupy_NgulakKopy.Views.Pusat
{
    public partial class MasukPusat : Form
    {
        public MasukPusat()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
     
      

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginPetani_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            AkunControllers akunControllers = new AkunControllers();

            string status_login = akunControllers.login(username, password, 3);

            if (status_login == "Login berhasil!")
            {
                MessageBox.Show($"Berhasil login, Selamat datang, {txtUsername.Text}", "Success");
                username = txtUsername.Text;
                this.Hide();
                GetstartedPusat getStarted = new GetstartedPusat();
                getStarted.ShowDialog();
            }
            else if (status_login == "Password salah.")
            {
                MessageBox.Show($"Password salah", "Warning");
            }

            else if (status_login == "Username tidak ditemukan.")
            {
                MessageBox.Show("Username tidak dapat ditemukan", "Error");
            }

            else
            {
                MessageBox.Show("Error bjir", "Error");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaftarPusat dp = new DaftarPusat();
            dp.ShowDialog();
        }
    }
}
