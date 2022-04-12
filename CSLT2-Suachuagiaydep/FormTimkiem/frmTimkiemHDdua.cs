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
            if ((tb_masp.Text == "") && (tb_thang.Text == "") && (tb_nam.Text == "") && (tb_ngay.Text == ""))
            {
                MessageBox.Show("hay nhap mot dieu kien", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = " Select * from frmChitietHDnhanhang where 1=1";
            if (tb_masp.Text != "")
                sql = sql + "AND MAHD like N'%" + tb_masp + "%'";
            if (tb_thang.Text != "")
                sql = sql + "AND THang like N'%" + tb_thang + "%'";
            if (tb_nam.Text != "")
                sql = sql + "AND nam like N '%" + tb_nam + "%'";

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
            dtgw_HDD.Columns[1].HeaderText = " Mã NV";
            dtgw_HDD.Columns[2].HeaderText = " Mã Xưởng";
            dtgw_HDD.Columns[3].HeaderText = " Ngày đưa";
            dtgw_HDD.Columns[4].HeaderText = " Tổng tiền";
            dtgw_HDD.Columns[0].Width = 150;
            dtgw_HDD.Columns[1].Width = 100;
            dtgw_HDD.Columns[2].Width = 80;
            dtgw_HDD.Columns[3].Width = 80;
            dtgw_HDD.Columns[4].Width = 80;
            dtgw_HDD.AllowUserToAddRows = false;
            dtgw_HDD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
