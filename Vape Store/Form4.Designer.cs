namespace Vape_Store
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpmulai = new System.Windows.Forms.DateTimePicker();
            this.dtpsd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboperator = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.btncetak = new System.Windows.Forms.Button();
            this.btnkeluar = new System.Windows.Forms.Button();
            this.dgvpenjualan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mulai Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "S/D Tanggal";
            // 
            // dtpmulai
            // 
            this.dtpmulai.Location = new System.Drawing.Point(301, 22);
            this.dtpmulai.Name = "dtpmulai";
            this.dtpmulai.Size = new System.Drawing.Size(140, 23);
            this.dtpmulai.TabIndex = 3;
            // 
            // dtpsd
            // 
            this.dtpsd.Location = new System.Drawing.Point(301, 57);
            this.dtpsd.Name = "dtpsd";
            this.dtpsd.Size = new System.Drawing.Size(140, 23);
            this.dtpsd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operator";
            // 
            // cmboperator
            // 
            this.cmboperator.FormattingEnabled = true;
            this.cmboperator.Location = new System.Drawing.Point(516, 25);
            this.cmboperator.Name = "cmboperator";
            this.cmboperator.Size = new System.Drawing.Size(121, 23);
            this.cmboperator.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Grandtotal";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(725, 31);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(100, 23);
            this.txtgrandtotal.TabIndex = 8;
            // 
            // btncetak
            // 
            this.btncetak.Location = new System.Drawing.Point(24, 328);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(75, 23);
            this.btncetak.TabIndex = 11;
            this.btncetak.Text = "Cetak (F6)";
            this.btncetak.UseVisualStyleBackColor = true;
            // 
            // btnkeluar
            // 
            this.btnkeluar.Location = new System.Drawing.Point(105, 328);
            this.btnkeluar.Name = "btnkeluar";
            this.btnkeluar.Size = new System.Drawing.Size(88, 23);
            this.btnkeluar.TabIndex = 12;
            this.btnkeluar.Text = "Keluar (ESC)";
            this.btnkeluar.UseVisualStyleBackColor = true;
            // 
            // dgvpenjualan
            // 
            this.dgvpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpenjualan.Location = new System.Drawing.Point(24, 94);
            this.dgvpenjualan.Name = "dgvpenjualan";
            this.dgvpenjualan.RowTemplate.Height = 25;
            this.dgvpenjualan.Size = new System.Drawing.Size(801, 228);
            this.dgvpenjualan.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.dgvpenjualan);
            this.Controls.Add(this.btnkeluar);
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboperator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpsd);
            this.Controls.Add(this.dtpmulai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpmulai;
        private DateTimePicker dtpsd;
        private Label label4;
        private ComboBox cmboperator;
        private Label label5;
        private TextBox txtgrandtotal;
        private Button btncetak;
        private Button btnkeluar;
        private DataGridView dgvpenjualan;
    }
}