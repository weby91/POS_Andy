using POS_Andy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Andy
{
    public partial class frmMain : Form
    {
        System.Windows.Forms.Timer t = null;

        public frmMain()
        {
            InitializeComponent();
            string roles_id = Core.LogInfo.roles_id;

            if(roles_id != "1")
            {
                importToolStripMenuItem.Visible = false;
                tambahToolStripMenuItem.Visible = false;
                ubahToolStripMenuItem.Visible = false;
                hapusToolStripMenuItem.Visible = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            WindowState = FormWindowState.Maximized;
            tsslUser.Text = Core.LogInfo.userid;
            //string day, month, year, date;

            //date = DateTime.Now.ToString("yyyy-MM-dd");
            //year = date.Split('-')[0];
            //month = date.Split('-')[1];
            //day = date.Split('-')[2];

            //lblDate.Text = day + "/" + month + "/" + year;

            StartTimer();
        }

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
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
            //frmListStaff fliststaff = new frmListStaff();
            //fliststaff.Show();
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

        private void tstrip_pos_Click(object sender, EventArgs e)
        {
            frmAddInvoice fAddInvoice = new frmAddInvoice();
            fAddInvoice.Show();
        }

        private void tambahInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInvoice fAddInvoice = new frmAddInvoice();
            fAddInvoice.Show();
        }

        private void listInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInvoice fListInvoice = new frmListInvoice();
            fListInvoice.Show();
        }

        private void POSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInvoice fAddInvoice = new frmAddInvoice();
            fAddInvoice.Show();
        }

        //wb 20160610
        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.BackupDB();
        }

        //wb 20160610
        private void NotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = null;
                if (p == null)
                {
                    p = new Process();
                    p.StartInfo.FileName = "notepad.exe";
                    p.Start();
                }
                else
                {
                    p.Close();
                    p.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //wb 20160610
        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = null;
                if (p == null)
                {
                    p = new Process();
                    p.StartInfo.FileName = "Calc.exe";
                    p.Start();
                }
                else
                {
                    p.Close();
                    p.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ubahPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUbahPassword fUbahPassword = new frmUbahPassword();
            fUbahPassword.Show();
        }

        private void listStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListStaff fliststaff = new frmListStaff();
            fliststaff.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
