namespace Ngupy_NgulakKopy.Views.Pengepul.Dashboard
{
    partial class RiwayatPengepul
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPenjemptan = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlHarga = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PembelianDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PenjualanDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PembelianButton = new Guna.UI2.WinForms.Guna2Button();
            this.PenjualanButton = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPenjemptan.SuspendLayout();
            this.pnlHarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PembelianDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenjualanDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPenjemptan
            // 
            this.pnlPenjemptan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPenjemptan.BackColor = System.Drawing.Color.Transparent;
            this.pnlPenjemptan.BorderRadius = 20;
            this.pnlPenjemptan.Controls.Add(this.PembelianButton);
            this.pnlPenjemptan.Controls.Add(this.PenjualanButton);
            this.pnlPenjemptan.Controls.Add(this.PenjualanDataGridView1);
            this.pnlPenjemptan.Controls.Add(this.PembelianDataGridView1);
            this.pnlPenjemptan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.Location = new System.Drawing.Point(39, 170);
            this.pnlPenjemptan.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPenjemptan.Name = "pnlPenjemptan";
            this.pnlPenjemptan.Size = new System.Drawing.Size(1076, 402);
            this.pnlPenjemptan.TabIndex = 9;
            // 
            // pnlHarga
            // 
            this.pnlHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHarga.BackColor = System.Drawing.Color.Transparent;
            this.pnlHarga.BorderRadius = 10;
            this.pnlHarga.Controls.Add(this.label1);
            this.pnlHarga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(70)))), ((int)(((byte)(43)))));
            this.pnlHarga.Location = new System.Drawing.Point(39, 66);
            this.pnlHarga.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHarga.Name = "pnlHarga";
            this.pnlHarga.Size = new System.Drawing.Size(1076, 90);
            this.pnlHarga.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Riwayat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PembelianDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.PembelianDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PembelianDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PembelianDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PembelianDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.PembelianDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PembelianDataGridView1.Location = new System.Drawing.Point(45, 66);
            this.PembelianDataGridView1.Name = "PembelianDataGridView1";
            this.PembelianDataGridView1.RowHeadersVisible = false;
            this.PembelianDataGridView1.Size = new System.Drawing.Size(996, 288);
            this.PembelianDataGridView1.TabIndex = 0;
            this.PembelianDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PembelianDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PembelianDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PembelianDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PembelianDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PembelianDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PembelianDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PembelianDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PembelianDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PembelianDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembelianDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PembelianDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PembelianDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.PembelianDataGridView1.ThemeStyle.ReadOnly = false;
            this.PembelianDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PembelianDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PembelianDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembelianDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PembelianDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.PembelianDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PembelianDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PenjualanDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PenjualanDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PenjualanDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PenjualanDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PenjualanDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.PenjualanDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PenjualanDataGridView1.Location = new System.Drawing.Point(45, 66);
            this.PenjualanDataGridView1.Name = "PenjualanDataGridView1";
            this.PenjualanDataGridView1.RowHeadersVisible = false;
            this.PenjualanDataGridView1.Size = new System.Drawing.Size(959, 306);
            this.PenjualanDataGridView1.TabIndex = 1;
            this.PenjualanDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PenjualanDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PenjualanDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PenjualanDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PenjualanDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PenjualanDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PenjualanDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PenjualanDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PenjualanDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PenjualanDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenjualanDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PenjualanDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PenjualanDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.PenjualanDataGridView1.ThemeStyle.ReadOnly = false;
            this.PenjualanDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PenjualanDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PenjualanDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenjualanDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PenjualanDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.PenjualanDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PenjualanDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PembelianButton
            // 
            this.PembelianButton.Animated = true;
            this.PembelianButton.AutoRoundedCorners = true;
            this.PembelianButton.BorderRadius = 13;
            this.PembelianButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PembelianButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PembelianButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PembelianButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PembelianButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(154)))));
            this.PembelianButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembelianButton.ForeColor = System.Drawing.Color.Black;
            this.PembelianButton.Location = new System.Drawing.Point(826, 17);
            this.PembelianButton.Margin = new System.Windows.Forms.Padding(2);
            this.PembelianButton.Name = "PembelianButton";
            this.PembelianButton.Size = new System.Drawing.Size(120, 29);
            this.PembelianButton.TabIndex = 7;
            this.PembelianButton.Text = "Pembelian";
            this.PembelianButton.UseTransparentBackground = true;
            this.PembelianButton.Click += new System.EventHandler(this.PembelianButton_Click);
            // 
            // PenjualanButton
            // 
            this.PenjualanButton.Animated = true;
            this.PenjualanButton.AutoRoundedCorners = true;
            this.PenjualanButton.BorderRadius = 13;
            this.PenjualanButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PenjualanButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PenjualanButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PenjualanButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PenjualanButton.FillColor = System.Drawing.Color.White;
            this.PenjualanButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.PenjualanButton.ForeColor = System.Drawing.Color.Black;
            this.PenjualanButton.Location = new System.Drawing.Point(921, 17);
            this.PenjualanButton.Margin = new System.Windows.Forms.Padding(2);
            this.PenjualanButton.Name = "PenjualanButton";
            this.PenjualanButton.Size = new System.Drawing.Size(120, 29);
            this.PenjualanButton.TabIndex = 8;
            this.PenjualanButton.Text = "Penjualan";
            this.PenjualanButton.UseTransparentBackground = true;
            this.PenjualanButton.Click += new System.EventHandler(this.PenjualanButton_Click);
            // 
            // RiwayatPengepul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlHarga);
            this.Controls.Add(this.pnlPenjemptan);
            this.Name = "RiwayatPengepul";
            this.Size = new System.Drawing.Size(1169, 605);
            this.Load += new System.EventHandler(this.RiwayatPengepul_Load);
            this.pnlPenjemptan.ResumeLayout(false);
            this.pnlHarga.ResumeLayout(false);
            this.pnlHarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PembelianDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenjualanDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlPenjemptan;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlHarga;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView PenjualanDataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView PembelianDataGridView1;
        private Guna.UI2.WinForms.Guna2Button PembelianButton;
        private Guna.UI2.WinForms.Guna2Button PenjualanButton;
    }
}
