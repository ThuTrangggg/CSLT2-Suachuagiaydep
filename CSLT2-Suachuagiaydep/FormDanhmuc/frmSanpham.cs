using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSLT2_Suachuagiaydep
{
    public partial class frmSanpham : Form
    {
        DataTable tblSanpham;
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            txtMaSP.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();

        }
        private void ResetValues()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoluong.Text = "0";
            txtDongia.Text = "0";
           
            txtSoluong.Enabled = false;
            txtDongia.Enabled = false;
            txtDongia.Enabled = false;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaSP, TenSP, Soluong, Dongia FROM tblSanpham";
            tblSanpham = Functions.GetDataToTable(sql);
            DataGridViewSP.DataSource = tblSanpham;

        }

        private void DataGridViewSP_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (tblSanpham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            txtMaSP.Text = DataGridViewSP.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = DataGridViewSP.CurrentRow.Cells["TenSP"].Value.ToString();            
            txtSoluong.Text = DataGridViewSP.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDongia.Text = DataGridViewSP.CurrentRow.Cells["Dongia"].Value.ToString();           
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHienthi.Enabled = false;
            btnTimkiem.Enabled = false;
            ResetValues();
            txtMaSP.Enabled = true;
            txtMaSP.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            sql = "SELECT MaSP FROM tblSanpham WHERE MaSP=N'" + txtMaSP.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                txtMaSP.Text = "";
                return;
            }
            sql = "INSERT INTO tblHang(Mahang,Tenhang,Soluong,Dongia) VALUES(N'" + txtMaSP.Text.Trim() +
                    "',N'" + txtTenSP.Text.Trim() + "',N'"  + txtSoluong.Text.Trim() +"," + txtDongia.Text  + "')";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaSP.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSanpham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }           
            sql = "UPDATE tblSanpham SET  TenSP=N'" + txtTenSP.Text.Trim().ToString() + "' WHERE MaSP=N'" + txtMaSP.Text + "'";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSanpham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblSanpham WHERE Mahang=N'" + txtMaSP.Text + "'";
                Functions.runsql(sql);
                Load_DataGridView();
                ResetValues();
            }

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSP.Enabled = false;

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaSP.Text == "") && (txtTenSP.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblSanpham WHERE 1=1";
            if (txtMaSP.Text != "")
                sql = sql + " AND MaSP Like N'%" + txtMaSP.Text + "%'";
            if (txtTenSP.Text != "")
                sql = sql + " AND TenSP Like N'%" + txtTenSP.Text + "%'";
            
            if (tblSanpham.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblSanpham.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DataGridViewSP.DataSource = tblSanpham;
            ResetValues();

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaSP, TenSP, Soluong, Dongianhap, Dongiaban FROM tblSanpham";
            tblSanpham = Functions.GetDataToTable(sql);
            DataGridViewSP.DataSource = tblSanpham;

        }
    }
}
