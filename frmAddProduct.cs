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
    public partial class frmAddProduct : Form
    {
        string result = "";

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            result = Core.TambahProduk(txt_item_name.Text, int.Parse(txt_stok.Text), int.Parse(txt_cost_price.Text)
                                    , int.Parse(txt_retail_price.Text), int.Parse(txt_wholesale_price.Text)
                                    ,int.Parse(txt_wholesale_number.Text), cbVendor.SelectedValue.ToString()
                                    ,cbKategori.SelectedValue.ToString(), cbSatuan.SelectedValue.ToString()
                                    , int.Parse(txt_Isi.Text));

            if (result == "")
            {
                MessageBox.Show("Product berhasil ditambahkan");
                this.Hide();
            }
            else
                MessageBox.Show(result);
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            DataTable dtKategori = new DataTable("Kategori");
            DataTable dtSatuan = new DataTable("Satuan");
            DataTable dtVendor = new DataTable("Vendor");

            dtKategori = Core.ListKategori();
            dtSatuan = Core.ListSatuan();
            dtVendor = Core.ListVendor();

            cbKategori.DataSource = dtKategori;
            cbKategori.DisplayMember = "category_name";
            cbKategori.ValueMember = "category_name";
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;

            cbSatuan.DataSource = dtSatuan;
            cbSatuan.DisplayMember = "nama_satuan";
            cbSatuan.ValueMember = "nama_satuan";
            cbSatuan.DropDownStyle = ComboBoxStyle.DropDownList;

            cbVendor.DataSource = dtVendor;
            cbVendor.DisplayMember = "vendor_name";
            cbVendor.ValueMember = "vendor_name";
            cbVendor.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void groupBox_AddProduct_Enter(object sender, EventArgs e)
        {

        }
    }
}
