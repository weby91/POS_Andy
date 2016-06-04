using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Andy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            WindowState = FormWindowState.Maximized;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tstrip_staff_Click(object sender, EventArgs e)
        {
            frmAddStaff faddstaff = new frmAddStaff();
            faddstaff.Show();
        }

        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStaff fliststaff = new frmListStaff();
            fliststaff.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProduct flistProduct = new frmListProduct();
            flistProduct.Show();
        }

        private void tambahVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVendor faddVendor = new frmAddVendor();
            faddVendor.Show();
        }

        private void listVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListVendor flistVendor = new frmListVendor();
            flistVendor.Show();
        }

        private void tstrip_product_Click(object sender, EventArgs e)
        {
            frmAddProduct faddproduct = new frmAddProduct();
            faddproduct.Show();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportProduct fimprtProduct = new frmImportProduct();
            fimprtProduct.Show();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            frmAddKategori faddKategori = new frmAddKategori();
            faddKategori.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAddSatuan faddSatuan = new frmAddSatuan();
            faddSatuan.Show();
        }

        private void listSatuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSatuan faddSatuan = new frmAddSatuan();
            faddSatuan.Show();
        }

        private void listSatuanToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tambahKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddKategori faddKategori = new frmAddKategori();
            faddKategori.Show();
        }

        private void listProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProduct flistProduct = new frmListProduct();
            flistProduct.Show();
        }
    }
}
