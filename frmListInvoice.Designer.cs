namespace POS_Andy
{
    partial class frmListInvoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoice_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sampai";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(339, 10);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(128, 20);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Value = new System.DateTime(2016, 5, 26, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(542, 10);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(128, 20);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Value = new System.DateTime(2016, 5, 26, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoice_no,
            this.invoice_dt,
            this.item_name,
            this.vendor_name,
            this.total_price,
            this.buyer_name});
            this.dataGridView1.Location = new System.Drawing.Point(15, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // invoice_no
            // 
            this.invoice_no.HeaderText = "No. Invoice";
            this.invoice_no.Name = "invoice_no";
            this.invoice_no.ReadOnly = true;
            // 
            // invoice_dt
            // 
            this.invoice_dt.HeaderText = "Tanggal";
            this.invoice_dt.Name = "invoice_dt";
            this.invoice_dt.ReadOnly = true;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Nama Barang";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // vendor_name
            // 
            this.vendor_name.HeaderText = "Nama Vendor";
            this.vendor_name.Name = "vendor_name";
            this.vendor_name.ReadOnly = true;
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Total";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            // 
            // buyer_name
            // 
            this.buyer_name.HeaderText = "Nama Pembeli";
            this.buyer_name.Name = "buyer_name";
            this.buyer_name.ReadOnly = true;
            // 
            // frmListInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 493);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListInvoice";
            this.Text = "Form Daftar Invoice";
            this.Load += new System.EventHandler(this.frmListInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyer_name;
    }
}