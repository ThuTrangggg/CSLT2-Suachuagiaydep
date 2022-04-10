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
    public partial class frmXuong : Form
    {
        DataTable tblXuong;
        public frmXuong()
        {
            InitializeComponent();
        }

        private void frmXuong_Load(object sender, EventArgs e)
        {
            txtMaxuong.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void ResetValues()
        {
            txtMaxuong.Text = "";
            txtTenxuong.Text = "";
            txtDiachi.Text = "0";
            mskDienthoai.Text = "0";
            mskDienthoai.Enabled = false;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Maxuong, Tenxuong, Diachi, Dienthoai FROM tblXuong";
            tblXuong = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblXuong;

        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaxuong.Focus();
                return;
            }
            if (tblXuong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaxuong.Text = DataGridView.CurrentRow.Cells["Maxuong"].Value.ToString();
            txtTenxuong.Text = DataGridView.CurrentRow.Cells["Tenxuong"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
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
            ResetValues();
            txtMaxuong.Enabled = true;
            txtMaxuong.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaxuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã xưởng", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtMaxuong.Focus();
                return;
            }
            if (txtTenxuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtTenxuong.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     ")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
           
            sql = "INSERT INTO tblXuong(Maxuong,Tenxuong, Diachi, Dienthoai) VALUES(N'" + txtMaxuong.Text.Trim() + "', N'" + txtTenxuong.Text.Trim() + "', N'"  + "', N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text  + "')";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaxuong.Enabled = false;


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblXuong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaxuong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenxuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenxuong.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }

            sql = "UPDATE tblXuong SET  Tenxuong=N'" + txtTenxuong.Text.Trim().ToString() +
                    "',Diachi=N'" + txtDiachi.Text.Trim().ToString() +
                    "',Dienthoai='" + mskDienthoai.Text.ToString() +
                    "' WHERE Manv=N'" + txtMaxuong.Text + "'";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblXuong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaxuong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblXuong WHERE Maxuong=N'" + txtMaxuong.Text + "'";
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
            txtMaxuong.Enabled = false;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
