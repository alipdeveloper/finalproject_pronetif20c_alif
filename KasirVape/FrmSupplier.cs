using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KasirVape
{
    public partial class FrmSupplier : Form
    {
        MySqlDataReader dr;
        public FrmSupplier()
        {
            InitializeComponent();
        }


        void isiGrid()
        {
            dr = H.OpenDr("SELECT * FROM tb_supplier WHERE id_supplier LIKE '%" + txtCari.Text + "%' OR nama LIKE '%" + txtCari.Text + "%' ORDER BY id_supplier");
            dgv.Rows.Clear();
            int no = 1;
            while (dr.Read())
            {
                dgv.Rows.Add(new Object[] {
                    no,
                    dr["id_supplier"],
                    dr["nama"],
                    dr["no_telp"],
                    dr["alamat"]
                });
                no++;
            }

        }
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmSupplierTambah frm = new FrmSupplierTambah();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                isiGrid();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                H.msgError("Belum ada data yang dipilih");
                return;
            }

            H.IdEdit = H.GetSelAt(dgv, 1);

            FrmSupplierTambah frm = new FrmSupplierTambah();
            frm.editState = true;
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                isiGrid();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                String d = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (H.msgAsk("Hapus data?") == DialogResult.Yes)
                {
                    if (H.execute("DELETE FROM tb_supplier WHERE id_supplier='" + d + "'"))
                    {
                        H.msgInfo("Data dihapus");
                        isiGrid();
                    }
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {

        }
    }


}
