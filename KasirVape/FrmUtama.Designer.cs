namespace KasirVape
{
    partial class FrmUtama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtama));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sb2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sb1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbBarang = new System.Windows.Forms.ToolStripButton();
            this.tbKategori = new System.Windows.Forms.ToolStripButton();
            this.tbSatuan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbJual = new System.Windows.Forms.ToolStripButton();
            this.tbLap = new System.Windows.Forms.ToolStripButton();
            this.tbKas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbPassword = new System.Windows.Forms.ToolStripButton();
            this.tbSetting = new System.Windows.Forms.ToolStripButton();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKategori = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSatuan = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnJual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKas = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // sb2
            // 
            this.sb2.BackColor = System.Drawing.SystemColors.Control;
            this.sb2.Name = "sb2";
            this.sb2.Size = new System.Drawing.Size(67, 20);
            this.sb2.Text = "operator";
            // 
            // sb1
            // 
            this.sb1.Name = "sb1";
            this.sb1.Size = new System.Drawing.Size(0, 20);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb1,
            this.sb2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(976, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbBarang,
            this.tbKategori,
            this.tbSatuan,
            this.toolStripSeparator2,
            this.tbJual,
            this.tbLap,
            this.tbKas,
            this.toolStripSeparator1,
            this.tbPassword,
            this.tbSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(976, 43);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbBarang
            // 
            this.tbBarang.Image = ((System.Drawing.Image)(resources.GetObject("tbBarang.Image")));
            this.tbBarang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBarang.Name = "tbBarang";
            this.tbBarang.Size = new System.Drawing.Size(60, 40);
            this.tbBarang.Text = "Barang";
            this.tbBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbBarang.Click += new System.EventHandler(this.tbBarang_Click_1);
            // 
            // tbKategori
            // 
            this.tbKategori.Image = ((System.Drawing.Image)(resources.GetObject("tbKategori.Image")));
            this.tbKategori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(70, 40);
            this.tbKategori.Text = "Kategori";
            this.tbKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbKategori.Click += new System.EventHandler(this.tbKategori_Click_1);
            // 
            // tbSatuan
            // 
            this.tbSatuan.Image = ((System.Drawing.Image)(resources.GetObject("tbSatuan.Image")));
            this.tbSatuan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSatuan.Name = "tbSatuan";
            this.tbSatuan.Size = new System.Drawing.Size(58, 40);
            this.tbSatuan.Text = "Satuan";
            this.tbSatuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbSatuan.Click += new System.EventHandler(this.tbSatuan_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // tbJual
            // 
            this.tbJual.Image = ((System.Drawing.Image)(resources.GetObject("tbJual.Image")));
            this.tbJual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbJual.Name = "tbJual";
            this.tbJual.Size = new System.Drawing.Size(76, 40);
            this.tbJual.Text = "Penjualan";
            this.tbJual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbJual.Click += new System.EventHandler(this.tbJual_Click_1);
            // 
            // tbLap
            // 
            this.tbLap.Image = ((System.Drawing.Image)(resources.GetObject("tbLap.Image")));
            this.tbLap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbLap.Name = "tbLap";
            this.tbLap.Size = new System.Drawing.Size(67, 40);
            this.tbLap.Text = "Laporan";
            this.tbLap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbLap.Click += new System.EventHandler(this.tbLap_Click_1);
            // 
            // tbKas
            // 
            this.tbKas.Image = ((System.Drawing.Image)(resources.GetObject("tbKas.Image")));
            this.tbKas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbKas.Name = "tbKas";
            this.tbKas.Size = new System.Drawing.Size(36, 40);
            this.tbKas.Text = "Kas";
            this.tbKas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbKas.Click += new System.EventHandler(this.tbKas_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // tbPassword
            // 
            this.tbPassword.Image = ((System.Drawing.Image)(resources.GetObject("tbPassword.Image")));
            this.tbPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(74, 40);
            this.tbPassword.Text = "Password";
            this.tbPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click_1);
            // 
            // tbSetting
            // 
            this.tbSetting.Image = ((System.Drawing.Image)(resources.GetObject("tbSetting.Image")));
            this.tbSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSetting.Name = "tbSetting";
            this.tbSetting.Size = new System.Drawing.Size(60, 40);
            this.tbSetting.Text = "Setting";
            this.tbSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBarang,
            this.mnKategori,
            this.mnSatuan});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // mnBarang
            // 
            this.mnBarang.Name = "mnBarang";
            this.mnBarang.Size = new System.Drawing.Size(135, 24);
            this.mnBarang.Text = "Barang";
            // 
            // mnKategori
            // 
            this.mnKategori.Name = "mnKategori";
            this.mnKategori.Size = new System.Drawing.Size(135, 24);
            this.mnKategori.Text = "Kategori";
            // 
            // mnSatuan
            // 
            this.mnSatuan.Name = "mnSatuan";
            this.mnSatuan.Size = new System.Drawing.Size(135, 24);
            this.mnSatuan.Text = "Satuan";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnJual,
            this.mnLap,
            this.mnKas});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // mnJual
            // 
            this.mnJual.Name = "mnJual";
            this.mnJual.Size = new System.Drawing.Size(141, 24);
            this.mnJual.Text = "Penjualan";
            // 
            // mnLap
            // 
            this.mnLap.Name = "mnLap";
            this.mnLap.Size = new System.Drawing.Size(141, 24);
            this.mnLap.Text = "Laporan";
            // 
            // mnKas
            // 
            this.mnKas.Name = "mnKas";
            this.mnKas.Size = new System.Drawing.Size(141, 24);
            this.mnKas.Text = "Kas";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSetting,
            this.mnPassword,
            this.keluarToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // mnSetting
            // 
            this.mnSetting.Name = "mnSetting";
            this.mnSetting.Size = new System.Drawing.Size(178, 24);
            this.mnSetting.Text = "Pengaturan";
            // 
            // mnPassword
            // 
            this.mnPassword.Name = "mnPassword";
            this.mnPassword.Size = new System.Drawing.Size(178, 24);
            this.mnPassword.Text = "Ganti Password";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.keluarToolStripMenuItem.Text = "Keluar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDataToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(976, 520);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmUtama";
            this.Text = "Kasir Vape";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel sb2;
        private System.Windows.Forms.ToolStripStatusLabel sb1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbBarang;
        private System.Windows.Forms.ToolStripButton tbKategori;
        private System.Windows.Forms.ToolStripButton tbSatuan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbJual;
        private System.Windows.Forms.ToolStripButton tbLap;
        private System.Windows.Forms.ToolStripButton tbKas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbPassword;
        private System.Windows.Forms.ToolStripButton tbSetting;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnBarang;
        private System.Windows.Forms.ToolStripMenuItem mnKategori;
        private System.Windows.Forms.ToolStripMenuItem mnSatuan;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnJual;
        private System.Windows.Forms.ToolStripMenuItem mnLap;
        private System.Windows.Forms.ToolStripMenuItem mnKas;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSetting;
        private System.Windows.Forms.ToolStripMenuItem mnPassword;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

