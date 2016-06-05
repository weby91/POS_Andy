namespace POS_Andy
{
    partial class frmRptInvoice
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
            this.rptInvoice1 = new POS_Andy.rptInvoice();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoiceName = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Invoice";
            // 
            // txtInvoiceName
            // 
            this.txtInvoiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceName.Location = new System.Drawing.Point(369, 17);
            this.txtInvoiceName.Name = "txtInvoiceName";
            this.txtInvoiceName.ReadOnly = true;
            this.txtInvoiceName.Size = new System.Drawing.Size(334, 44);
            this.txtInvoiceName.TabIndex = 2;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(159, 78);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptInvoice1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1025, 605);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmRptInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.txtInvoiceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmRptInvoice";
            this.Text = "Lembar Invoice";
            this.Load += new System.EventHandler(this.frmRptInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private rptInvoice rptInvoice1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceName;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}