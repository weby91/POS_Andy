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
    public partial class frmListInvoice : Form
    {
        public frmListInvoice()
        {
            InitializeComponent();

            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd-MM-yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "dd-MM-yyyy";
        }

        private void frmListInvoice_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
