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
    public partial class frmTimkiemHDnhan : Form
    {
        public frmTimkiemHDnhan()
        {
            InitializeComponent();
        }

        private void frmTimkiemHDnhan_Load(object sender, EventArgs e)
        {
            resetvalues();
            dtgv_HD.DataSource = null;
        }
        DataTable tblHD;
        private void resetvalues()
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    ctl.Text = "";
            txtMaHDN.Focus();
        }
        private void bt_tim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHDN.Text == "") && (txtNgaynhan.Text == "") && (txtThang.Text == "") && (txtTenkhach.Text == ""))
            {
                MessageBox.Show("hay nhap mot dieu kien", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = " Select mahdnhan,manv,a.makhach,ngaynhan,tongtien from tblHDnhanhang a join tblKhachhang b on a.makhach=b.makhach where 1=1";
            if (txtMaHDN.Text != "")
                sql = sql + "AND MAHDnhan like N'%" + txtMaHDN.Text + "%'";
            if (txtNam.Text != "")
                sql = sql + "AND year(Ngaynhan) ='" +txtNam.Text+ "'";
            if (txtNgaynhan.Text != "")
                sql = sql + "AND day(Ngaynhan) = '" + txtNgaynhan.Text + "'";
            if (txtThang.Text != "")
                sql = sql + "AND month(Ngaynhan) ='" + txtThang.Text + "'";
            if (txtTenkhach.Text != "")
                sql = sql + "AND tenkhach like N'%" + txtTenkhach.Text + "'";
            tblHD = Functions.GetDataToTable(sql);
            if (tblHD.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thoả mãn điều kiện", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
                MessageBox.Show("có " + tblHD.Rows.Count + " bản ghi thoả mãn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtgv_HD.DataSource = tblHD;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            dtgv_HD.Columns[0].HeaderText = " Mã hoá đơn nhận";
            dtgv_HD.Columns[1].HeaderText = " Mã nhân viên";
            dtgv_HD.Columns[2].HeaderText = " Mã khách";
            dtgv_HD.Columns[3].HeaderText = " Ngày nhận";
            dtgv_HD.Columns[4].HeaderText = " Tổng tiền";
            dtgv_HD.Columns[0].Width = 120;
            dtgv_HD.Columns[1].Width = 100;
            dtgv_HD.Columns[2].Width = 100;
            dtgv_HD.Columns[3].Width = 100;
            dtgv_HD.Columns[4].Width = 100;
            dtgv_HD.AllowUserToAddRows = false;
            dtgv_HD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            resetvalues();
            dtgv_HD.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dtgv_HD_DoubleClick(object sender, EventArgs e)
        {
            string MaHDnhan;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                MaHDnhan = dtgv_HD.CurrentRow.Cells["MaHDnhan"].Value.ToString();
                frmHDnhan frm = new frmHDnhan();
                frm.txtMaHDnhan.Text = MaHDnhan;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
