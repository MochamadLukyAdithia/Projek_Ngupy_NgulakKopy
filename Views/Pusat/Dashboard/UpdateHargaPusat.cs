using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy.Views.Pusat.Dashboard
{
    public partial class UpdateHargaPusat : UserControl
       
    {
        //public static UpdateHargaPusat instance;
        private List<string> dataharga = new List<string>();
        public UpdateHargaPusat()
        {
            InitializeComponent();
            //instance = this;
            

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            lblhrgterbaru.Text = txthargaPusat.Text;
            string inputData = txthargaPusat.Text;
            dataharga.Add(inputData);
            txthargaPusat.Clear();

        }
        //private void btnSaveInput_Click(object sender, EventArgs e)
        //{
        //    string inputData = txthargaPusat.Text;
        //    dataharga.Add(inputData);
        //    txthargaPusat.Clear();
        //}

        //private void btnOpenForm2_Click(object sender, EventArgs e)
        //{
        //    Form2 form2 = new Form2(this);
        //    form2.ShowDialog();
        //}

        public List<string> GetDataList()
        {
            return dataharga;
        }

        private void UpdateHargaPusat_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToFile();
        }

        private void SaveDataToFile()
        {
            using (FileStream fs = new FileStream("data.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dataharga);
            }
        }

        private void UpdateHargaPusat_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbltgl.Text = dt.ToString("dd/MM/yyyy");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
