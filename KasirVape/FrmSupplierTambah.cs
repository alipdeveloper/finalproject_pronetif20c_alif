using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KasirVape
{
    public partial class FrmSupplierTambah : Form
    {
        public bool editState = false;
        MySqlDataReader dr;
        public FrmSupplierTambah()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btntambah_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "" && !editState)
            {
                H.msgError("Kode tidak boleh kosong!");
                txtid.Focus();
                return;
            }
            if (txtnama.Text == "")
            {
                H.msgError("Nama tidak boleh kosong!");
                txtnama.Focus();
                return;
            }

            if (H.isKdExist(txtid.Text) && !editState)
            {
                H.msgError("Kode sudah ada!");
                txtid.Focus();
                return;
            }
            if (editState)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE tb_supplier SET nama=@nama,  no_telp=@no_telp, alamat=@alamat WHERE id_supplier=@id_supplier", H.getConnection());
                cmd.Parameters.AddWithValue("id_supplier", txtid.Text);
                cmd.Parameters.AddWithValue("nama", txtnama.Text.ToString());
                cmd.Parameters.AddWithValue("no_telp", txtno.Text);
                cmd.Parameters.AddWithValue("alamat", txtalamat.Text.ToString());
                H.executeCMD(cmd);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_supplier (id_supplier, nama, no_telp, alamat) VALUES(@id_supplier, @nama, @no_telp, @alamat)", H.getConnection());
                cmd.Parameters.AddWithValue("id_supplier", txtid.Text.ToString());
                cmd.Parameters.AddWithValue("nama", txtnama.Text.ToString());
                cmd.Parameters.AddWithValue("no_telp", txtno.Text);
                cmd.Parameters.AddWithValue("alamat", txtalamat.Text.ToString());
                H.executeCMD(cmd);
            }
            H.msgInfo("Data tersimpan");
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnKeluar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
