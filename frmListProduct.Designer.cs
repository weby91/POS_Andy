namespace POS_Andy
{
    partial class frmListProduct
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
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGroupBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.AllowUserToOrderColumns = true;
            this.dgv_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(12, 59);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.Size = new System.Drawing.Size(1060, 302);
            this.dgv_product.TabIndex = 0;
            this.dgv_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grup Berdasarkan :";
            // 
            // cbGroupBy
            // 
            this.cbGroupBy.FormattingEnabled = true;
            this.cbGroupBy.Items.AddRange(new object[] {
            "-",
            "Kategori",
            "Nama Vendor"});
            this.cbGroupBy.Location = new System.Drawing.Point(130, 18);
            this.cbGroupBy.Name = "cbGroupBy";
            this.cbGroupBy.Size = new System.Drawing.Size(121, 21);
            this.cbGroupBy.TabIndex = 2;
            this.cbGroupBy.SelectedIndexChanged += new System.EventHandler(this.cbGroupBy_SelectedIndexChanged);
            // 
            // frmListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 440);
            this.Controls.Add(this.cbGroupBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_product);
            this.Name = "frmListProduct";
            this.Text = "Form List Product";
            this.Load += new System.EventHandler(this.frmListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGroupBy;
    }
}