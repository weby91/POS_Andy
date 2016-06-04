using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Andy.Classes;

namespace POS_Andy
{
    public partial class frmAddStaff : Form
    {
        string result = "";

        public frmAddStaff()
        {
            InitializeComponent();
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            result = Core.TambahStaff(txt_username.Text, txt_password.Text, txt_firstname.Text, txt_lastname.Text,
                            rtb_address.Text, txt_mobile_no.Text, cb_level.Text);

            if (result == "")
            {
                MessageBox.Show("Staff berhasil ditambahkan");
                this.Hide();
            }
            else
                MessageBox.Show(result);
        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
