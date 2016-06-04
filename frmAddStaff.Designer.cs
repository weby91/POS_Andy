namespace POS_Andy
{
    partial class frmAddStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStaff));
            this.groupBoxTambahStaff = new System.Windows.Forms.GroupBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_mobile_no = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_mobile_no = new System.Windows.Forms.TextBox();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cb_level = new System.Windows.Forms.ComboBox();
            this.groupBoxTambahStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTambahStaff
            // 
            this.groupBoxTambahStaff.Controls.Add(this.cb_level);
            this.groupBoxTambahStaff.Controls.Add(this.btn_clear);
            this.groupBoxTambahStaff.Controls.Add(this.btn_save);
            this.groupBoxTambahStaff.Controls.Add(this.rtb_address);
            this.groupBoxTambahStaff.Controls.Add(this.txt_mobile_no);
            this.groupBoxTambahStaff.Controls.Add(this.txt_lastname);
            this.groupBoxTambahStaff.Controls.Add(this.txt_firstname);
            this.groupBoxTambahStaff.Controls.Add(this.txt_password);
            this.groupBoxTambahStaff.Controls.Add(this.txt_username);
            this.groupBoxTambahStaff.Controls.Add(this.lbl_level);
            this.groupBoxTambahStaff.Controls.Add(this.lbl_mobile_no);
            this.groupBoxTambahStaff.Controls.Add(this.lbl_address);
            this.groupBoxTambahStaff.Controls.Add(this.lbl_lastname);
            this.groupBoxTambahStaff.Controls.Add(this.lbl_firstname);
            this.groupBoxTambahStaff.Controls.Add(this.lbl_password);
            this.groupBoxTambahStaff.Controls.Add(this.lbl_username);
            this.groupBoxTambahStaff.Location = new System.Drawing.Point(29, 40);
            this.groupBoxTambahStaff.Name = "groupBoxTambahStaff";
            this.groupBoxTambahStaff.Size = new System.Drawing.Size(686, 322);
            this.groupBoxTambahStaff.TabIndex = 0;
            this.groupBoxTambahStaff.TabStop = false;
            this.groupBoxTambahStaff.Text = "Tambah Staff";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(36, 30);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(36, 59);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(36, 89);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(70, 13);
            this.lbl_firstname.TabIndex = 2;
            this.lbl_firstname.Text = "Nama Depan";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(36, 117);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(83, 13);
            this.lbl_lastname.TabIndex = 3;
            this.lbl_lastname.Text = "Nama Belakang";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(36, 142);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(39, 13);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "Alamat";
            // 
            // lbl_mobile_no
            // 
            this.lbl_mobile_no.AutoSize = true;
            this.lbl_mobile_no.Location = new System.Drawing.Point(341, 30);
            this.lbl_mobile_no.Name = "lbl_mobile_no";
            this.lbl_mobile_no.Size = new System.Drawing.Size(83, 13);
            this.lbl_mobile_no.TabIndex = 5;
            this.lbl_mobile_no.Text = "No. Handphone";
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Location = new System.Drawing.Point(341, 59);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(33, 13);
            this.lbl_level.TabIndex = 6;
            this.lbl_level.Text = "Level";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(133, 27);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(120, 20);
            this.txt_username.TabIndex = 7;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(133, 56);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(120, 20);
            this.txt_password.TabIndex = 8;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(133, 86);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(120, 20);
            this.txt_firstname.TabIndex = 9;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(133, 114);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(120, 20);
            this.txt_lastname.TabIndex = 10;
            // 
            // txt_mobile_no
            // 
            this.txt_mobile_no.Location = new System.Drawing.Point(447, 27);
            this.txt_mobile_no.Name = "txt_mobile_no";
            this.txt_mobile_no.Size = new System.Drawing.Size(120, 20);
            this.txt_mobile_no.TabIndex = 11;
            // 
            // rtb_address
            // 
            this.rtb_address.Location = new System.Drawing.Point(133, 142);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(183, 78);
            this.rtb_address.TabIndex = 13;
            this.rtb_address.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(133, 241);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 34);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(209, 241);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(58, 34);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // cb_level
            // 
            this.cb_level.FormattingEnabled = true;
            this.cb_level.Items.AddRange(new object[] {
            "SUPERADMIN",
            "STAFF"});
            this.cb_level.Location = new System.Drawing.Point(447, 59);
            this.cb_level.Name = "cb_level";
            this.cb_level.Size = new System.Drawing.Size(121, 21);
            this.cb_level.TabIndex = 16;
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 386);
            this.Controls.Add(this.groupBoxTambahStaff);
            this.Name = "frmAddStaff";
            this.Text = "Form Tambah Staff";
            this.Load += new System.EventHandler(this.frmAddStaff_Load);
            this.groupBoxTambahStaff.ResumeLayout(false);
            this.groupBoxTambahStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTambahStaff;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_mobile_no;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.TextBox txt_mobile_no;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cb_level;
    }
}