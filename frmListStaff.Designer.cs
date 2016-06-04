namespace POS_Andy
{
    partial class frmListStaff
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
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_staff
            // 
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(12, 31);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.Size = new System.Drawing.Size(778, 150);
            this.dgv_staff.TabIndex = 0;
            // 
            // frmListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 261);
            this.Controls.Add(this.dgv_staff);
            this.Name = "frmListStaff";
            this.Text = "frmListStaff";
            this.Load += new System.EventHandler(this.frmListStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_staff;
    }
}