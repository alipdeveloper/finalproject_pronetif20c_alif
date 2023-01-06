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
    public partial class FrmTambahUser : Form
    {
        public bool editState = false;

        public FrmTambahUser()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                H.msgError("ID User tidak boleh kosong!");
                txtUser.Focus();
                return;
            }
            if (H.isKdExist(txtId.Text, "tb_user", "id_user") && !editState)
            {
                H.msgError("Id User sudah terdaftar!");
                txtId.Focus();
            }
            if (editState)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE tb_user SET " +
                "user=@user pass=@pass, status=@status, frmbrg=@frmbrg, frmsupp=@frmsupp, frmkat=@frmkat, frmsat=@frmsat, frmjual=@frmjual, frmlap=@frmlap, frmkas=@frmkas, frmpass=@frmpass, frmset=@frmset " +
                " WHERE id_user=@id_user", H.getConnection());

                cmd.Parameters.AddWithValue("id_user", txtId.Text);
                cmd.Parameters.AddWithValue("user", txtUser.Text);
                cmd.Parameters.AddWithValue("pass", txtPass.Text);
                cmd.Parameters.AddWithValue("status", ckAktif.Checked);
                cmd.Parameters.AddWithValue("frmbrg", ckFrmBrg.Checked);
                cmd.Parameters.AddWithValue("frmsupp", ckFrmSupp.Checked);
                cmd.Parameters.AddWithValue("frmkat", ckFrmKat.Checked);
                cmd.Parameters.AddWithValue("frmsat", ckFrmSat.Checked);
                cmd.Parameters.AddWithValue("frmjual", ckFrmJual.Checked);
                cmd.Parameters.AddWithValue("frmkas", ckFrmLap.Checked);
                cmd.Parameters.AddWithValue("frmlap", ckFrmLap.Checked);
                cmd.Parameters.AddWithValue("frmpass", ckFrmPass.Checked);
                cmd.Parameters.AddWithValue("frmset", ckFrmSet.Checked);

                H.executeCMD(cmd);

                H.msgInfo("Data tersimpan");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_user (id_user, user, pass, status, frmbrg, frmsupp, frmkat, frmsat, frmjual, frmlap, frmkas, frmpass, frmset) " +
                    " VALUES (@id_user, @user, @pass, @status, @frmbrg, @frmsupp, @frmkat, @frmsat, @frmjual, @frmlap, @frmkas, @frmpass, @frmset)", H.getConnection());

                cmd.Parameters.AddWithValue("id_user", txtId.Text);
                cmd.Parameters.AddWithValue("user", txtUser.Text);
                cmd.Parameters.AddWithValue("pass", txtPass.Text);
                cmd.Parameters.AddWithValue("status", ckAktif.Checked);
                cmd.Parameters.AddWithValue("frmbrg", ckFrmBrg.Checked);
                cmd.Parameters.AddWithValue("frmsupp", ckFrmSupp.Checked);
                cmd.Parameters.AddWithValue("frmkat", ckFrmKat.Checked);
                cmd.Parameters.AddWithValue("frmsat", ckFrmSat.Checked);
                cmd.Parameters.AddWithValue("frmjual", ckFrmJual.Checked);
                cmd.Parameters.AddWithValue("frmlap", ckFrmLap.Checked);
                cmd.Parameters.AddWithValue("frmkas", ckFrmLap.Checked);
                cmd.Parameters.AddWithValue("frmpass", ckFrmPass.Checked);
                cmd.Parameters.AddWithValue("frmset", ckFrmSet.Checked);

                H.executeCMD(cmd);

                H.msgInfo("Data tersimpan");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void frmTmbhUsr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKeluar_Click(null, null);
            }
        }

        private void FrmTambahUser_Load(object sender, EventArgs e)
        {
            if (editState)
            {
                MySqlDataReader dr = H.openTable("tb_user", "id_user='" + H.IdEdit + "'");
                if (dr.Read())
                {
                    txtId.Text = dr["id_user"].ToString();
                    txtUser.Text = dr["user"].ToString();
                    txtPass.Text = dr["pass"].ToString();
                    ckAktif.Checked = dr["status"].ToString() == "1";
                    ckFrmBrg.Checked = dr["frmbrg"].ToString() == "1";
                    ckFrmSupp.Checked = dr["frmsupp"].ToString() == "1";
                    ckFrmKat.Checked = dr["frmkat"].ToString() == "1";
                    ckFrmSat.Checked = dr["frmsat"].ToString() == "1";
                    ckFrmJual.Checked = dr["frmjual"].ToString() == "1";
                    ckFrmLap.Checked = dr["frmlap"].ToString() == "1";
                    ckFrmKas.Checked = dr["frmkas"].ToString() == "1";
                    ckFrmPass.Checked = dr["frmpass"].ToString() == "1";
                    ckFrmSet.Checked = dr["frmset"].ToString() == "1";

                    H.DsbControls(txtId);
                }
            }
        }
    }
}
