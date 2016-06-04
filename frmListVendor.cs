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
    public partial class frmListVendor : Form
    {
        public frmListVendor()
        {
            InitializeComponent();
        }

        private void frmListVendor_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            DataTable dt = new DataTable();

            dt = Core.ListVendor();
            dgv_vendor.DataSource = dt;
        }
    }
}
