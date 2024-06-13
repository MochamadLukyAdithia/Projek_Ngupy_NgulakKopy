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
            string database = "Host=localhost;Username=postgres;Password=wahyuok234;Database=Ngupy_Database";
            NpgsqlConnection conn = new NpgsqlConnection(database);

            try
            {
                conn.Open();
                string queryCheck = $"SELECT password FROM \"User\" WHERE username = '{LoginPetani.username}'";
                NpgsqlCommand cmdCheck = new NpgsqlCommand(queryCheck, conn);
                NpgsqlDataReader reader = cmdCheck.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    if (reader.GetString(0) == SandiSebelum.Text)
                    {
                        reader.Close();

                        if (NewPassword.Text == ConfirmPass.Text)
                        {
                            
                            string queryUpdate = $"UPDATE \"User\" SET password = '{NewPassword.Text}' WHERE username = '{LoginPetani.username}'";
                            NpgsqlCommand cmdUpdate = new NpgsqlCommand(queryUpdate, conn);
                            cmdUpdate.ExecuteNonQuery();

                            MessageBox.Show("Kata sandi berhasil diubah", "Sukses");
                        }
                        else
                        {
                            MessageBox.Show("Kata sandi baru dan konfirmasi tidak cocok", "Warning");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password lama salah", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("Username tidak dapat ditemukan", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error");
            }
            finally
            {
                conn.Close();
            }
        }
       
    }
    
    
}
