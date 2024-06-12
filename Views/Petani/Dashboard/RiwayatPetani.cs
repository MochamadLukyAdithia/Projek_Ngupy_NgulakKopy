using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ngupy_NgulakKopy.Models;

namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    public partial class RiwayatPetani : UserControl
    {
        private UserContext Ucontext;
        
        string username = LoginPetani.username;
        TransaksiContext Tcontext = new TransaksiContext();
        private int id_user;

        public RiwayatPetani()
        {
            InitializeComponent();
            Tcontext.readriwayat();
            RiwayatDataGrid.DataSource = Tcontext.dataTable;
            
            Ucontext = new UserContext();

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
            id_user = Ucontext.Getid(username);
            
            Tcontext.readriwayat();
            RiwayatDataGrid.DataSource = Tcontext.dataTable;
        }

        private void pnlPenjemptan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
