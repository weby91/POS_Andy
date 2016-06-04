namespace POS_Andy
{
    partial class frmImportProduct
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
            this.btn_pilih_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.lbl_barang_baru = new System.Windows.Forms.Label();
            this.lbl_barang_baru_value = new System.Windows.Forms.Label();
            this.lbl_tbh_stok = new System.Windows.Forms.Label();
            this.lbl_tbh_stok_value = new System.Windows.Forms.Label();
            this.lbl_tot_barang = new System.Windows.Forms.Label();
            this.lbl_total_barang_value = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pilih_file
            // 
            this.btn_pilih_file.Location = new System.Drawing.Point(12, 12);
            this.btn_pilih_file.Name = "btn_pilih_file";
            this.btn_pilih_file.Size = new System.Drawing.Size(75, 23);
            this.btn_pilih_file.TabIndex = 0;
            this.btn_pilih_file.Text = "Pilih File";
            this.btn_pilih_file.UseVisualStyleBackColor = true;
            this.btn_pilih_file.Click += new System.EventHandler(this.btn_pilih_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(12, 65);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.Size = new System.Drawing.Size(686, 200);
            this.dgv_result.TabIndex = 1;
            this.dgv_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_result_CellContentClick);
            // 
            // lbl_barang_baru
            // 
            this.lbl_barang_baru.AutoSize = true;
            this.lbl_barang_baru.Location = new System.Drawing.Point(359, 17);
            this.lbl_barang_baru.Name = "lbl_barang_baru";
            this.lbl_barang_baru.Size = new System.Drawing.Size(78, 13);
            this.lbl_barang_baru.TabIndex = 2;
            this.lbl_barang_baru.Text = "Barang Baru :  ";
            // 
            // lbl_barang_baru_value
            // 
            this.lbl_barang_baru_value.AutoSize = true;
            this.lbl_barang_baru_value.Location = new System.Drawing.Point(440, 17);
            this.lbl_barang_baru_value.Name = "lbl_barang_baru_value";
            this.lbl_barang_baru_value.Size = new System.Drawing.Size(10, 13);
            this.lbl_barang_baru_value.TabIndex = 3;
            this.lbl_barang_baru_value.Text = " ";
            // 
            // lbl_tbh_stok
            // 
            this.lbl_tbh_stok.AutoSize = true;
            this.lbl_tbh_stok.Location = new System.Drawing.Point(475, 17);
            this.lbl_tbh_stok.Name = "lbl_tbh_stok";
            this.lbl_tbh_stok.Size = new System.Drawing.Size(76, 13);
            this.lbl_tbh_stok.TabIndex = 4;
            this.lbl_tbh_stok.Tag = "";
            this.lbl_tbh_stok.Text = "Update Stok : ";
            // 
            // lbl_tbh_stok_value
            // 
            this.lbl_tbh_stok_value.AutoSize = true;
            this.lbl_tbh_stok_value.Location = new System.Drawing.Point(561, 17);
            this.lbl_tbh_stok_value.Name = "lbl_tbh_stok_value";
            this.lbl_tbh_stok_value.Size = new System.Drawing.Size(10, 13);
            this.lbl_tbh_stok_value.TabIndex = 5;
            this.lbl_tbh_stok_value.Text = " ";
            // 
            // lbl_tot_barang
            // 
            this.lbl_tot_barang.AutoSize = true;
            this.lbl_tot_barang.Location = new System.Drawing.Point(590, 17);
            this.lbl_tot_barang.Name = "lbl_tot_barang";
            this.lbl_tot_barang.Size = new System.Drawing.Size(77, 13);
            this.lbl_tot_barang.TabIndex = 6;
            this.lbl_tot_barang.Tag = "";
            this.lbl_tot_barang.Text = "Total Barang : ";
            // 
            // lbl_total_barang_value
            // 
            this.lbl_total_barang_value.AutoSize = true;
            this.lbl_total_barang_value.Location = new System.Drawing.Point(673, 17);
            this.lbl_total_barang_value.Name = "lbl_total_barang_value";
            this.lbl_total_barang_value.Size = new System.Drawing.Size(10, 13);
            this.lbl_total_barang_value.TabIndex = 7;
            this.lbl_total_barang_value.Text = " ";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(106, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 311);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lbl_total_barang_value);
            this.Controls.Add(this.lbl_tot_barang);
            this.Controls.Add(this.lbl_tbh_stok_value);
            this.Controls.Add(this.lbl_tbh_stok);
            this.Controls.Add(this.lbl_barang_baru_value);
            this.Controls.Add(this.lbl_barang_baru);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.btn_pilih_file);
            this.Name = "frmImportProduct";
            this.Text = "frmImportProduct";
            this.Load += new System.EventHandler(this.frmImportProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pilih_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Label lbl_barang_baru;
        private System.Windows.Forms.Label lbl_barang_baru_value;
        private System.Windows.Forms.Label lbl_tbh_stok;
        private System.Windows.Forms.Label lbl_tbh_stok_value;
        private System.Windows.Forms.Label lbl_tot_barang;
        private System.Windows.Forms.Label lbl_total_barang_value;
        private System.Windows.Forms.Button btnImport;
    }
}