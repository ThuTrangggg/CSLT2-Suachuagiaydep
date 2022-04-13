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

            txtTensp.Focus();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTensp.Text == "") && (txtMasp.Text == "") && (txtMau.Text == "") && (txtSize.Text == ""))
            {
                MessageBox.Show("hay nhap mot dieu kien", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = " select masp,tensp,soluong,dongia,mau,size,ghichu from tblSanpham where 1=1";
            if (txtTensp.Text != "")
                sql = sql + "AND TenSP like N'%" + txtTensp.Text + "%'";
            if (txtMasp.Text != "")
                sql = sql + "AND masp like N'%" + txtMasp.Text + "%'";
            if (txtMau.Text != "")
                sql = sql + "AND mau like N'%"+txtMau.Text + "%'";
            if (txtSize.Text != "")
                sql = sql + "AND Size like N'%" + txtSize.Text + "%'";
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
            dtgw_sp.Columns[0].HeaderText = " Mã sản phẩm";
            dtgw_sp.Columns[1].HeaderText = " Tên sản phẩm";
            dtgw_sp.Columns[2].HeaderText = "Số lượng";
            dtgw_sp.Columns[3].HeaderText = "Đơn giá";
            dtgw_sp.Columns[4].HeaderText = "Màu";
            dtgw_sp.Columns[5].HeaderText = "Size";
            dtgw_sp.Columns[6].HeaderText = "Ghi chú";

            dtgw_sp.Columns[0].Width = 150;
            dtgw_sp.Columns[1].Width = 100;
            dtgw_sp.Columns[2].Width = 80;
            dtgw_sp.Columns[3].Width = 80;
            dtgw_sp.Columns[4].Width = 80;
            dtgw_sp.Columns[5].Width = 80;
            dtgw_sp.Columns[6].Width = 80;
            dtgw_sp.AllowUserToAddRows = false;
            dtgw_sp.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            resetvalues();
            dtgw_sp.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgw_sp_DoubleClick(object sender, EventArgs e)
        {
            string MaSP;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                MaSP = dtgw_sp.CurrentRow.Cells["MaSP"].Value.ToString();
                frmSanpham frm = new frmSanpham();
                frm.txtMaSP.Text = MaSP;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
