﻿namespace Ngupy_NgulakKopy.Views.Pusat.Dashboard
{
    partial class RiwayatPusat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHarga = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlPenjemptan = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlPenjemptan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHarga
            // 
            this.pnlHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHarga.BackColor = System.Drawing.Color.Transparent;
            this.pnlHarga.BorderRadius = 10;
            this.pnlHarga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(70)))), ((int)(((byte)(43)))));
            this.pnlHarga.Location = new System.Drawing.Point(46, 49);
            this.pnlHarga.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHarga.Name = "pnlHarga";
            this.pnlHarga.Size = new System.Drawing.Size(813, 90);
            this.pnlHarga.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlPenjemptan
            // 
            this.pnlPenjemptan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPenjemptan.BackColor = System.Drawing.Color.Transparent;
            this.pnlPenjemptan.BorderRadius = 20;
            this.pnlPenjemptan.Controls.Add(this.dataGridView1);
            this.pnlPenjemptan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.Location = new System.Drawing.Point(46, 153);
            this.pnlPenjemptan.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPenjemptan.Name = "pnlPenjemptan";
            this.pnlPenjemptan.Size = new System.Drawing.Size(813, 402);
            this.pnlPenjemptan.TabIndex = 13;
            // 
            // RiwayatPusat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlPenjemptan);
            this.Controls.Add(this.pnlHarga);
            this.Name = "RiwayatPusat";
            this.Size = new System.Drawing.Size(905, 605);
            this.Load += new System.EventHandler(this.RiwayatPusat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlPenjemptan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlHarga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlPenjemptan;
    }
}
