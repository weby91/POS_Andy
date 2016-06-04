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
    public partial class frmAddSatuan : Form
    {
        string result = "";

        public frmAddSatuan()
        {
            InitializeComponent();
        }

        private void frmAddSatuan_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_nama_satuan.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_nama_satuan.Text != string.Empty)
                result = Core.TambahSatuan(txt_nama_satuan.Text.ToString());
            else
                MessageBox.Show("Nama Satuan tidak boleh kosong");

            if (result != "")
                MessageBox.Show(result);
            else
                MessageBox.Show("Tambah Satuan Berhasil");

            txt_nama_satuan.Clear();
        }
    }
}
