using POS_Andy.Classes;
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
    public partial class frmAddVendor : Form
    {
        string result = "";

        public frmAddVendor()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            result = Core.TambahVendor(txt_vendor_name.Text, rtb_address.Text, txt_mobile_no.Text, txt_email.Text);

            if (result == "")
            {
                MessageBox.Show("Vendor berhasil ditambahkan");
                this.Hide();
            }
            else
                MessageBox.Show(result);
        }

        private void frmAddVendor_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
