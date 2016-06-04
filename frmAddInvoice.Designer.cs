namespace POS_Andy
{
    partial class frmAddInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInvoice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelTab = new System.Windows.Forms.Button();
            this.cbTabPages = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbAlamat = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelTab);
            this.groupBox1.Controls.Add(this.cbTabPages);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnNewTab);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 589);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDelTab
            // 
            this.btnDelTab.Location = new System.Drawing.Point(367, 19);
            this.btnDelTab.Name = "btnDelTab";
            this.btnDelTab.Size = new System.Drawing.Size(75, 23);
            this.btnDelTab.TabIndex = 7;
            this.btnDelTab.Text = "Hapus";
            this.btnDelTab.UseVisualStyleBackColor = true;
            this.btnDelTab.Click += new System.EventHandler(this.btnDelTab_Click);
            // 
            // cbTabPages
            // 
            this.cbTabPages.FormattingEnabled = true;
            this.cbTabPages.Location = new System.Drawing.Point(228, 21);
            this.cbTabPages.Name = "cbTabPages";
            this.cbTabPages.Size = new System.Drawing.Size(121, 21);
            this.cbTabPages.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hapus Tab";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(16, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 571);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tambah Invoice";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(17, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 452);
            this.tabControl1.TabIndex = 3;
            // 
            // btnNewTab
            // 
            this.btnNewTab.Location = new System.Drawing.Point(16, 19);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(108, 23);
            this.btnNewTab.TabIndex = 2;
            this.btnNewTab.Text = "Tambah Tab Baru";
            this.btnNewTab.UseVisualStyleBackColor = true;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(0, 0);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            // 
            // rtbAlamat
            // 
            this.rtbAlamat.Location = new System.Drawing.Point(0, 0);
            this.rtbAlamat.Name = "rtbAlamat";
            this.rtbAlamat.Size = new System.Drawing.Size(100, 96);
            this.rtbAlamat.TabIndex = 0;
            this.rtbAlamat.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(0, 0);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(0, 0);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(100, 20);
            this.txtContactNo.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(878, 488);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(57, 34);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddInvoice";
            this.Text = "Form Tambah Invoice";
            this.Load += new System.EventHandler(this.frmAddInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbAlamat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTabPages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelTab;
        private System.Windows.Forms.Button btn_save;
    }
}