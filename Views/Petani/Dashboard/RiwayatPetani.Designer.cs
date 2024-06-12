namespace Ngupy_NgulakKopy.Views.Petani.Dashboard
{
    partial class RiwayatPetani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblnama = new System.Windows.Forms.Label();
            this.pnlHarga = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlPenjemptan = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.RiwayatDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlHarga.SuspendLayout();
            this.pnlPenjemptan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RiwayatDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnama.ForeColor = System.Drawing.Color.Transparent;
            this.lblnama.Location = new System.Drawing.Point(33, 36);
            this.lblnama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(165, 37);
            this.lblnama.TabIndex = 0;
            this.lblnama.Text = "Sah Ru Khan";
            // 
            // pnlHarga
            // 
            this.pnlHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHarga.BackColor = System.Drawing.Color.Transparent;
            this.pnlHarga.BorderRadius = 10;
            this.pnlHarga.Controls.Add(this.lblnama);
            this.pnlHarga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(137)))), ((int)(((byte)(91)))));
            this.pnlHarga.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(70)))), ((int)(((byte)(43)))));
            this.pnlHarga.Location = new System.Drawing.Point(61, 60);
            this.pnlHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHarga.Name = "pnlHarga";
            this.pnlHarga.Size = new System.Drawing.Size(1084, 111);
            this.pnlHarga.TabIndex = 12;
            // 
            // pnlPenjemptan
            // 
            this.pnlPenjemptan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPenjemptan.BackColor = System.Drawing.Color.Transparent;
            this.pnlPenjemptan.BorderRadius = 20;
            this.pnlPenjemptan.Controls.Add(this.RiwayatDataGrid);
            this.pnlPenjemptan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(38)))));
            this.pnlPenjemptan.Location = new System.Drawing.Point(61, 188);
            this.pnlPenjemptan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPenjemptan.Name = "pnlPenjemptan";
            this.pnlPenjemptan.Size = new System.Drawing.Size(1084, 495);
            this.pnlPenjemptan.TabIndex = 11;
            this.pnlPenjemptan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPenjemptan_Paint);
            // 
            // RiwayatDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.RiwayatDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RiwayatDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RiwayatDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RiwayatDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.RiwayatDataGrid.GridColor = System.Drawing.Color.White;
            this.RiwayatDataGrid.Location = new System.Drawing.Point(58, 50);
            this.RiwayatDataGrid.Name = "RiwayatDataGrid";
            this.RiwayatDataGrid.RowHeadersVisible = false;
            this.RiwayatDataGrid.RowHeadersWidth = 51;
            this.RiwayatDataGrid.RowTemplate.Height = 24;
            this.RiwayatDataGrid.Size = new System.Drawing.Size(992, 402);
            this.RiwayatDataGrid.TabIndex = 0;
            this.RiwayatDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RiwayatDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RiwayatDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RiwayatDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RiwayatDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RiwayatDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RiwayatDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.RiwayatDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RiwayatDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RiwayatDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiwayatDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RiwayatDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RiwayatDataGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.RiwayatDataGrid.ThemeStyle.ReadOnly = false;
            this.RiwayatDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RiwayatDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RiwayatDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiwayatDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RiwayatDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.RiwayatDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RiwayatDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RiwayatPetani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlHarga);
            this.Controls.Add(this.pnlPenjemptan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RiwayatPetani";
            this.Size = new System.Drawing.Size(1207, 745);
            this.pnlHarga.ResumeLayout(false);
            this.pnlHarga.PerformLayout();
            this.pnlPenjemptan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RiwayatDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblnama;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlHarga;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlPenjemptan;
        private Guna.UI2.WinForms.Guna2DataGridView RiwayatDataGrid;
    }
}
