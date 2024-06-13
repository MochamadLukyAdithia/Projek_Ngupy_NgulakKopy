using Ngupy_NgulakKopy.Controllers;
using Ngupy_NgulakKopy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pengepul
{
    public partial class MasukPengepul : Form
    {
        public MasukPengepul()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginPengepul_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            AkunControllers akunControllers = new AkunControllers();

            string status_login = akunControllers.login(username, password, 2);

            if (status_login == "Login berhasil!")
            {
                MessageBox.Show($"Berhasil login, Selamat datang, {txtUsername.Text}", "Success");
                username = txtUsername.Text;
                this.Hide();
                GetstartedPengepul getStarted = new GetstartedPengepul();
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
                MessageBox.Show("Error", "Error");
            }
        }

        private void MasukPengepul_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaftarPengepul lp = new DaftarPengepul();
            lp.ShowDialog();
        }
    }
}

