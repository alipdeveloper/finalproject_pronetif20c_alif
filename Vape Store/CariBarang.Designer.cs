namespace Vape_Store
{
    partial class CariBarang
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
            this.dgvCari = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCari
            // 
            this.dgvCari.AllowUserToAddRows = false;
            this.dgvCari.AllowUserToDeleteRows = false;
            this.dgvCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvCari.Location = new System.Drawing.Point(13, 12);
            this.dgvCari.Name = "dgvCari";
            this.dgvCari.ReadOnly = true;
            this.dgvCari.RowHeadersWidth = 62;
            this.dgvCari.RowTemplate.Height = 33;
            this.dgvCari.Size = new System.Drawing.Size(984, 399);
            this.dgvCari.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kategori";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Harga Jual";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jumlah";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masukkan kriteria pencarian";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(250, 465);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(216, 31);
            this.txtCari.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(507, 465);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(277, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Pilih, Enter atau Double Click";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(814, 465);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(155, 34);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar (ESC)";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // CariBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 545);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCari);
            this.Name = "CariBarang";
            this.Text = "CariBarang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCari;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
        private TextBox txtCari;
        private Button btnOK;
        private Button btnKeluar;
    }
}