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
    public partial class frmTimkiemHDdua : Form
    {
        public frmTimkiemHDdua()
        {
            InitializeComponent();
        }
        private void frmTimkiemHDdua_Load(object sender, EventArgs e)
        {

        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHDD.Text == "") && (txtNgay.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") && (txtMasp.Text == ""))
            {
                MessageBox.Show("hay nhap mot dieu kien", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = " Select a.mahddua,a.masp,a.makhach,ngaydua,thanhtien from tblChitietHDduaxuong as a join tblHDduaxuong as b on a.mahddua=b.mahddua   where 1=1";
            if (txtMaHDD.Text != "")
                sql = sql + "AND a.MAHDdua like N'%" + txtMaHDD.Text + "%'";
            if (txtMasp.Text != "")
                sql = sql + "AND a.masp like N'%" + txtMasp.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + "AND month(ngaydua)='" + txtThang.Text + "'";
            if (txtNam.Text != "")
                sql = sql + "AND year(ngaydua) ='" + txtNam.Text + "'";
            if (txtNgay.Text != "")
                sql = sql + "AND day(ngaydua) = '" + txtNgay.Text + "'";
            tblHDD = Functions.GetDataToTable(sql);
            if (tblHDD.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thoả mãn điều kiện", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
                MessageBox.Show("có" + tblHDD.Rows.Count + "bản ghi thoả mãn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtgw_HDD.DataSource = tblHDD;
            Load_DataGridView();
        }
        DataTable tblHDD;
        private void resetvalues()
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    ctl.Text = "";

            txtNgay.Focus();
        }
        private void Load_DataGridView()
        {
            dtgw_HDD.Columns[0].HeaderText = "Mã hoá đơn đưa";
            dtgw_HDD.Columns[1].HeaderText = "Mã sản phẩm";
            dtgw_HDD.Columns[2].HeaderText = "Mã khách";
            dtgw_HDD.Columns[3].HeaderText = "Ngày đưa";
            dtgw_HDD.Columns[4].HeaderText = "Thành tiền";
            dtgw_HDD.Columns[0].Width = 100;
            dtgw_HDD.Columns[1].Width = 100;
            dtgw_HDD.Columns[2].Width = 100;
            dtgw_HDD.Columns[3].Width = 100;
            dtgw_HDD.Columns[4].Width = 100;
            dtgw_HDD.AllowUserToAddRows = false;
            dtgw_HDD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            resetvalues();
            dtgw_HDD.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgw_HDD_DoubleClick(object sender, EventArgs e)
        {
            string MaHDdua;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                MaHDdua = dtgw_HDD.CurrentRow.Cells["MaHDdua"].Value.ToString();
                frmHDduaxuong a = new frmHDduaxuong();
                a.txtMaHDdua.Text = MaHDdua;
                a.StartPosition = FormStartPosition.CenterScreen;
                a.ShowDialog();
            }
        }
    }
}
