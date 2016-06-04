using POS_Andy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Andy
{
    public partial class frmListProduct : Form
    {
        DataTable dt = new DataTable();

        public frmListProduct()
        {
            InitializeComponent();
            dgv_product.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgv_product_ColumnHeaderMouseClick);
            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_product.AllowUserToResizeColumns = true;
        }

        private void frmListProduct_Load(object sender, EventArgs e)
        {
            CenterToScreen();            

            cbGroupBy.DropDownStyle = ComboBoxStyle.DropDownList;            

            dt = Core.ListProduct();

            dgv_product.DataSource = dt;
            stockWarning();
            dgv_product.AllowUserToOrderColumns = true;
            cbGroupBy.SelectedIndex = 0;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void cbGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = Core.ListProduct();

                if (cbGroupBy.Text != "-")
                {
                    if (cbGroupBy.Text == "Kategori")
                    {
                        dt = dt.AsEnumerable()
                               .GroupBy(r => new { Col1 = r["category"] })
                               .Select(g => g.OrderBy(r => r["item_name"]).First())
                               .CopyToDataTable();
                    }
                    else if (cbGroupBy.Text == "Nama Vendor")
                    {
                        dt = dt.AsEnumerable()
                               .GroupBy(r => new { Col1 = r["vendor_name"] })
                               .Select(g => g.OrderBy(r => r["item_name"]).First())
                               .CopyToDataTable();
                    }
                }

                dgv_product.DataSource = dt;
                stockWarning();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            } 
        }

        private void stockWarning()
        {
            try
            {
                if(dt.Rows.Count > 0)
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        if(int.Parse(dt.Rows[i]["stock"].ToString()) <= 5 && int.Parse(dt.Rows[i]["stock"].ToString()) > 0) 
                        {
                            dgv_product.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else if(int.Parse(dt.Rows[i]["stock"].ToString()) == 0)
                        {
                            dgv_product.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stockWarning();
        }

        void dgv_product_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            stockWarning();
        }
    }
}
