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
    public partial class frmRptLaba : Form
    {
        public frmRptLaba()
        {
            InitializeComponent();
        }

        private void frmRptLaba_Load(object sender, EventArgs e)
        {
            try
            {
                CenterToScreen();
                rptLaba reportLaba = new rptLaba();

                cbPeriode.SelectedIndex = 0;

                dtpHarian.Format = DateTimePickerFormat.Custom;
                dtpHarian.CustomFormat = "dd-MM-yyyy";

                reportLaba.SetParameterValue("judulreport", cbPeriode.SelectedValue.ToString());

                crystalReportViewer1.ReportSource = reportLaba;

            }
            catch (Exception ex)
            {
                
            }
            
        }
    }
}
