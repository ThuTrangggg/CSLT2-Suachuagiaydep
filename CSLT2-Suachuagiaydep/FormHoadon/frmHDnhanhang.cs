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
using COMExcel = Microsoft.Office.Interop.Excel;

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
            btnThemSP.Enabled = false;
            txtMaSP.ReadOnly = true;
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
            txtGiamgia.Text = "0";
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
            //txtTGbaohanh.Text = Functions.GetFieldValues(sql);
            //txtChatlieu.Text = Functions.GetFieldValues(sql);
            txtTongtien.Text = Functions.GetFieldValues(sql);
            lblTongtien.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongtien.Text);
        }
        private void load_datagridchitiet()
        {
            string sql;
            sql = "select a.MaSP, b.TenSP, a.Soluong, a.Dongia, a.Khuyenmai," +
                " a.Thanhtien,a.mau,a.Size, a.Chatlieu, a.TGbaohanh,yeucaulam " +
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
            txtMaSP.Text = "";
            txtSoluong.Text = "";
            txtSize.Text = "";
            txtMausac.Text = "";
            txtChatlieu.Text = "";
            mskDienthoai.Text = "";
            chkdatra.Checked = false;
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
            txtTenkhach.Text = "";
            txtDiachi.Text = "";
            txtTenNV.Text = "";
        }

    

        private void ResetValuesSanpham()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtMausac.Text = "";
            txtSize.Text = "";
            txtChatlieu.Text = "";
            txtTGbaohanh.Text = "";
            txtSoluong.Text = "";
            chkVesinh.Checked = false;
            chkDande.Checked = false;
            chkdatra.Checked = false;
            txtGiamgia.Text = "0";
            txtGhichu.Text = "";
            txtDongia.Text = "0";
            txtThanhtien.Text = "0";
            txtAnh.Text = "";
            lblTongtien.Text = "Bằng chữ: ";
            picAnh.Image = null;
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

        /*private void cboMaSP_TextChanged(object sender, EventArgs e)
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
        }*/

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl,gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
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
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            /*if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);*/
            tt = sl * dongia - sl * dongia * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void btnLuuhd_Click_1(object sender, EventArgs e)
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
            if (txtAnh.Text == "")
            {
                MessageBox.Show("Bạn phải chọn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khuyến mại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamgia.Focus();
                return;
            }
            sql = "SELECT MaSP FROM tblChitietHDnhanhang WHERE MaSP=N'" + txtMaSP.Text + "' " +
                "AND MaHDnhan = N'" + txtMaHDnhan.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesSanpham();
                return;
            }

            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            /* sl = Convert.ToDouble(Functions.GetFieldValues("SELECT Soluong FROM tblSanpham " +
                 "WHERE masp = N'" + txtMaSP.Text + "'"));
             if (sl > 50)
             {
                 MessageBox.Show("Hang ton con nhieu, khong nhap nua" + sl, "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
             }*/
            string yeucau = "";

            if (chkVesinh.Checked == true)
            {
                yeucau = "Ve sinh";

            }
            if (chkDande.Checked == true)
            {
                yeucau = yeucau + " Dan de";

            }
            string dtra = "";
            if (chkdatra.Checked == true)
            {
                dtra = "Rồi";
            } else dtra = "Chưa";

            sql = "insert into tblSanpham values(N'" + txtMaSP.Text + "','" + txtTenSP.Text + "','" + txtAnh.Text + "','"
                + txtGhichu.Text + "','" + txtSoluong.Text + "','" + txtDongia.Text + "','" + txtSize.Text + "','" + txtMausac.Text + "')";
            Functions.runsql(sql);

            sql = "Insert into tblChitietHDnhanhang (MaHDnhan, MaSP, Mau, Size, Chatlieu,TGbaohanh, " +
                "soluong,Anh,Khuyenmai,Thanhtien,ghichu,datrakhach,yeucaulam,dongia) " +
                "values(N'" + txtMaHDnhan.Text.Trim() + "', N'" + txtMaSP.Text + "',N'"
                + txtMausac.Text + "',N'" + txtSize.Text + "',N'"
                + txtChatlieu.Text + "','" + txtTGbaohanh.Text + "',N'" + txtSoluong.Text + "',N'" 
                + txtAnh.Text + "',N'"+txtGiamgia.Text+"',N'"+txtThanhtien.Text+"',N'"+txtGhichu.Text+"',N'"
                + dtra+"','"+yeucau+"',N'"+txtDongia.Text+"')";

            Functions.runsql(sql);
            load_datagridchitiet();

            // Cập nhật lại
            /*SLmoi = sl + Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblSanpham SET Soluong =" + SLmoi + " WHERE MaSP= N'" + txtMaSP.Text + "'";
            Functions.runsql(sql);

            double gnmoi;
            gnmoi = Convert.ToDouble(Functions.GetFieldValues("SELECT Dongia FROM tblChitietHDnhanhang WHERE MaSP= N'" + txtMaSP.Text + "'"));
            txtDongia.Text = gnmoi.ToString();
            sql = "UPDATE tblSanpham SET Dongia  =" + gnmoi + " WHERE MaSP= N'" + txtMaSP.Text + "'";
            Functions.runsql(sql);
            sql = "UPDATE tblSanpham SET Dongia =" + 110 * gnmoi / 100 + " WHERE MaSP= N'" + txtMaSP.Text + "'";
            Functions.runsql(sql);
*/
            // Cập nhật lại tổng tiền cho hóa đơn nhập

            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblHDnhanhang" +
                " WHERE MaHDnhan = '" + txtMaHDnhan.Text + "'"));

            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE tblHDnhanhang SET Tongtien =" + Tongmoi + " WHERE MaHDnhan = N'" + txtMaHDnhan.Text + "'";
            Functions.runsql(sql);

            
            txtTongtien.Text = Tongmoi.ToString();
            lblTongtien.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesSanpham();
            btnThemSP.Enabled = true;
            btnLuuhd.Enabled = false;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThemhd.Enabled = true;
            btnInhd.Enabled = true;
            btnDonghd.Enabled = true;
            btnTimkiem.Enabled = true;
        }

        private void btnThemhd_Click_1(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            btnLuuhd.Enabled = true;
            btnInhd.Enabled = false;
            btnDonghd.Enabled = false;
            btnTimkiem.Enabled = false;
            btnThemhd.Enabled = false;
            txtMaHDnhan.Text = Functions.CreateKey("HDN");
            txtMaSP.Text = Functions.CreateKey("SP");
            load_datagridchitiet();
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThemhd.Enabled = true;
            btnXoa.Enabled = false;
            btnLuuhd.Enabled = false;
            btnInhd.Enabled = false;
            btnHuy.Enabled = false;
            btnDonghd.Enabled = true;
            btnTimkiem.Enabled = true;
            ResetValuesSanpham();
            ResetValues();
        }

        private void btnInhd_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng sửa chữa nhóm 7";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Học viện Ngân hàng - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (09) 123456";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬN HÀNG";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.Mahdnhan, a.ngaynhan, a.Tongtien, tenkhach, b.Diachi," +
                "Dienthoai, tennv FROM tblHDnhanhang AS a, tblKhachhang AS b, tblNhanvien AS c WHERE " +
                "a.mahdnhan = N'" + txtMaHDnhan.Text + "' AND a.makhach = b.makhach AND a.manv =" +
                "c.manv";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn nhận hàng:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT tensp, a.Soluong, a.dongia, a.khuyenmai, a.Thanhtien " +
                  "FROM tblChitietHDnhanhang AS a , tblsanpham AS b WHERE a.mahdnhan = N'" +
                  txtMaHDnhan.Text + "' AND a.masp = b.masp";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng

            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";

            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhận hàng";
            exApp.Visible = true;
        }


        private void btnTimkiem_Click_1(object sender, EventArgs e)
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
            btnThemhd.Enabled = false;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnLuuhd.Enabled = false;
            btnInhd.Enabled = true;
            btnDonghd.Enabled = true;
            cboMaHDnhan.SelectedIndex = -1;
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text== "")
            {
                btnThemSP.Enabled = true;
                txtMaSP.Text = Functions.CreateKey("SP");
            }
            btnLuuhd.Enabled = true;
        }

        private void DataGridViewHDN_DoubleClick_1(object sender, EventArgs e)
        {
            string Masp;
            Double Thanhtien;
            btnThemSP.Enabled = false;
            if (tblHDnhan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                Masp = DataGridViewHDN.CurrentRow.Cells["MaSP"].Value.ToString();
                DelHang(txtMaHDnhan.Text, Masp);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Thanhtien = Convert.ToDouble(DataGridViewHDN.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongtien(txtMaHDnhan.Text, Thanhtien);
                load_datagridchitiet();
            }
            btnThemhd.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuuhd.Enabled = false;
            btnInhd.Enabled = true;
            btnDonghd.Enabled = true;
            btnTimkiem.Enabled = true;

        }
        private void DelHang(string Mahoadon, string masp)
        {
            Double s, sl, SLcon;
            string sql;
            /*sql = "SELECT Soluong FROM tblChitietHDnhanhang WHERE mahdnhan = N'" + Mahoadon + "' " +
                "AND masp = N'" + masp + "'";*/
            /*
            s = Convert.ToDouble(Functions.GetFieldValues(sql));*/
            sql = "DELETE tblChitietHDnhanhang WHERE mahdnhan=N'" + Mahoadon + "' AND masp = N'"
                + masp + "'";
            Functions.RunSqlDel(sql);
            sql = "delete tblSanpham where masp=N'" + masp + "'";
            Functions.RunSqlDel(sql);

            // Cập nhật lại số lượng cho các mặt hàng
            /*sql = "SELECT Soluong FROM tblSanpham WHERE masp = N'" + masp + "'";
            sl = Convert.ToDouble(Functions.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblSanpham SET Soluong =" + SLcon + " WHERE masp= N'" + masp + "'";
            Functions.runsql(sql);*/
        }
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT Tongtien FROM tblHDnhanhang WHERE Mahdnhan = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(Functions.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHDnhanhang SET Tongtien =" + Tongmoi + " WHERE mahdnhan = N'" + Mahoadon + "'";
            Functions.runsql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblTongtien.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void btnDonghd_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
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
                ResetValuesSanpham();
                load_datagridchitiet();
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                btnInhd.Enabled = false;
                btnLuuhd.Enabled = false;
                btnThemhd.Enabled = true;
                btnDonghd.Enabled = true;
                btnTimkiem.Enabled = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = @"C:\Users\ADMIN\source\repos\CSLT2-Suachuagiaydep\CSLT2-Suachuagiaydep\Resources";
            dlgOpen.FilterIndex = 3;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void cboMaHDnhan_DropDown_1(object sender, EventArgs e)
        {
            Functions.fillcombo("SELECT mahdnhan FROM tblhdnhanhang", cboMaHDnhan, "mahdnhan", "mahdnhan");
            cboMaHDnhan.SelectedIndex = -1;
        }

        private void txtGhichu_TextChanged(object sender, EventArgs e)
        {
            lblGhichu.Visible = false;
        }
    }
}

