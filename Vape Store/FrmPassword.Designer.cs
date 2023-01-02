namespace Vape_Store
{
    partial class FrmPassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnRubah = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.cmbNama = new System.Windows.Forms.ComboBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password Lama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password Baru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password Baru";
            // 
            // btnRubah
            // 
            this.btnRubah.Location = new System.Drawing.Point(18, 229);
            this.btnRubah.Name = "btnRubah";
            this.btnRubah.Size = new System.Drawing.Size(75, 23);
            this.btnRubah.TabIndex = 4;
            this.btnRubah.Text = "Rubah (F3)";
            this.btnRubah.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(213, 229);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal (ESC)";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // cmbNama
            // 
            this.cmbNama.FormattingEnabled = true;
            this.cmbNama.Location = new System.Drawing.Point(167, 67);
            this.cmbNama.Name = "cmbNama";
            this.cmbNama.Size = new System.Drawing.Size(121, 23);
            this.cmbNama.TabIndex = 6;
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(167, 101);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(121, 23);
            this.txtPass1.TabIndex = 7;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(167, 138);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(121, 23);
            this.txtPass2.TabIndex = 8;
            // 
            // txtPass3
            // 
            this.txtPass3.Location = new System.Drawing.Point(167, 172);
            this.txtPass3.Name = "txtPass3";
            this.txtPass3.Size = new System.Drawing.Size(121, 23);
            this.txtPass3.TabIndex = 9;
            // 
            // FrmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 287);
            this.Controls.Add(this.txtPass3);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.cmbNama);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnRubah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPassword";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRubah;
        private Button btnBatal;
        private ComboBox cmbNama;
        private TextBox txtPass1;
        private TextBox txtPass2;
        private TextBox txtPass3;
    }
}