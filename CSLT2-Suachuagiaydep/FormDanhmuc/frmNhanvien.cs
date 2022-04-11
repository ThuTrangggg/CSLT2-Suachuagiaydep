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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Manv, Tennv, Gioitinh, Diachi,Namsinh, TenCongviec, Luong FROM tblNhanvien";
            tblNhanvien = Functions.GetDataToTable(sql);
            DataGridViewNV.DataSource = tblNhanvien;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManv.Enabled = true;
            txtManv.Focus();
        }
        private void ResetValues()
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            chkGioitinh.Checked = false;
            txtDiachi.Text = "";
            mskNamsinh.Text = "";
            txtCongviec.Text = "";
            txtLuong.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennv.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (txtCongviec.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCongviec.Focus();
                return;
            }
            if (txtLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Lương ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return;
            }
            if (mskNamsinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNamsinh.Focus();
                return;
            }
            /*if (!Functions.IsDate(mskNamsinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNamsinh.Text = "";
                mskNamsinh.Focus();
                return;
            }*/
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanvien SET  Tennv=N'" + txtTennv.Text.Trim().ToString() +
                    "',Diachi=N'" + txtDiachi.Text.Trim().ToString() +
                    "',Luong=N'" + txtLuong.Text.Trim().ToString() +
                    "',Tencongviec= N'" + txtCongviec.Text.ToString() + "',Gioitinh=N'" + gt +
                    "',Namsinh='" + Functions.ConvertDateTime(mskNamsinh.Text) + "',Anh=N'" + txtAnh.Text +
                    "' WHERE Manv=N'" + txtManv.Text + "'";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanvien WHERE Manv=N'" + txtManv.Text + "'";
                Functions.runsql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManv.Focus();
                return;
            }
            if (txtTennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennv.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (txtLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return;
            }
            if (txtCongviec.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCongviec.Focus();
                return;
            }
            if (mskNamsinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNamsinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNamsinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNamsinh.Text = "";
                mskNamsinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT Manv FROM tblNhanvien WHERE Manv=N'" + txtManv.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManv.Focus();
                txtManv.Text = "";
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh đại diện cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }

            sql = "INSERT INTO tblNhanvien VALUES(N'" + txtManv.Text.Trim() + "', N'" + txtTennv.Text.Trim() + "', N'" + gt + "', N'" + Functions.ConvertDateTime(mskNamsinh.Text) + "',N'" + txtDiachi.Text.Trim() + "',N'" + txtAnh.Text + "',N'" + txtCongviec.Text.Trim().ToString() + "', N'" + txtLuong.Text + "')";
            Functions.runsql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManv.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManv.Enabled = false;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }

        }

        private void DataGridViewNV_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Focus();
                return;
            }
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManv.Text = DataGridViewNV.CurrentRow.Cells["Manv"].Value.ToString();
            txtTennv.Text = DataGridViewNV.CurrentRow.Cells["Tennv"].Value.ToString();
            txtCongviec.Text = DataGridViewNV.CurrentRow.Cells["Tencongviec"].Value.ToString();
            txtLuong.Text = DataGridViewNV.CurrentRow.Cells["Luong"].Value.ToString();
            if (DataGridViewNV.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
                chkGioitinh.Checked = true;
            else
                chkGioitinh.Checked = false;
            txtDiachi.Text = DataGridViewNV.CurrentRow.Cells["Diachi"].Value.ToString();
            mskNamsinh.Text = DataGridViewNV.CurrentRow.Cells["Namsinh"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
            txtAnh.Text = Functions.GetFieldValues("SELECT Anh FROM tblNhanvien WHERE MaNV = N'" + txtManv.Text + "'");
            picAnh.Image = Image.FromFile(txtAnh.Text);

        }
        DataTable tblNhanvien;

    }
}
