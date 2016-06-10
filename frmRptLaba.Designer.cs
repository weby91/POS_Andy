namespace POS_Andy
{
    partial class frmRptLaba
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPeriode = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gbHarian = new System.Windows.Forms.GroupBox();
            this.dtpHarian = new System.Windows.Forms.DateTimePicker();
            this.btnCari = new System.Windows.Forms.Button();
            this.rptLaba1 = new POS_Andy.rptLaba();
            this.gbHarian.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periode";
            // 
            // cbPeriode
            // 
            this.cbPeriode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriode.FormattingEnabled = true;
            this.cbPeriode.Items.AddRange(new object[] {
            "Harian",
            "Mingguan",
            "Bulanan"});
            this.cbPeriode.Location = new System.Drawing.Point(367, 48);
            this.cbPeriode.Name = "cbPeriode";
            this.cbPeriode.Size = new System.Drawing.Size(181, 28);
            this.cbPeriode.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 212);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptLaba1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(760, 150);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // gbHarian
            // 
            this.gbHarian.Controls.Add(this.dtpHarian);
            this.gbHarian.Location = new System.Drawing.Point(367, 82);
            this.gbHarian.Name = "gbHarian";
            this.gbHarian.Size = new System.Drawing.Size(200, 43);
            this.gbHarian.TabIndex = 3;
            this.gbHarian.TabStop = false;
            // 
            // dtpHarian
            // 
            this.dtpHarian.Location = new System.Drawing.Point(0, 16);
            this.dtpHarian.Name = "dtpHarian";
            this.dtpHarian.Size = new System.Drawing.Size(196, 26);
            this.dtpHarian.TabIndex = 0;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(367, 141);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 30);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // frmRptLaba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 607);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.gbHarian);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cbPeriode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRptLaba";
            this.Text = "frmRptLaba";
            this.Load += new System.EventHandler(this.frmRptLaba_Load);
            this.gbHarian.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPeriode;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox gbHarian;
        private System.Windows.Forms.DateTimePicker dtpHarian;
        private System.Windows.Forms.Button btnCari;
        private rptLaba rptLaba1;
    }
}