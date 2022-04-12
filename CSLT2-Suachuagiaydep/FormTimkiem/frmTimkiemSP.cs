using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLT2_Suachuagiaydep
{
    public partial class frmTimkiemSP : Form
    {
        DataTable tblSP;
        public frmTimkiemSP()
        {
            InitializeComponent();
        }

        private void frmTimkiemSP_Load(object sender, EventArgs e)
        {
            resetvalues();
            dtgw_sp.DataSource = null;
        }
        private void resetvalues()
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    ctl.Text = "";

            tb_tensp.Focus();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((tb_tensp.Text == "") && (tb_tenkhach.Text == "") && (tb_mau.Text == "") && (tb_size.Text == ""))
            {
                MessageBox.Show("hay nhap mot dieu kien", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = " Select * from frmChitietHDnhanhang where 1=1";
            if (tb_tensp.Text != "")
                sql = sql + "AND MAHD like N'%" + tb_tensp + "%'";
            if (tb_tenkhach.Text != "")
                sql = sql + "AND THang like N'%" + tb_tenkhach + "%'";
            if (tb_mau.Text != "")
                sql = sql + "AND nam like N '%" + tb_mau + "%'";
            if (tb_size.Text != "")
                sql = sql + "AND tenkhach like N'%" + tb_size + "%'";
            tblSP = Functions.GetDataToTable(sql);
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thoả mãn điều kiện", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
                MessageBox.Show("có" + tblSP.Rows.Count + "bản ghi thoả mãn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtgw_sp.DataSource = tblSP;
            Load_dtgw_sp();
        }
        private void Load_dtgw_sp()
        {
            dtgw_sp.Columns[0].HeaderText = " MaSP";
            dtgw_sp.Columns[1].HeaderText = " Ten SP";
            dtgw_sp.Columns[2].HeaderText = " Số lượng";
            dtgw_sp.Columns[3].HeaderText = " Đơn giá";

            dtgw_sp.Columns[0].Width = 150;
            dtgw_sp.Columns[1].Width = 100;
            dtgw_sp.Columns[2].Width = 80;
            dtgw_sp.Columns[3].Width = 80;

            dtgw_sp.AllowUserToAddRows = false;
            dtgw_sp.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
