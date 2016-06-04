namespace POS_Andy
{
    partial class frmAddVendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddVendor));
            this.groupBox_AddVendor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_vendor_name = new System.Windows.Forms.TextBox();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.txt_mobile_no = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox_AddVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_AddVendor
            // 
            this.groupBox_AddVendor.Controls.Add(this.btn_clear);
            this.groupBox_AddVendor.Controls.Add(this.btn_save);
            this.groupBox_AddVendor.Controls.Add(this.txt_email);
            this.groupBox_AddVendor.Controls.Add(this.txt_mobile_no);
            this.groupBox_AddVendor.Controls.Add(this.rtb_address);
            this.groupBox_AddVendor.Controls.Add(this.txt_vendor_name);
            this.groupBox_AddVendor.Controls.Add(this.label4);
            this.groupBox_AddVendor.Controls.Add(this.label3);
            this.groupBox_AddVendor.Controls.Add(this.label2);
            this.groupBox_AddVendor.Controls.Add(this.label1);
            this.groupBox_AddVendor.Location = new System.Drawing.Point(34, 29);
            this.groupBox_AddVendor.Name = "groupBox_AddVendor";
            this.groupBox_AddVendor.Size = new System.Drawing.Size(704, 297);
            this.groupBox_AddVendor.TabIndex = 0;
            this.groupBox_AddVendor.TabStop = false;
            this.groupBox_AddVendor.Text = "Tambah Vendor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Vendor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat Vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Telp/HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txt_vendor_name
            // 
            this.txt_vendor_name.Location = new System.Drawing.Point(143, 39);
            this.txt_vendor_name.Name = "txt_vendor_name";
            this.txt_vendor_name.Size = new System.Drawing.Size(145, 20);
            this.txt_vendor_name.TabIndex = 9;
            // 
            // rtb_address
            // 
            this.rtb_address.Location = new System.Drawing.Point(143, 67);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(186, 72);
            this.rtb_address.TabIndex = 10;
            this.rtb_address.Text = "";
            // 
            // txt_mobile_no
            // 
            this.txt_mobile_no.Location = new System.Drawing.Point(143, 150);
            this.txt_mobile_no.Name = "txt_mobile_no";
            this.txt_mobile_no.Size = new System.Drawing.Size(145, 20);
            this.txt_mobile_no.TabIndex = 11;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(143, 181);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(145, 20);
            this.txt_email.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(143, 221);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 34);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(218, 221);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(58, 34);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // frmAddVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 482);
            this.Controls.Add(this.groupBox_AddVendor);
            this.Name = "frmAddVendor";
            this.Text = "Form Tambah Vendor";
            this.Load += new System.EventHandler(this.frmAddVendor_Load);
            this.groupBox_AddVendor.ResumeLayout(false);
            this.groupBox_AddVendor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_AddVendor;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_mobile_no;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.TextBox txt_vendor_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
    }
}