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

            try
            {
                DataTable dt = new DataTable();

                if(invoice_name != "")
                {
                    dt = Core.ListInvoice_FilterByInvoiceName(invoice_name);

                    if(dt.Rows.Count > 0)
                    {
                        if (!dt.Columns.Contains("Alasan Void"))
                        {
                            dt.Columns.Add(new DataColumn("Alasan Void", typeof(string)));
                        }

                        dgv.DataSource = dt;
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgv.Columns["invoice_id"].Visible = false;
                        dgv.Columns["Total Barang"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv.Columns["Total Barang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        DataGridViewButtonColumn btnVoid = new DataGridViewButtonColumn();
                        DataGridViewColumnCollection dgvColumns = dgv.Columns;

                        if (!dgvColumns.Contains("Void"))
                        {
                            btnVoid.Name = "Void";
                            btnVoid.HeaderText = "";
                            btnVoid.Text = "Void";
                            btnVoid.UseColumnTextForButtonValue = true;
                            dgv.Columns.Insert(dt.Columns.Count, btnVoid);
                        }

                        for(int i = 0; i < dgv.Rows.Count; i++)
                        {
                            dgv.Rows[i].Cells["Invoice Name"].ReadOnly = true;
                            dgv.Rows[i].Cells["Nama Barang"].ReadOnly = true;
                            dgv.Rows[i].Cells["Total Barang"].ReadOnly = true;
                        }

                        dgv.CellContentClick += new DataGridViewCellEventHandler(dgv_CellClick);

                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            {
                string result = "";
                string invoice_name = dgv.Rows[e.RowIndex].Cells["Invoice Name"].Value.ToString().Trim();
                string item_name = dgv.Rows[e.RowIndex].Cells["Nama Barang"].Value.ToString().Trim();
                string void_remarks = dgv.Rows[e.RowIndex].Cells["Alasan Void"].Value.ToString().Trim();
                int stock = int.Parse(dgv.Rows[e.RowIndex].Cells["Total Barang"].Value.ToString().Trim());

                if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if(dgv.Rows[e.RowIndex].Cells["Alasan Void"].Value.ToString().Trim() != "")
                    {
                        result = Core.UpdateInvoice_VOID(invoice_name, item_name, void_remarks, stock);
                    }
                    else
                    {
                        MessageBox.Show("Alasan Void harus diisi");
                    }
                }
            }
        }
    }
}
