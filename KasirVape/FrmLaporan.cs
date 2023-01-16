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
using CrystalDecisions.CrystalReports.Engine;

namespace KasirVape
{
    public partial class FrmLaporan : Form
    {
        MySqlDataReader dr;
        public FrmLaporan()
        {
            InitializeComponent();
        }

        private void FrmLaporan_Load(object sender, EventArgs e)
        {
            txtAwal.Value = DateTime.Now;
            txtAkhir.Value = DateTime.Now;

            H.DsbControls(txtGrandtotal );

            txtOperator.Items.Clear();
            txtOperator.Items.Add("SEMUA");
            dr = H.OpenDr("SELECT username FROM tb_user");
            H.FillCmb(dr, txtOperator);
            isiGrid();
        }

        void isiGrid()
        {
            double grandtotal = 0, laba = 0;

            string awal = txtAwal.Value.ToString("yyyy-MM-dd");
            string akhir = txtAkhir.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM nota WHERE tanggal>='" + awal + "' AND tanggal <='" + akhir + "'";
            if (txtOperator.Text != "SEMUA")
            {
                sql += " AND username='" + txtOperator.Text + "'";
            }
            sql += " ORDER BY Faktur";
            
            dr = H.OpenDr(sql);
            dgv.Rows.Clear();
            int no = 1;
            while (dr.Read())
            {
                dgv.Rows.Add(new object[] {
                    no,
                    dr["Faktur"].ToString(),
                    H.toStrDate(dr["tanggal"]),
                    H.toStrC(dr["grandtotal"]),
                   //.toStrC(dr["laba"]),
                    dr["username"]
                });
                grandtotal += H.toD(dr["grandtotal"]);
                //ba += H.toD(dr["laba"]);
                no++;
            }
            txtGrandtotal.Text = H.toStrC(grandtotal);
            //tLaba.Text = H.toStrC(laba);
        }

        private void txtOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void txtAwal_ValueChanged(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void txtAkhir_ValueChanged(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                H.msgError("Data tidak ada!");
                return;
            }
            string sql = "";
            try
            {
                string periode = "Periode: " + txtAwal.Value.ToString("dd-MMM-yyyy") + " s/d " + txtAkhir.Value.ToString("dd-MMM-yyyy");
                string cetak = "Cetak: " + DateTime.Now.ToShortDateString() + " Oleh: " + H.strOperator;
                string stroperator = txtOperator.Text;

                H.CloseDr();
                DataSet ds = new DataSet();

                sql = "SELECT '" +
                    stroperator + "' AS username, '" +
                    periode + "' AS periode, faktur, tanggal, grandtotal, username, '" +
                    cetak + "' AS cetak " +
                    "FROM nota WHERE tanggal>='" + txtAwal.Value.ToString("yyyy-MM-dd") + "' AND tanggal<='" + txtAkhir.Value.ToString("yyyy-MM-dd") + "'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, H.getConnection());
                adapter.Fill(ds);

                ReportDocument rd = new ReportDocument();
                rd.Load("../../rptJual.rpt");
                rd.Database.Tables[0].SetDataSource(ds.Tables[0]);

                //pakai perintah ini untuk langsung print dan hapus 5 baris perintah di bawahnya
                //rd.PrintToPrinter;

                FrmCetak l = new FrmCetak();
                l.MdiParent = this.MdiParent;
                l.WindowState = FormWindowState.Maximized;
                l.crystalReportViewer1.ReportSource = rd;
                l.Show();
            }
            catch (Exception ex)
            {
                H.msgError(ex.Message + sql);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLap_KeyDown(object sender, KeyEventArgs e)
        {
            if (H.isPrint(e)) btnCetak_Click(null, null);
            if (H.isClose(e)) btnKeluar_Click(null, null);
        }
    }
}
