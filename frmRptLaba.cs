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
    public partial class frmRptLaba : Form
    {
        public frmRptLaba()
        {
            InitializeComponent();
        }

        private void frmRptLaba_Load(object sender, EventArgs e)
        {
            rptLaba reportLaba = new rptLaba();
            CenterToScreen();
            cbPeriode.SelectedIndex = 0;

            try
            {
                dtpHarian.Format = DateTimePickerFormat.Custom;
                dtpHarian.CustomFormat = "dd-MM-yyyy";

                reportLaba.SetParameterValue("judul_report_param", "Report " + cbPeriode.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                crystalReportViewer1.ReportSource = reportLaba;
            }

        }

        private void cbPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbPeriode.SelectedItem.ToString() == "Harian")
                {
                    gbHarian.Visible = true;
                    gbBulanan.Visible = false;
                }
                else if (cbPeriode.SelectedItem.ToString() == "Mingguan")
                {
                    gbHarian.Visible = false;
                    gbBulanan.Visible = false;
                }
                else if (cbPeriode.SelectedItem.ToString() == "Bulanan")
                {
                    gbHarian.Visible = false;
                    gbBulanan.Visible = true;
                    cbBulan.SelectedIndex = 0;
                    cbTahun.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string filter_type = cbPeriode.SelectedItem.ToString();
            string result = "";
            int day, month, year;
            DataTable dt = new DataTable();

            try
            {
                day = 0;
                month = 0;
                year = 0;

                if(filter_type == "Harian")
                {
                    day = int.Parse(dtpHarian.Text.Split('-')[0]);
                    month = int.Parse(dtpHarian.Text.Split('-')[1]);
                    year = int.Parse(dtpHarian.Text.Split('-')[2]);

                    dt = Core.SelectProfit(filter_type, day.ToString(), month.ToString(), year.ToString());

                    if (dt.Rows.Count > 0)
                    {

                    }

                }
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
