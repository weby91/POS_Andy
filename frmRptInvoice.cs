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
    public partial class frmRptInvoice : Form
    {
        public frmRptInvoice(string invoice_name)
        {
            InitializeComponent();
            if (invoice_name != "")
                txtInvoiceName.Text = invoice_name;
        }

        private void frmRptInvoice_Load(object sender, EventArgs e)
        {
            rptInvoice invoiceReport = new rptInvoice();
            //crystalReportViewer1.ReportSource = invoiceReport;

            CenterToScreen();
            WindowState = FormWindowState.Maximized;

            try
            {
                if(txtInvoiceName.Text != "")
                {
                    invoiceReport.SetParameterValue("invoice_name_param", txtInvoiceName.Text);
                }
            }
            catch(Exception ex)
            {

            }

        }
    }
}
