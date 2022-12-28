namespace Vape_Store
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tdMaster = new System.Windows.Forms.ToolStripDropDownButton();
            this.tdTransaksi = new System.Windows.Forms.ToolStripDropDownButton();
            this.tdProgram = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsBarang = new System.Windows.Forms.ToolStripButton();
            this.tsKategori = new System.Windows.Forms.ToolStripButton();
            this.tsSatuan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPenjualan = new System.Windows.Forms.ToolStripButton();
            this.tsLaporan = new System.Windows.Forms.ToolStripButton();
            this.tsKas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPassword = new System.Windows.Forms.ToolStripButton();
            this.tsKalkulator = new System.Windows.Forms.ToolStripButton();
            this.tsSetting = new System.Windows.Forms.ToolStripButton();
            this.tsSuplai = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tdMaster,
            this.tdTransaksi,
            this.tdProgram});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tdMaster
            // 
            this.tdMaster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tdMaster.Image = ((System.Drawing.Image)(resources.GetObject("tdMaster.Image")));
            this.tdMaster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdMaster.Name = "tdMaster";
            this.tdMaster.Size = new System.Drawing.Size(126, 29);
            this.tdMaster.Text = "Master Data";
            // 
            // tdTransaksi
            // 
            this.tdTransaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tdTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("tdTransaksi.Image")));
            this.tdTransaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdTransaksi.Name = "tdTransaksi";
            this.tdTransaksi.Size = new System.Drawing.Size(100, 29);
            this.tdTransaksi.Text = "Transaksi";
            // 
            // tdProgram
            // 
            this.tdProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tdProgram.Image = ((System.Drawing.Image)(resources.GetObject("tdProgram.Image")));
            this.tdProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdProgram.Name = "tdProgram";
            this.tdProgram.Size = new System.Drawing.Size(99, 29);
            this.tdProgram.Text = "Program";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSuplai,
            this.tsBarang,
            this.tsKategori,
            this.tsSatuan,
            this.toolStripSeparator3,
            this.tsPenjualan,
            this.tsLaporan,
            this.tsKas,
            this.toolStripSeparator4,
            this.tsPassword,
            this.tsKalkulator,
            this.tsSetting});
            this.toolStrip2.Location = new System.Drawing.Point(0, 34);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1056, 34);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsBarang
            // 
            this.tsBarang.Image = ((System.Drawing.Image)(resources.GetObject("tsBarang.Image")));
            this.tsBarang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBarang.Name = "tsBarang";
            this.tsBarang.Size = new System.Drawing.Size(95, 29);
            this.tsBarang.Text = "Barang";
            // 
            // tsKategori
            // 
            this.tsKategori.Image = ((System.Drawing.Image)(resources.GetObject("tsKategori.Image")));
            this.tsKategori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKategori.Name = "tsKategori";
            this.tsKategori.Size = new System.Drawing.Size(106, 29);
            this.tsKategori.Text = "Kategori";
            // 
            // tsSatuan
            // 
            this.tsSatuan.Image = ((System.Drawing.Image)(resources.GetObject("tsSatuan.Image")));
            this.tsSatuan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSatuan.Name = "tsSatuan";
            this.tsSatuan.Size = new System.Drawing.Size(94, 29);
            this.tsSatuan.Text = "Satuan";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // tsPenjualan
            // 
            this.tsPenjualan.Image = ((System.Drawing.Image)(resources.GetObject("tsPenjualan.Image")));
            this.tsPenjualan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPenjualan.Name = "tsPenjualan";
            this.tsPenjualan.Size = new System.Drawing.Size(114, 29);
            this.tsPenjualan.Text = "Penjualan";
            this.tsPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsLaporan
            // 
            this.tsLaporan.Image = ((System.Drawing.Image)(resources.GetObject("tsLaporan.Image")));
            this.tsLaporan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLaporan.Name = "tsLaporan";
            this.tsLaporan.Size = new System.Drawing.Size(104, 29);
            this.tsLaporan.Text = "Laporan";
            // 
            // tsKas
            // 
            this.tsKas.Image = ((System.Drawing.Image)(resources.GetObject("tsKas.Image")));
            this.tsKas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKas.Name = "tsKas";
            this.tsKas.Size = new System.Drawing.Size(67, 29);
            this.tsKas.Text = "Kas";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // tsPassword
            // 
            this.tsPassword.Image = ((System.Drawing.Image)(resources.GetObject("tsPassword.Image")));
            this.tsPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPassword.Name = "tsPassword";
            this.tsPassword.Size = new System.Drawing.Size(115, 29);
            this.tsPassword.Text = "Password";
            // 
            // tsKalkulator
            // 
            this.tsKalkulator.Image = ((System.Drawing.Image)(resources.GetObject("tsKalkulator.Image")));
            this.tsKalkulator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKalkulator.Name = "tsKalkulator";
            this.tsKalkulator.Size = new System.Drawing.Size(118, 29);
            this.tsKalkulator.Text = "Kalkulator";
            // 
            // tsSetting
            // 
            this.tsSetting.Image = ((System.Drawing.Image)(resources.GetObject("tsSetting.Image")));
            this.tsSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSetting.Name = "tsSetting";
            this.tsSetting.Size = new System.Drawing.Size(96, 29);
            this.tsSetting.Text = "Setting";
            // 
            // tsSuplai
            // 
            this.tsSuplai.Image = ((System.Drawing.Image)(resources.GetObject("tsSuplai.Image")));
            this.tsSuplai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSuplai.Name = "tsSuplai";
            this.tsSuplai.Size = new System.Drawing.Size(88, 29);
            this.tsSuplai.Text = "Suplai";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form3";
            this.Text = "Jual Tunai";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tdMaster;
        private ToolStripDropDownButton tdTransaksi;
        private ToolStripDropDownButton tdProgram;
        private ToolStrip toolStrip2;
        private ToolStripButton tsBarang;
        private ToolStripButton tsKategori;
        private ToolStripButton tsSatuan;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsPenjualan;
        private ToolStripButton tsLaporan;
        private ToolStripButton tsKas;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsPassword;
        private ToolStripButton tsKalkulator;
        private ToolStripButton tsSetting;
        private ToolStripButton tsSuplai;
    }
}