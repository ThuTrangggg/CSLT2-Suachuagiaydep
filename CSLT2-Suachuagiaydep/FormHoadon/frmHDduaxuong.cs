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
    public partial class frmHDduaxuong : Form
    {
        DataTable tblHDD;
        public frmHDduaxuong()
        {
            InitializeComponent();
        }

        private void frmHDduaxuong_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnInhoadon.Enabled = false;
            txtMaHDdua.Enabled = false;
            txtChatlieu.ReadOnly = true;
            txtMaHDdua.ReadOnly = true;
            txtDongia.ReadOnly = true;
            txtMausac.ReadOnly = true;
            txtSize.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtYeucaulam.ReadOnly = true;
            txtTongtien.Text = "0";
            txtGiamgia.Text = "";
            txtTenxuong.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            Functions.fillcombo("SELECT MaNV FROM tblNhanvien",cboManhanvien,"manv", "tennv");
            cboManhanvien.SelectedIndex = -1;
            Functions.fillcombo("SELECT MaSP FROM tblSanpham", cboMaSP,"MaSP","tensp");
            cboMaSP.SelectedIndex = -1;
            Functions.fillcombo("SELECT Maxuong FROM tblXuong", cboMaxuong,"Maxuong","maxuong");
            cboMaxuong.SelectedIndex = -1;

            Functions.fillcombo("SELECT mahddua FROM tblChitietHDduaxuong", cboMaHDdua,
           "mahddua", "mahddua");
            cboMaHDdua.SelectedIndex = -1;

            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHDdua.Text != "")
            {
                Load_ThongtinHD();
                btnXoa.Enabled = true;
                btnInhoadon.Enabled = true;
            }
            Load_DataGridViewChitiet();

        }
        private void Load_ThongtinHD()
        {
            string str;
            str = "SELECT ngaydua FROM tblHDduaxuong WHERE mahddua = N'" + txtMaHDdua.Text + "'";
            txtNgaydua.Text = Functions.GetFieldValues(str);

            str = "SELECT manv FROM tblhdduaxuong WHERE mahddua = N'" + txtMaHDdua.Text + "'";
            cboManhanvien.Text = Functions.GetFieldValues(str);

            str = "SELECT maxuong FROM tblhdduaxuong WHERE mahddua = N'" + txtMaHDdua.Text + "'";
            cboMaxuong.Text = Functions.GetFieldValues(str);

            str = "SELECT Tongtien FROM tblhdduaxuong WHERE mahddua = N'" + txtMaHDdua.Text + "'";
            txtTongtien.Text = Functions.GetFieldValues(str);

            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongtien.Text);

        }
        private void Load_DataGridViewChitiet()
        {
            string sql;
            sql = "SELECT a.MaSP,TenSP,Makhach,b.soluong,a.size,a.mau,Yeucaulam,a.Dongia," +
                "Giamgia,Thanhtien,Datracuahang " +
                "from tblSanpham as a, tblChitietHDduaxuong as b " +
                "where a.MaSP = b.MaSP and MaHDdua = N'"+txtMaHDdua.Text+"'";
            //sql = "Select * from tblSanpham";
            tblHDD = Functions.GetDataToTable(sql);
            DgridHDD.DataSource = tblHDD;

            /*DgridHDD.Columns[0].HeaderText = "Mã sản phẩm";
            DgridHDD.Columns[1].HeaderText = "Tên sản phẩm";
            DgridHDD.Columns[2].HeaderText = "Mã khách";
            DgridHDD.Columns[3].HeaderText = "số lượng";
            DgridHDD.Columns[4].HeaderText = "size";
            DgridHDD.Columns[5].HeaderText = "Màu";
            DgridHDD.Columns[0].HeaderText = "Yêu cầu làm";
            DgridHDD.Columns[1].HeaderText = "Ghi chú";
            DgridHDD.Columns[2].HeaderText = "Đã trả cua hang";
            DgridHDD.Columns[3].HeaderText = "Yêu cầu làm";
            DgridHDD.Columns[4].HeaderText = "Đơn giá";
            DgridHDD.Columns[5].HeaderText = "Thành tiền";
            DgridHDD.Columns[0].Width = 80;
            DgridHDD.Columns[1].Width = 100;
            DgridHDD.Columns[2].Width = 80;
            DgridHDD.Columns[3].Width = 90;
            DgridHDD.Columns[4].Width = 90;
            DgridHDD.Columns[5].Width = 90;
            DgridHDD.Columns[6].Width = 80;
            DgridHDD.Columns[7].Width = 100;
            DgridHDD.Columns[8].Width = 80;
            DgridHDD.Columns[9].Width = 90;
            DgridHDD.Columns[10].Width = 90;
            DgridHDD.Columns[11].Width = 90;*/
            DgridHDD.AllowUserToAddRows = false;
            DgridHDD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHDdua.Text = Functions.CreateKey("HDD");
            Load_DataGridViewChitiet();
        }
        private void ResetValues()
        {
            txtMaHDdua.Text = "";
            txtNgaydua.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            cboMaxuong.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            txtTenxuong.Text = "";
            //cboMakhach.Text = "";
            txtTongtien.Text = "0";
            cboMaSP.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
            txtGhichu.Text = "";
            Load_DataGridViewChitiet();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double  SLcon, tong, Tongmoi;
            sql = "SELECT MaHDdua FROM tblHDduaxuong WHERE Mahddua=N'" + txtMaHDdua.Text + "'";
            if (!Functions.checkkey(sql))
            {
                if (txtNgaydua.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày đưa", "Thông báo",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgaydua.Focus();
                    return;
                }
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboManhanvien.Focus();
                    return;
                }
                if (cboMaxuong.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã xưởng", "Thông báo",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaxuong.Focus();
                    return;
                }

                sql = "INSERT INTO tblHDduaxuong(Mahddua, Manv, Maxuong, ngaydua, Tongtien) " +
                    "VALUES(N'" + txtMaHDdua.Text.Trim() + "', '"+cboManhanvien.Text.Trim()+"','"
                    +cboMaxuong.SelectedValue + "',N'" 
                    +Functions.ConvertDateTime(txtNgaydua.Text.Trim()) + "'," + txtTongtien.Text + ")";
                Functions.runsql(sql);
            }
            //Lưu thông tin mặt hàng
            if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                txtSize.Focus();
                return;
            }
            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
                txtGiamgia.Focus();
                return;
            }
           

            sql = "SELECT Masp FROM tblChitietHDduaxuong WHERE Masp=N'" + cboMaSP.SelectedValue + "' AND MaHDdua = N'" + txtMaHDdua.Text.Trim() + "'";
            if (Functions.checkkey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValueGiayDep();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            double sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanpham" +
                " WHERE masp = N'" + cboMaSP.SelectedValue + "'"));

            if (Convert.ToDouble(txtSoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ có " + sl, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            string datra;
            if (chkDatra.Checked == true)
                 datra= "roi";
            else
                datra = "chua";

            sql = "INSERT INTO tblChitietHDduaxuong(MaHDdua,MaSP,Makhach,Size,Mau, Yeucaulam," +
                "Dongia,giamgia,thanhtien,anh,ghichu,datracuahang,soluong) " +
                "VALUES(N'"+ txtMaHDdua.Text.Trim() + "',N'" + cboMaSP.SelectedValue + 
                "','"+txtMakhach.Text+"','"+ txtSize.Text + "','"+txtMausac.Text + "','" + txtYeucaulam.Text + "','"
                + txtDongia.Text +"','"+txtGiamgia.Text+"','"+txtThanhtien.Text+"','khong co anh','"+txtGhichu.Text+"','"+datra+"','"+txtSoluong.Text+"')";
            Functions.runsql(sql);
            Load_DataGridViewChitiet();

            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblSanpham SET Soluong =" + SLcon + " WHERE masp= N'" 
                +cboMaSP.SelectedValue + "'";
            Functions.runsql(sql);
            
            // Cập nhật lại tổng tiền cho hóa đơn bán

            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Tongtien FROM tblhdduaxuong " +
                "WHERE mahddua = N'" + txtMaHDdua.Text + "'"));

            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE tblhdduaxuong SET Tongtien =" + Tongmoi + " WHERE mahddua = N'"
                +txtMaHDdua.Text + "'";

            Functions.runsql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());

            ResetValueGiayDep();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnInhoadon.Enabled = true;
        }
        private void ResetValueGiayDep()
        {
            cboMaSP.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
            txtMausac.Text = "";
            txtSize.Text = "";
            txtMakhach.Text = "";
            txtYeucaulam.Text = "";
            txtChatlieu.Text = "";
            txtGhichu.Text = "";
            chkDatra.Checked = false;
            txtDongia.Text = "";
        }
        private void cboMaxuong_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaxuong.Text == "")
            {
                txtTenxuong.Text = "";
                txtDiachi.Text = "";
                mskDienthoai.Text = "";
            }
            //Khi kich chon Ma khach thi ten khach, dia chi, dien thoai se tu dong hien ra
            str = "Select tenxuong from tblxuong where maxuong = N'" + cboMaxuong.SelectedValue+"'";
            txtTenxuong.Text = Functions.GetFieldValues(str);
            str = "Select Diachi from tblxuong where maxuong = N'" + cboMaxuong.SelectedValue+ "'";
            txtDiachi.Text = Functions.GetFieldValues(str);
            str = "Select Dienthoai from tblxuong where maxuong= N'" + cboMaxuong.SelectedValue+ "'";
            mskDienthoai.Text = Functions.GetFieldValues(str);
        }

        private void cboMaSP_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaSP.Text == "")
            {
                txtDongia.Text = "";
            }
            // Khi kich chon Ma hang thi ten hang va gia ban se tu dong hien ra
            str = "select Makhach,mau,Yeucaulam,Chatlieu,Size " +
                "from tblHDnhanhang as a join tblChitietHDnhanhang as b " +
                "on a.MaHDnhan = b.MaHDnhan and MaSP = N'"+cboMaSP.SelectedValue+"'";
            txtMakhach.Text = Functions.GetFieldValues(str);

            str = "select mau from tblHDnhanhang as a join tblChitietHDnhanhang as b " +
                "on a.MaHDnhan = b.MaHDnhan and MaSP = N'" + cboMaSP.SelectedValue + "'";
            txtMausac.Text = Functions.GetFieldValues(str);

            str = "select Yeucaulam from tblHDnhanhang as a join tblChitietHDnhanhang as b " +
                "on a.MaHDnhan = b.MaHDnhan and MaSP = N'" + cboMaSP.SelectedValue + "'";
            txtYeucaulam.Text = Functions.GetFieldValues(str);

            str = "select chatlieu from tblHDnhanhang as a join tblChitietHDnhanhang as b " +
                "on a.MaHDnhan = b.MaHDnhan and MaSP = N'" + cboMaSP.SelectedValue + "'";
            txtChatlieu.Text = Functions.GetFieldValues(str);

            str = "select size from tblHDnhanhang as a join tblChitietHDnhanhang as b " +
                "on a.MaHDnhan = b.MaHDnhan and MaSP = N'" + cboMaSP.SelectedValue + "'";
            txtSize.Text = Functions.GetFieldValues(str);

            str = "select dongia from tblHDnhanhang as a join tblChitietHDnhanhang as b " +
                "on a.MaHDnhan = b.MaHDnhan and MaSP = N'" + cboMaSP.SelectedValue + "'";
            txtDongia.Text = Functions.GetFieldValues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
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

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
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

        private void DgridHDD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Masp;
            Double Thanhtien;
            if (tblHDD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                Masp = DgridHDD.CurrentRow.Cells["MaSP"].Value.ToString();
                DelHang(txtMaHDdua.Text, Masp);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Thanhtien = Convert.ToDouble(DgridHDD.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongtien(txtMaHDdua.Text, Thanhtien);
                Load_DataGridViewChitiet();
            }

        }
        private void DelHang(string Mahoadon, string masp)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT Soluong FROM tblChitietHDduaxuong WHERE Mahddua = N'" + Mahoadon + "' " +
                "AND masp = N'" + masp + "'";
            s = Convert.ToDouble(Functions.GetFieldValues(sql));
            sql = "DELETE tblChitietHDduaxuong WHERE MaHDdua=N'" + Mahoadon + "' AND masp = N'"
                + masp + "'";
            Functions.RunSqlDel(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT Soluong FROM tblSanpham WHERE masp = N'" + masp + "'";
            sl = Convert.ToDouble(Functions.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblSanpham SET Soluong =" + SLcon + " WHERE masp= N'" + masp + "'";
            Functions.runsql(sql);
        }
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT Tongtien FROM tblHDduaxuong WHERE maHDdua = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(Functions.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHDduaxuong SET Tongtien =" + Tongmoi + " WHERE mahddua = N'" + Mahoadon + "'";
            Functions.runsql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT masp FROM tblChitietHDduaxuong WHERE mahddua = N'" +txtMaHDdua.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Functions.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //Xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                    DelHang(txtMaHDdua.Text, Mahang[i]);
                //Xóa hóa đơn
                sql = "DELETE tblHDduaxuong WHERE mahddua=N'" + txtMaHDdua.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                Load_DataGridViewChitiet();
                btnXoa.Enabled = false;
                btnInhoadon.Enabled = false;
            }

        }

        private void btnInhoadon_Click(object sender, EventArgs e)
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
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN ĐƯA XƯỞNG";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.Mahddua, a.ngaydua, a.Tongtien, tenxuong, b.Diachi," +
                "Dienthoai, tennv FROM tblHDduaxuong AS a, tblxuong AS b, tblNhanvien AS c WHERE " +
                "a.mahddua = N'" + txtMaHDdua.Text + "' AND a.maxuong = b.maxuong AND a.manv =" +
                "c.manv";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn đưa xưởng:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Xưởng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT tensp, a.Soluong, a.dongia, a.Giamgia, a.Thanhtien " +
                  "FROM tblChitietHDduaxuong AS a , tblsanpham AS b WHERE a.MaHDdua = N'" +
                  txtMaHDdua.Text + "' AND a.masp = b.masp";
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
            exSheet.Name = "Hóa đơn đưa xưởng";
            exApp.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnInhoadon.Enabled = false;
            btnHuy.Enabled = false;
            ResetValueGiayDep();
            ResetValues();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMaHDdua.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaHDdua.Focus();
                return;
            }
            txtMaHDdua.Text = cboMaHDdua.Text;
            Load_ThongtinHD();
            Load_DataGridViewChitiet();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnInhoadon.Enabled = true;
            cboMaHDdua.SelectedIndex = -1;

        }

        private void cboMaHDdua_DropDown(object sender, EventArgs e)
        {
            Functions.fillcombo("SELECT mahddua FROM tblhdduaxuong", cboMaHDdua, "mahddua","mahddua");
            cboMaHDdua.SelectedIndex = -1;
        }
    }
}

