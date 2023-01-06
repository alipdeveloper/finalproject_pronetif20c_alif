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
    public partial class FrmPengaturan : Form
    {
        MySqlDataReader dr;
        public FrmPengaturan()
        {
            InitializeComponent();
        }

        private void FrmSet_Load(object sender, EventArgs e)
        {
            isiGrid();
        }

        void isiGrid()
        {
            dr = H.OpenDr("SELECT * FROM tb_user");
            dgv.Rows.Clear();
            while (dr.Read())
            {
                dgv.Rows.Add(new object[] { 
                    dr[0],
                    dr[1],
                    dr[2],
                    dr[3],
                    dr[4],
                    dr[5],
                    dr[6],
                    dr[7],
                    dr[8],
                    dr[9],
                    dr[10],
                    dr[11],
                    dr[12]
                });
            }
        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmTambahUser f = new FrmTambahUser();
            if (f.ShowDialog() == DialogResult.Yes)
            {
                isiGrid();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                String d = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (H.isKdExist(d, "tb_jual", "User"))
                {
                    H.msgError("Data tidak bisa terhapus");
                }
                else if (H.msgAsk("Hapus data?") == DialogResult.Yes)
                {
                    if (H.execute("DELETE FROM tb_user WHERE id_user='" + d + "'"))
                    {
                        H.msgInfo("Data dihapus");
                        isiGrid();
                    }
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                H.msgError("Belum ada data yang dipilih");
                return;
            }

            H.IdEdit = H.GetSelAt(dgv);

            FrmTambahUser frm = new FrmTambahUser();
            frm.editState = true;
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                isiGrid();
            }
        }

        private void FrmSet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKeluar_Click(null, null);
            }
        }
    }
}
