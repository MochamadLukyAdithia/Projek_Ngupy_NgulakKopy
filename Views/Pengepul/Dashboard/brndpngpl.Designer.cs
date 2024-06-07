namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    partial class brndpngpl
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
            this.pnlKapasitas = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlPenjemptan = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlHarga = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblhargabrnd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.pnlPenjemptan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlHarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKapasitas
            // 
            this.pnlKapasitas.BackColor = System.Drawing.Color.Transparent;
            this.pnlKapasitas.BorderRadius = 20;
            this.pnlKapasitas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlKapasitas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlKapasitas.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlKapasitas.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(70)))), ((int)(((byte)(43)))));
            this.pnlKapasitas.Location = new System.Drawing.Point(476, 205);
            this.pnlKapasitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlKapasitas.Name = "pnlKapasitas";
            this.pnlKapasitas.Size = new System.Drawing.Size(165, 210);
            this.pnlKapasitas.TabIndex = 11;
            this.pnlKapasitas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKapasitas_Paint);
            // 
            // pnlPenjemptan
            // 
            this.pnlPenjemptan.BackColor = System.Drawing.Color.Transparent;
            this.pnlPenjemptan.BorderRadius = 20;
            this.pnlPenjemptan.Controls.Add(this.pictureBox1);
            this.pnlPenjemptan.Controls.Add(this.pictureBox2);
            this.pnlPenjemptan.Controls.Add(this.label7);
            this.pnlPenjemptan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.Location = new System.Drawing.Point(13, 205);
            this.pnlPenjemptan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPenjemptan.Name = "pnlPenjemptan";
            this.pnlPenjemptan.Size = new System.Drawing.Size(452, 210);
            this.pnlPenjemptan.TabIndex = 10;
            this.pnlPenjemptan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPenjemptan_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ngupy_NgulakKopy.Properties.Resources.Menunggu;
            this.pictureBox1.Location = new System.Drawing.Point(397, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ngupy_NgulakKopy.Properties.Resources.Pengecekan;
            this.pictureBox2.Location = new System.Drawing.Point(397, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Jadwal penjemputan";
            // 
            // pnlHarga
            // 
            this.pnlHarga.BackColor = System.Drawing.Color.Transparent;
            this.pnlHarga.BorderRadius = 20;
            this.pnlHarga.Controls.Add(this.lblTanggal);
            this.pnlHarga.Controls.Add(this.label6);
            this.pnlHarga.Controls.Add(this.lblhargabrnd);
            this.pnlHarga.Controls.Add(this.label4);
            this.pnlHarga.Controls.Add(this.label2);
            this.pnlHarga.Controls.Add(this.label1);
            this.pnlHarga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(70)))), ((int)(((byte)(43)))));
            this.pnlHarga.Location = new System.Drawing.Point(13, 2);
            this.pnlHarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHarga.Name = "pnlHarga";
            this.pnlHarga.Size = new System.Drawing.Size(628, 190);
            this.pnlHarga.TabIndex = 9;
            this.pnlHarga.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHarga_Paint);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.ForeColor = System.Drawing.Color.White;
            this.lblTanggal.Location = new System.Drawing.Point(21, 84);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(92, 21);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "20/05/2024";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(148, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "/Kg";
            // 
            // lblhargabrnd
            // 
            this.lblhargabrnd.AutoSize = true;
            this.lblhargabrnd.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhargabrnd.ForeColor = System.Drawing.Color.White;
            this.lblhargabrnd.Location = new System.Drawing.Point(58, 138);
            this.lblhargabrnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhargabrnd.Name = "lblhargabrnd";
            this.lblhargabrnd.Size = new System.Drawing.Size(55, 21);
            this.lblhargabrnd.TabIndex = 0;
            this.lblhargabrnd.Text = "50000";
            this.lblhargabrnd.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Terbaru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harga Kopi";
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // brndpngpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlKapasitas);
            this.Controls.Add(this.pnlPenjemptan);
            this.Controls.Add(this.pnlHarga);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "brndpngpl";
            this.Size = new System.Drawing.Size(654, 433);
            this.Load += new System.EventHandler(this.brndpngpl_Load);
            this.pnlPenjemptan.ResumeLayout(false);
            this.pnlPenjemptan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlHarga.ResumeLayout(false);
            this.pnlHarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlKapasitas;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlPenjemptan;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlHarga;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblhargabrnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}
