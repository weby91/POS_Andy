using CrystalDecisions.Shared;
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
            DataTable dt = new DataTable();
            DataTable dtMaster = new DataTable();
            //this.crystalReportViewer1.RefreshReport();

            //ParameterFields paramFields = new ParameterFields();
            //ParameterField inv_name = new ParameterField();
            //inv_name.ParameterFieldName = "inv_name"; //year is Crystal Report Parameter name.
            //inv_name.CurrentValues.Add(txtInvoiceName.Text);
            //paramFields.Add(inv_name);
            //crystalReportViewer1.ParameterFieldInfo = paramFields;
            //crystalReportViewer1.ReportSource = invoiceReport;

            CenterToScreen();
            WindowState = FormWindowState.Maximized;

            try
            {
                if(txtInvoiceName.Text != "")
                {
                    string invoice_name = txtInvoiceName.Text;
                    dt = Core.ListInvoiceReport_FilterByInvoiceName(invoice_name);
                    dtMaster = Core.ListInvoiceMaster_FilterByInvoiceName(invoice_name);

                    if (dt.Rows.Count > 0)
                    {
                        invoiceReport.SetParameterValue("invoice_name_param", invoice_name);
                        invoiceReport.SetParameterValue("invoice_date_param", dt.Rows[0]["invoice_dt"].ToString());

                        invoiceReport.SetParameterValue("buyer_name_param", dtMaster.Rows[0]["Nama Pembeli"].ToString());
                        invoiceReport.SetParameterValue("company_name_param", dtMaster.Rows[0]["company_name"].ToString());
                        invoiceReport.SetParameterValue("buyer_address_param", dtMaster.Rows[0]["buyer_address"].ToString());
                        invoiceReport.SetParameterValue("buyer_contact_no_param", dtMaster.Rows[0]["buyer_contact_no"].ToString());
                        invoiceReport.SetParameterValue("payment_method_param", dtMaster.Rows[0]["payment_method"].ToString());
                        invoiceReport.SetParameterValue("purchase_total_param", dtMaster.Rows[0]["Total Pembelian"].ToString());


                        invoiceReport.SetParameterValue("item_name_param", dt.Rows[0]["Nama Barang"].ToString());
                        invoiceReport.SetParameterValue("jumlah_barang_param", dt.Rows[0]["Total Barang"].ToString());



                    }


                    crystalReportViewer1.ReportSource = invoiceReport;
                }
            }
            catch(Exception ex)
            {

            }

        }
    }
}
