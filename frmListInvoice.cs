using POS_Andy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            cbFilter.SelectedIndex = 0;

            populateComboBox();
            populateGridview();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateComboBox();
        }

        void populateComboBox()
        {
            if (cbFilter.SelectedIndex == 0)
            {
                lblFilter.Visible = false;
                txtFilter.Visible = false;

                dtpFrom.Visible = false;
                dtpTo.Visible = false;
                label2.Visible = false;
                lblDari.Visible = false;
                lblNamaPembeli.Visible = false;
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                lblFilter.Visible = true;
                lblFilter.Text = "No. Invoice";
                txtFilter.Text = "";
                txtFilter.Visible = true;

                dtpFrom.Visible = false;
                dtpTo.Visible = false;
                label2.Visible = false;
                lblDari.Visible = false;
                lblNamaPembeli.Visible = false;
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                lblFilter.Visible = false;
                lblFilter.Text = "";
                txtFilter.Visible = false;

                dtpFrom.Visible = true;
                dtpTo.Visible = true;
                lblDari.Visible = true;
                lblNamaPembeli.Visible = false;
                label2.Visible = true;
                label2.Text = "Sampai";
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                lblFilter.Visible = false;
                txtFilter.Visible = true;
                lblDari.Visible = false;
                lblNamaPembeli.Visible = true;

                dtpFrom.Visible = false;
                dtpTo.Visible = false;
                label2.Visible = false;
            }
        }

        void populateGridview()
        {
            string result = "";
            string total_pembelian = "";
            DataTable dt = new DataTable();
            DataTable dtCloned = new DataTable();

            try
            {
                if (cbFilter.SelectedIndex == 0)
                {
                    dt = Core.ListInvoice_ALL();

                    if (dt.Rows.Count > 0)
                    {
                        int total = 0;
                        dtCloned = dt.Clone();
                        dtCloned.Columns["Total Pembelian"].DataType = typeof(string);

                        foreach (DataRow row in dt.Rows)
                        {
                            dtCloned.ImportRow(row);
                        }


                        for (int i = 0; i < dtCloned.Rows.Count; i++)
                        {
                            total = int.Parse(dtCloned.Rows[i]["Total Pembelian"].ToString());
                            total_pembelian = total.ToString("C3", CultureInfo.CreateSpecificCulture("id-ID"));
                            dtCloned.Rows[i].SetField("Total Pembelian", total_pembelian);

                            string[] stringSeparators = new string[] { "Rp" };
                            if (dtCloned.Rows[i]["Total Pembelian"].ToString().Contains("Rp") == true)
                                dtCloned.Rows[i].SetField("Total Pembelian", "Rp " + total_pembelian.Split(stringSeparators, StringSplitOptions.None)[1].Split(',')[0] + ",-");
                        }

                        dgv.DataSource = dtCloned;
                        dgv.Columns["Total Pembelian"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv.Columns["Total Pembelian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        DataGridViewButtonColumn btnColumnDetil = new DataGridViewButtonColumn();
                        DataGridViewButtonColumn btnColumnVoid = new DataGridViewButtonColumn();
                        DataGridViewColumnCollection dgvColumns = dgv.Columns;

                        if (!dgvColumns.Contains("Detil"))
                        {
                            btnColumnDetil.Name = "Detil";
                            btnColumnDetil.HeaderText = "Detil";
                            btnColumnDetil.Text = "Detil";
                            btnColumnDetil.UseColumnTextForButtonValue = true;

                            btnColumnVoid.Name = "Void";
                            btnColumnVoid.HeaderText = "Void";
                            btnColumnVoid.Text = "Void";
                            btnColumnVoid.UseColumnTextForButtonValue = true;
                            dgv.Columns.Insert(dtCloned.Columns.Count, btnColumnDetil);
                            dgv.Columns.Insert(dtCloned.Columns.Count, btnColumnVoid);

                        }

                        dgv.CellContentClick += new DataGridViewCellEventHandler(dgv_CellClick);

                    }

                    dgv.Columns["invoice_id"].Visible = false;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                dt.Dispose();
                dtCloned.Dispose();
            }
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            {

                if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if(dgv.Columns[e.ColumnIndex].HeaderText == "Detil")
                    {
                        frmRptInvoice frm = new frmRptInvoice(dgv.Rows[e.RowIndex].Cells["Invoice Name"].Value.ToString());
                        frm.Show();
                    }
                    else if(dgv.Columns[e.ColumnIndex].HeaderText == "Void")
                    {
                        frmDetailInvoice frm = new frmDetailInvoice(dgv.Rows[e.RowIndex].Cells["Invoice Name"].Value.ToString());
                        frm.Show();
                    }
                    
                }

                //delete row from persisted storage

                //rebind data to persisted storage or remove row directly:
                //if (delGridview == true)
                //    dgv_invoice.Rows.RemoveAt(cRow);
                //else
                //    delGridview = true;
            }
        }
    }
}
