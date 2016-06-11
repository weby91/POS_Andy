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
            cbBulan.SelectedIndex = 0;
            cbTahun.SelectedIndex = 0;

            try
            {
                dtpHarian.Format = DateTimePickerFormat.Custom;
                dtpHarian.CustomFormat = "dd-MM-yyyy";

                reportLaba.SetParameterValue("judul_report_param", "Report " + cbPeriode.SelectedItem.ToString());
                reportLaba.SetParameterValue("total_penjualan_param", 0);
                reportLaba.SetParameterValue("total_modal_param", 0);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                crystalReportViewer1.ReportSource = reportLaba;
                crystalReportViewer1.Visible = false;
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
            string total_penjualan = "";
            string total_modal = "";
            rptLaba reportLaba = new rptLaba();
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

                    if (dt.Rows.Count > 0 && dt.Rows[0]["total_penjualan"].ToString() != "")
                    {
                        total_penjualan = dt.Rows[0]["total_penjualan"].ToString();
                        total_modal = dt.Rows[0]["total_modal"].ToString();

                        reportLaba.SetParameterValue("judul_report_param", "Report " + cbPeriode.SelectedItem.ToString());
                        reportLaba.SetParameterValue("total_penjualan_param", total_penjualan);
                        reportLaba.SetParameterValue("total_modal_param", total_modal);

                        crystalReportViewer1.ReportSource = reportLaba;
                        crystalReportViewer1.Visible = true;

                    }
                    else
                    {
                        result = "Tidak ada penjualan di tanggal tersebut";
                        crystalReportViewer1.Visible = false;
                    }
                }
                else if(filter_type == "Mingguan")
                {
                    dt = Core.SelectProfit(filter_type, day.ToString(), month.ToString(), year.ToString());

                    if (dt.Rows.Count > 0 && dt.Rows[0]["total_penjualan"].ToString() != "")
                    {
                        total_penjualan = dt.Rows[0]["total_penjualan"].ToString();
                        total_modal = dt.Rows[0]["total_modal"].ToString();

                        reportLaba.SetParameterValue("judul_report_param", "Report " + cbPeriode.SelectedItem.ToString());
                        reportLaba.SetParameterValue("total_penjualan_param", total_penjualan);
                        reportLaba.SetParameterValue("total_modal_param", total_modal);

                        crystalReportViewer1.ReportSource = reportLaba;
                        crystalReportViewer1.Visible = true;
                    }
                    else
                    {
                        result = "Tidak ada penjualan dalam 1 minggu terakhir";
                        crystalReportViewer1.Visible = false;
                    }
                }
                else if (filter_type == "Bulanan")
                {
                    switch (cbBulan.SelectedItem.ToString())
                    {
                        case "Januari":
                            month = 1;
                            break;
                        case "Februari":
                            month = 2;
                            break;
                        case "Maret":
                            month = 3;
                            break;
                        case "April":
                            month = 4;
                            break;
                        case "Mei":
                            month = 5;
                            break;
                        case "Juni":
                            month = 6;
                            break;
                        case "Juli":
                            month = 7;
                            break;
                        case "Agustus":
                            month = 8;
                            break;
                        case "September":
                            month = 9;
                            break;
                        case "Oktober":
                            month = 10;
                            break;
                        case "November":
                            month = 11;
                            break;
                        case "Desember":
                            month = 12;
                            break;
                    }

                    dt = Core.SelectProfit(filter_type, day.ToString(), month.ToString(), cbTahun.SelectedItem.ToString());

                    if (dt.Rows.Count > 0 && dt.Rows[0]["total_penjualan"].ToString() != "")
                    {
                        total_penjualan = dt.Rows[0]["total_penjualan"].ToString();
                        total_modal = dt.Rows[0]["total_modal"].ToString();

                        reportLaba.SetParameterValue("judul_report_param", "Report " + cbPeriode.SelectedItem.ToString());
                        reportLaba.SetParameterValue("total_penjualan_param", total_penjualan);
                        reportLaba.SetParameterValue("total_modal_param", total_modal);

                        crystalReportViewer1.ReportSource = reportLaba;
                        crystalReportViewer1.Visible = true;
                    }
                    else
                    {
                        result = "Tidak ada penjualan di bulan " + cbBulan.SelectedItem.ToString() + " tahun " + cbTahun.SelectedItem.ToString();
                        crystalReportViewer1.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            finally
            {
                if (result != "")
                    MessageBox.Show(result);
            }
        }
    }
}
