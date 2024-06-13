using Ngupy_NgulakKopy.Controllers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Petani
{
    public partial class LoginPetani : Form
    {
        static public string username;
        private AkunControllers akunControllers;
        
        public LoginPetani()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
            akunControllers = new AkunControllers();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLoginPetani_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            string password = txtPassword.Text; 
                  
            string status_login = akunControllers.login(username, password, 1);

            if (status_login == "Login berhasil!")
            {
                MessageBox.Show($"Berhasil login, Selamat datang, {txtUsername.Text}", "Success");
                username = txtUsername.Text;
                //username1 = username;
                this.Hide();
                GetStarted getStarted = new GetStarted(username);
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
            DaftarPetani dp = new DaftarPetani();
            dp.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPetani_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

          
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}