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
            if ((tb_HDD.Text == "") && (tb_masp.Text == "") && (tb_ngay.Text == "") && (tb_thang.Text == "") && (tb_nam.Text == ""))
            {
                MessageBox.Show("hay nhap mot dieu kien", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = " Select MaHDdua, MaSP,MaKhach, Thanhtien,Ghichu from tblChitietHDduaxuong  where 1=1";
            if (tb_HDD.Text != "")
                sql = sql + "AND MaHDdua like N '%" + tb_HDD.Text + "%'";
            if (tb_masp.Text != "")
                sql = sql + "AND MaSP like N'%" + tb_masp.Text + "%'";
            if (tb_ngay.Text != "")
                sql = sql + "AND day(ngaydua) '%" + tb_ngay.Text + "%'";
            if (tb_thang.Text != "")
                sql = sql + "AND month(ngaydua) like N'%" + tb_thang.Text + "%'";
            if (tb_nam.Text != "")
                sql = sql + "AND year(ngaydua) like N '%" + tb_nam.Text + "%'";

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

            tb_masp.Focus();
        }
        private void Load_DataGridView()
        {
            dtgw_HDD.Columns[0].HeaderText = " MaHDdua";
            dtgw_HDD.Columns[1].HeaderText = " MaSP";
            dtgw_HDD.Columns[2].HeaderText = " Makhach";
            dtgw_HDD.Columns[3].HeaderText = "Size";
            dtgw_HDD.Columns[4].HeaderText = "Mausac";
            dtgw_HDD.Columns[4].HeaderText = "Dongia";
            dtgw_HDD.Columns[5].HeaderText = "Giamgia";
            dtgw_HDD.Columns[6].HeaderText = "Thanhtien";
            dtgw_HDD.Columns[0].Width = 150;
            dtgw_HDD.Columns[1].Width = 100;
            dtgw_HDD.Columns[2].Width = 80;
            dtgw_HDD.Columns[3].Width = 80;
            dtgw_HDD.Columns[4].Width = 80;
            dtgw_HDD.Columns[5].Width = 80;
            dtgw_HDD.Columns[6].Width = 80;
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
                frmHDduaxuong frm = new frmHDduaxuong();
                frm.Text = MaHDdua;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
