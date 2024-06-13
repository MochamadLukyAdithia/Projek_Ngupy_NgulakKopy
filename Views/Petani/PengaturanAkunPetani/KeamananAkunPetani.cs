
using Ngupy_NgulakKopy.Views.Petani.Dashboard.PengaturanProfilPetani;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ngupy_NgulakKopy.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ngupy_NgulakKopy.Views.Petani.PengaturanAkunPetani
{
    public partial class KeamananAkunPetani : Form
    {
        public KeamananAkunPetani()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PengaturanPetani profil = new PengaturanPetani();
            profil.Show();
            this.Hide();
        }

        private void SandiSebelum_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UbahProfilPetani_Click(object sender, EventArgs e)

        {
            string username = LoginPetani.username;
            string currentPassword = SandiSebelum.Text;
            string newPassword = NewPassword.Text;
            string confirmPassword = ConfirmPass.Text;

            var controller = new UserControllers();
            string result = controller.UbahPassword(username, currentPassword, newPassword, confirmPassword);

            MessageBox.Show(result, result.Contains("Berhasil") ? "Success" : "Error");
            
        }
    
        private void KeamananAkunPetani_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;


            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
