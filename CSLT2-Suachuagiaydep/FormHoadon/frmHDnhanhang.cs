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
    public partial class frmHDnhan : Form
    {
        public frmHDnhan()
        {
            InitializeComponent();
        }

        private void frmHDnhan_Load(object sender, EventArgs e)
        {
            btnThemhd.Enabled = true;
            btnLuuhd.Enabled = false;
            btnHuy.Enabled = false;
            btnInhd.Enabled = false;
            txtMaHDnhan.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenkhach.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienthoai.ReadOnly = true;

            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtKhuyenmai.Text = "0";
            txtTongtien.Text = "0";

            Functions.fillcombo("SELECT Makhach FROM tblKhachhang", cboMakhach, "makhach", "makhach");
            cboMakhach.SelectedIndex = -1;

            Functions.fillcombo("SELECT MaNV FROM tblNhanvien", cboMaNV, "MaNV", "MaNV");
            cboMaNV.SelectedIndex = -1;
            /*Functions.fillcombo("SELECT MaSP FROM tblSanpham", cboMaSP, "MaSP", "tensp");
            cboMaSP.SelectedIndex = -1;*/


            Functions.fillcombo("SELECT mahdnhan FROM tblChitietHDnhanhang", cboMaHDnhan, "MaHDnhan", "MaHDnhan");
            cboMaHDnhan.SelectedIndex = -1;

            load_datagridchitiet();

            /*if (txtMaHDnhan.Text != "")
            {
                Load_ThongtinHD();
                btnXoa.Enabled = true;
                btnInhd.Enabled = true;
            }*/
        }
        private void Load_ThongtinHD()
        {
            string sql;
            sql = "SELECT Ngaynhan FROM tblHDnhanhang WHERE MaHDnhan = N'" + txtMaHDnhan.Text + "'";
            dtpNgaynhan.Value = DateTime.Parse(Functions.GetFieldValues(sql));
            sql = "SELECT MaNV FROM tblHDnhanhang WHERE MaHDnhan = N'" + txtMaHDnhan.Text + "'";
            cboMaNV.SelectedValue = Functions.GetFieldValues(sql);
            sql = "SELECT Makhach FROM tblHDnhanhang WHERE MaHDnhan = N'" + txtMaHDnhan.Text + "'";
            cboMakhach.SelectedValue = Functions.GetFieldValues(sql);
            sql = "SELECT Tongtien FROM tblHDnhanhang WHERE MaHDnhan = N'" + txtMaHDnhan.Text + "'";
            txtTGbaohanh.Text = Functions.GetFieldValues(sql);
            txtChatlieu.Text = Functions.GetFieldValues(sql);
            txtTongtien.Text = Functions.GetFieldValues(sql);
            lblTongtien.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongtien.Text);
        }
        private void load_datagridchitiet()
        {
            string sql;
            sql = "select a.MaSP, b.TenSP, a.Soluong, a.Dongia, a.Khuyenmai," +
                " a.Thanhtien,a.mau,a.Size, a.Chatlieu, a.TGbaohanh " +
                "from tblChitietHDnhanhang a join tblSanpham b " +
                "on a.MaSP = b.MaSP where MaHDnhan = N'" + txtMaHDnhan.Text + "'";
            tblHDnhan = Functions.GetDataToTable(sql);
            DataGridViewHDN.DataSource = tblHDnhan;
        }
        DataTable tblHDnhan;
        private void ResetValues()
        {
            txtMaHDnhan.Text = "";
            dtpNgaynhan.Value = DateTime.Now;
            cboMaNV.Text = "";
            cboMakhach.Text = "";
            txtTongtien.Text = "0";
            lblTongtien.Text = "Bằng chữ: ";
            cboMaSP.Text = "";
            txtSoluong.Text = "";
            txtSize.Text = "";
            txtMausac.Text = "";
            txtChatlieu.Text = "";
            mskDienthoai.Text = "";
            chkdatra.Checked = false;
            txtKhuyenmai.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void txtKhuyenmai_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtKhuyenmai.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtKhuyenmai.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void btnThemhd_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuuhd.Enabled = true;
            btnInhd.Enabled = false;
            btnThemhd.Enabled = false;
            txtMaHDnhan.Text = Functions.CreateKey("HDN");
            txtMaSP.Text = Functions.CreateKeySP("SP");
            load_datagridchitiet();

        }
        private void ResetValuesSanpham()
        {
            txtMaHDnhan.Text = "";
            dtpNgaynhan.Value = DateTime.Now;
            cboMaNV.Text = "";
            cboMakhach.Text = "";
            txtTongtien.Text = "0";
            lblTongtien.Text = "Bằng chữ: ";
            cboMaSP.Text = "";
            txtSoluong.Text = "";
            txtKhuyenmai.Text = "0";
            txtThanhtien.Text = "0";
            txtMausac.Text = "";
            txtSize.Text = "";
            txtChatlieu.Text = "";
            txtGhichu.Text = "";
            txtTGbaohanh.Text = "";
        }
        private void btnLuuhd_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLmoi, tong, Tongmoi;
            sql = "SELECT MaHDnhan FROM tblHDnhanhang WHERE MaHDnhan=N'" + txtMaHDnhan.Text + "'";
            if (!Functions.checkkey(sql))
            {
                if (dtpNgaynhan.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgaynhan.Focus();
                    return;
                }
                if (cboMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaNV.Focus();
                    return;
                }
                if (cboMakhach.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMakhach.Focus();
                    return;
                }
                sql = "Insert into tblHDnhanhang (MaHDnhan,MaNV,Ngaynhan, Makhach, Tongtien) values " +
                    "(N'" + txtMaHDnhan.Text.Trim() + "',N'" + cboMaNV.SelectedValue + "','" + 
                    Functions.ConvertDateTime(dtpNgaynhan.Text.Trim()) + "',N'" + cboMakhach.SelectedValue + "'," 
                    + txtTongtien.Text + ")";
                Functions.runsql(sql);

            }

            // Lưu thông tin của các mặt hàng
            /*if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSP.Focus();
                return;
            }*/
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            if (txtKhuyenmai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khuyến mại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhuyenmai.Focus();
                return;
            }

            sql = "SELECT MaSP FROM tblChitietHDnhanhang WHERE MaSP=N'" + cboMaSP.SelectedValue + "' " +
                "AND MaHDnhan = N'" + txtMaHDnhan.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesSanpham();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Soluong FROM tblSanpham " +
                "WHERE masp = N'" + cboMaSP.SelectedValue + "'"));
            /*if (sl > 50)
            {
                MessageBox.Show("Hang ton con nhieu, khong nhap nua" + sl, "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
            string yeucau="";
            
            if (chkVesinh.Checked == true)
            {
                yeucau = "Vệ sinh";
                
            }
            if (chkDande.Checked == false)
            {
                yeucau = yeucau + "Dán đế";
                
            }

            sql = "Insert into tblChitietHDnhanhang (MaHDnhan, MaSP, Mau, Size, Chatlieu,TGbaohanh, " +
                "soluong,Anh,Khuyenmai,Thanhtien,ghichu,datrakhach,yeucaulam,dongia) " +
                "values(N'" + txtMaHDnhan.Text.Trim() + "', N'" + cboMaSP.SelectedValue + "'," 
                + txtSoluong.Text + "," + txtMausac.Text + "','" 
                + txtSize.Text + "','" + txtDongia.Text + "," + txtKhuyenmai.Text + "," + txtThanhtien.Text + ")";
            Functions.runsql(sql);

            load_datagridchitiet();
            // Cập nhật lại
            SLmoi = sl + Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblSanpham SET Soluong =" + SLmoi + " WHERE MaSP= N'" + cboMaSP.SelectedValue + "'";
            Functions.runsql(sql);

            double gnmoi;
            gnmoi = Convert.ToDouble(Functions.GetFieldValues("SELECT Dongia FROM tblChitietHDnhanhang WHERE MaSP= N'" + cboMaSP.SelectedValue + "'"));
            txtDongia.Text = gnmoi.ToString();
            sql = "UPDATE tblSanpham SET Dongia  =" + gnmoi + " WHERE MaSP= N'" + cboMaSP.SelectedValue + "'";
            Functions.runsql(sql);
            sql = "UPDATE tblSanpham SET Dongia =" + 110 * gnmoi / 100 + " WHERE MaSP= N'" + cboMaSP.SelectedValue + "'";
            Functions.runsql(sql);

            // Cập nhật lại tổng tiền cho hóa đơn nhập

            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblhoadonnhap WHERE MaHDnhan = '" + txtMaHDnhan.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE tblHDnhanhang SET Tongtien =" + Tongmoi + " WHERE MaHDnhan = N'" + txtMaHDnhan.Text + "'";
            Functions.runsql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblTongtien.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesSanpham();
            btnHuy.Enabled = true;
            btnThemhd.Enabled = true;
            btnInhd.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnInhd_Click(object sender, EventArgs e)
        {

        }

        private void btnDonghd_Click(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            if (cboMaHDnhan.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaHDnhan.Focus();
                return;
            }
            txtMaHDnhan.Text = cboMaHDnhan.Text;
            Load_ThongtinHD();
            load_datagridchitiet();
            btnHuy.Enabled = true;
            btnLuuhd.Enabled = true;
            btnInhd.Enabled = true;
            cboMaHDnhan.SelectedIndex = -1;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

       

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtKhuyenmai_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaNV.Text == "")
                txtTenNV.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            sql = "Select TenNV from tblnhanvien where MaNV =N'" + cboMaNV.SelectedValue + "'";
            txtTenNV.Text = Functions.GetFieldValues(sql);
        }

        private void cboMakhach_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMakhach.Text == "")
            {
                txtTenkhach.Text = "";
                txtDiachi.Text = "";
                mskDienthoai.Text = "";
            }
            sql = "Select Tenkhach from tblKhachhang where Makhach = N'" + cboMakhach.SelectedValue + "'";
            txtTenkhach.Text = Functions.GetFieldValues(sql);
            sql = "Select Diachi from tblKhachhang where Makhach = N'" + cboMakhach.SelectedValue + "'";
            txtDiachi.Text = Functions.GetFieldValues(sql);
            sql = "Select Dienthoai from tblKhachhang where Makhach= N'" + cboMakhach.SelectedValue + "'";
            mskDienthoai.Text = Functions.GetFieldValues(sql);
        }

        private void cboMaSP_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaSP.Text == "")
            {
                txtTenSP.Text = "";
                txtDongia.Text = "";
                txtMausac.Text = "";
                txtSize.Text = "";
            }
            sql = "SELECT TenSP, Mau, Size FROM tblSanpham WHERE MaSP =N'" + cboMaSP.SelectedValue + txtMausac.Text + "','" + txtSize.Text + "'";
            txtTenSP.Text = Functions.GetFieldValues(sql);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl,gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtKhuyenmai.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtKhuyenmai.Text);
            /*if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);*/
            tt = sl * dongia - sl * dongia * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void cboMaHDnhan_DropDown(object sender, EventArgs e)
        {
            Functions.fillcombo("SELECT MaHDnhan FROM tblhoadonnhap", cboMaHDnhan, "MaHDnhan", "MaHDnhan");
            cboMaHDnhan.SelectedIndex = -1;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaSP,Soluong FROM tblChitietHDnhanhang WHERE MaHDnhan ='" + txtMaHDnhan.Text + "'";
                DataTable tblsanpham = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblsanpham.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Soluong FROM tblSanpham WHERE MaSP = N'" + tblsanpham.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblsanpham.Rows[hang][1].ToString());
                    slcon = sl - slxoa;
                    sql = "UPDATE tblSanpham SET Soluong =" + slcon + " WHERE MaSP= N'" + tblsanpham.Rows[hang][0].ToString() + "'";
                    Functions.runsql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChitietHDnhanhang WHERE MaHDnhan ='" + txtMaHDnhan.Text + "'";
                Functions.runsql(sql);

                //Xóa hóa đơn
                sql = "DELETE tblHDnhanhang WHERE MaHDnhan ='" + txtMaHDnhan.Text + "'";
                Functions.runsql(sql);
                ResetValues();
                load_datagridchitiet();
                btnXoa.Enabled = false;
                btnInhd.Enabled = false;
            }
        }

        private void DataGridViewHDN_DoubleClick(object sender, EventArgs e)
        {
            string MaSPxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblHDnhan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaSPxoa = DataGridViewHDN.CurrentRow.Cells["MaSP"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(DataGridViewHDN.CurrentRow.Cells["Soluong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(DataGridViewHDN.CurrentRow.Cells["Thanhtien"].Value.ToString());
                sql = "DELETE tblChitietHDnhan WHERE MaHDnhan='" + txtMaHDnhan.Text + "' AND MaSP = N'" + MaSPxoa + "'";
                Functions.runsql(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Soluong FROM tblSanpham WHERE MaSP = N'" + MaSPxoa + "'"));
                slcon = sl - SoLuongxoa;
                sql = "UPDATE tblSanpham SET Soluong =" + slcon + " WHERE MaSP= N'" + MaSPxoa + "'";
                Functions.runsql(sql);
                // Cập nhật lại tổng tiền cho hóa đơn nhập
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Tongtien FROM tblHDnhan WHERE MaHDnhan = '" + txtMaHDnhan.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE tblHDnhan SET Tongtien =" + tongmoi + " WHERE MaHDnhan= '" + txtMaHDnhan.Text + "'";
                Functions.runsql(sql);
                txtTongtien.Text = tongmoi.ToString();
                lblTongtien.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
                load_datagridchitiet();
            }
        }
        double dongia = 0;

        private void chkVesinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVesinh.Checked == true)
            {
                dongia = dongia + 2000;
            }
            else dongia = dongia - 2000;
                txtDongia.Text = dongia.ToString();


        }

        private void chkDande_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDande.Checked == true)
            {
                dongia = dongia + 1000;
            }
            else dongia = dongia - 1000;
            txtDongia.Text = dongia.ToString();

        }
        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtKhuyenmai.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtKhuyenmai.Text);
            /*if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);*/
            tt = sl * dongia - sl * dongia * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }
    }
}

