﻿namespace POS_Andy
{
    partial class frmTransaction
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
            this.groupBox_Transaction = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBox_Transaction
            // 
            this.groupBox_Transaction.Location = new System.Drawing.Point(30, 32);
            this.groupBox_Transaction.Name = "groupBox_Transaction";
            this.groupBox_Transaction.Size = new System.Drawing.Size(683, 317);
            this.groupBox_Transaction.TabIndex = 0;
            this.groupBox_Transaction.TabStop = false;
            this.groupBox_Transaction.Text = "Transaction";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 456);
            this.Controls.Add(this.groupBox_Transaction);
            this.Name = "frmTransaction";
            this.Text = "frmTransaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Transaction;
    }
}