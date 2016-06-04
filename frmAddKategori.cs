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
    public partial class frmAddKategori : Form
    {
        string result = "";

        public frmAddKategori()
        {
            InitializeComponent();
        }

        private void frmAddKategori_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_category_name.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_category_name.Text != string.Empty)
                result = Core.TambahKategori(txt_category_name.Text.ToString());
            else
                MessageBox.Show("Nama Kategori tidak boleh kosong");

            if (result != "")
                MessageBox.Show(result);
            else
                MessageBox.Show("Tambah Kategori Berhasil");

            txt_category_name.Clear();
        }
    }
}
