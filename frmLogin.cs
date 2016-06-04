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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string result = "";
            frmMain fm = new frmMain();

            result = Validation.validate_Login(txt_username.Text, txt_password.Text);            

            if(result.Contains("Selamat"))
            {
                this.Hide();
                fm.Show();                
            }
            else
            {
                txt_username.Clear();
                txt_password.Clear();
            }

            MessageBox.Show(result);
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
