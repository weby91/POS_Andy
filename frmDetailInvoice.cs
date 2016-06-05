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
    public partial class frmDetailInvoice : Form
    {
        string invoice_name = "";

        public frmDetailInvoice(string inv_name)
        {
            InitializeComponent();
            if (inv_name != "")
                invoice_name = inv_name;
        }

        private void frmDetailInvoice_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
