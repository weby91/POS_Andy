namespace POS_Andy
{
    partial class frmListVendor
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
            this.dgv_vendor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vendor
            // 
            this.dgv_vendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendor.Location = new System.Drawing.Point(29, 23);
            this.dgv_vendor.Name = "dgv_vendor";
            this.dgv_vendor.Size = new System.Drawing.Size(719, 222);
            this.dgv_vendor.TabIndex = 0;
            // 
            // frmListVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 321);
            this.Controls.Add(this.dgv_vendor);
            this.Name = "frmListVendor";
            this.Text = "Form List Vendor";
            this.Load += new System.EventHandler(this.frmListVendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vendor;
    }
}