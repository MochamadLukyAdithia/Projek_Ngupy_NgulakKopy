using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ngupy_NgulakKopy.Controllers;
using Ngupy_NgulakKopy.Models;

namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class RiwayatPetani : UserControl
    {
        private string username = LoginPetani.username;
        private UserContext usercontext;
        private TransaksiControllers transaksicontrollers;
       

        public RiwayatPetani()
        {
            InitializeComponent();
          
            


            RiwayatDataGrid.EnableHeadersVisualStyles = false;
            RiwayatDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            RiwayatDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RiwayatDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            RiwayatDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            RiwayatDataGrid.ColumnHeadersHeight = 30;
            RiwayatDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RiwayatDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            RiwayatDataGrid.RowHeadersWidth = 30;

        }
        
        

        private void RiwayatPetani_Load(object sender , EventArgs e)
        {
            
        }

        private void pnlPenjemptan_Paint(object sender, PaintEventArgs e)
        {

        }

        public void readriwayat()
        {
            usercontext = new UserContext();
            transaksicontrollers = new TransaksiControllers();
            int id_user = usercontext.Getid(username);
            RiwayatDataGrid.DataSource = transaksicontrollers.ReadRiwayat(id_user);
            lblnama.Text = usercontext.GetName(username);

        }
       
    }
}
