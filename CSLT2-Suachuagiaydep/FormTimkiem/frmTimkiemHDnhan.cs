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
            tb_maHD.Focus();
        }
        private void bt_tim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((tb_maHD.Text == "") && (tb_thang.Text == "") && (tb_nam.Text == "") && (tb_tenkhach.Text == ""))
            {
                MessageBox.Show("hay nhap mot dieu kien", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = " Select * from tblHDnhanhang where 1=1";
            if (tb_maHD.Text != "")
                sql = sql + "AND MAHDnhan like N'%" + tb_maHD.Text + "%'";
            if (tb_ngay.Text != "")
                sql = sql + "AND day(Ngaynhan) like N '%" +tb_ngay.Text+ "%'";
            if (tb_thang.Text != "")
                sql = sql + "AND month(Ngaynhan) like N'%" + tb_thang.Text + "%'";
            if (tb_nam.Text != "")
                sql = sql + "AND Year(Ngaynhan) like N '%" + tb_nam.Text + "%'";
            if (tb_tenkhach.Text != "")
                sql = sql + "AND Makhach like N'%" + tb_tenkhach.Text + "%'";
            tblHD = Functions.GetDataToTable(sql);
            if (tblHD.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thoả mãn điều kiện", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
                MessageBox.Show("có" + tblHD.Rows.Count + "bản ghi thoả mãn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtgv_HD.DataSource = tblHD;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            dtgv_HD.Columns[0].HeaderText = " MaHDnhan";
            dtgv_HD.Columns[1].HeaderText = " MaNV";
            dtgv_HD.Columns[2].HeaderText = " Makhach";
            dtgv_HD.Columns[3].HeaderText = " Ngaynhan";
            dtgv_HD.Columns[4].HeaderText = " Tongtien";
            dtgv_HD.Columns[0].Width = 150;
            dtgv_HD.Columns[1].Width = 100;
            dtgv_HD.Columns[2].Width = 80;
            dtgv_HD.Columns[3].Width = 80;
            dtgv_HD.Columns[4].Width = 80;
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
                frm.Text = MaHDnhan;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
