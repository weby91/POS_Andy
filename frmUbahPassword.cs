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
    public partial class frmUbahPassword : Form
    {
        public frmUbahPassword()
        {
            InitializeComponent();
        }

        private void frmUbahPassword_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            txtUserid.Text = Core.LogInfo.userid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errMsg = "";

            try
            {
                if (txtPasswordLama.Text == "")
                    errMsg = "Password Lama tidak boleh kosong";
                if (txtPasswordBaru.Text == "")
                    errMsg = "Password Baru tidak boleh kosong";
                if (txtConfirmPassword.Text != txtPasswordBaru.Text)
                    errMsg = "Confirm password harus sama dengan password baru";

                if (errMsg == "")
                {
                    errMsg = Validation.validate_Login(txtUserid.Text, txtPasswordLama.Text);

                    if (errMsg.Contains("Selamat"))
                    {
                        errMsg = "";
                        errMsg = Core.UpdateUserPassword(txtUserid.Text, txtPasswordBaru.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                if (errMsg == "")
                {
                    MessageBox.Show("Update Password berhasil");
                    this.Close();
                }else
                {
                    MessageBox.Show(errMsg);
                }
            }
            
        }
    }
}
