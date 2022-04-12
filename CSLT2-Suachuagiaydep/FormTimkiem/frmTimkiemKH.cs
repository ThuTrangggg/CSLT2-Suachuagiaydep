﻿using System;
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
    public partial class frmTimkiemKH : Form
    {
        public frmTimkiemKH()
        {
            InitializeComponent();
        }
        DataTable tblKH;

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((tb_makhach.Text == "") && (tb_tennkhach.Text == ""))
            {
                MessageBox.Show("hay nhap mot dieu kien", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = " Select * from frmChitietHDnhanhang where 1=1";
            if (tb_makhach.Text != "")
                sql = sql + "AND MAHD like N'%" + tb_makhach + "%'";
            if (tb_tennkhach.Text != "")
                sql = sql + "AND THang like N'%" + tb_tennkhach + "%'";

            tblKH = Functions.GetDataToTable(sql);
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thoả mãn điều kiện", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
                MessageBox.Show("có" + tblKH.Rows.Count + "bản ghi thoả mãn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtgw_KH.DataSource = tblKH;
            Load_dtgw_sp();
        }
        private void Load_dtgw_sp()
        {
            dtgw_KH.Columns[0].HeaderText = " Max khách";
            dtgw_KH.Columns[1].HeaderText = " Tên khách";
            dtgw_KH.Columns[2].HeaderText = " Địa chỉ";
            dtgw_KH.Columns[3].HeaderText = " Điện thoại";


            dtgw_KH.Columns[0].Width = 150;
            dtgw_KH.Columns[1].Width = 100;
            dtgw_KH.Columns[2].Width = 80;
            dtgw_KH.Columns[3].Width = 80;

            dtgw_KH.AllowUserToAddRows = false;
            dtgw_KH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void resetvalues()
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    ctl.Text = "";

            tb_makhach.Focus();
        }

        private void frmTimkiemKH_Load(object sender, EventArgs e)
        {
            resetvalues();
            dtgw_KH.DataSource = null;
        }
    }
}
