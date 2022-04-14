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
using Microsoft.Reporting.WinForms;

namespace CSLT2_Suachuagiaydep.FormBaocao
{
    public partial class frmBcaoHDduaxuong : Form
    {
        SqlConnection con = new SqlConnection();
        public frmBcaoHDduaxuong()
        {
            InitializeComponent();
        }
        private void frmBcaoHDduaxuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bcaoHDmaxtongtien._BcaoHDmaxtongtien' table. You can move, or remove it, as needed.
            this.bcaoHDmaxtongtienTableAdapter.Fill(this.bcaoHDmaxtongtien._BcaoHDmaxtongtien);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\ADMIN\source\repos\Nhóm7_CT\CSLT2-Suachuagiaydep\DatasetReport\BaocaoHDduaxuong.rdlc";
            rpvHDmaxtongtien.LocalReport.ReportPath = @"C:\Users\ADMIN\source\repos\Nhóm7_CT\CSLT2-Suachuagiaydep\DatasetReport\BcaoHDmaxtongtien.rdlc";
            // TODO: This line of code loads data into the 'baocaoHDduaxuong.tblHDduaxuong' table. You can move, or remove it, as needed.
            this.tblHDduaxuongTableAdapter.Fill(this.baocaoHDduaxuong.tblHDduaxuong);
            reportViewer1.RefreshReport();
            this.rpvHDmaxtongtien.RefreshReport();
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            String sql = "Select * from tblHDduaxuong Where month(ngaydua) ='" + dtpNgaydua.Value.Date.Month.ToString() + "'";

            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = Properties.Settings.Default.QuanLyGiayDepConnectionString;
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            reportViewer1.LocalReport.ReportPath = @"C:\Users\ADMIN\source\repos\Nhóm7_CT\CSLT2-Suachuagiaydep\DatasetReport\BaocaoHDduaxuong.rdlc";
            //Nếu có dữ liệu
            MessageBox.Show("Có " + ds.Tables[0].Rows.Count.ToString() + " dữ liệu thoả mãn");

            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "BaocaoHDduaxuongDataSet";
            rds.Value = ds.Tables[0];
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            reportViewer1.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            reportViewer1.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            reportViewer1.RefreshReport();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            String sql = "Select MaHDdua ,a.Maxuong,Tenxuong,tongtien from tblHDduaxuong a, tblXuong b where a.Maxuong = b.Maxuong order by tongtien desc";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            /*  //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
              rpvBcaoHDnhan.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
              //Đường dẫn báo cáo
              rpvBcaoHDnhan.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BcaoHDnhanhangrp.rdlc";
              //Nếu có dữ liệu
              MessageBox.Show("Có " + ds.Tables[0].Rows.Count.ToString() + " dữ liệu thoả mãn");
*/
            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "BcaoHDmaxtongtien";
            rds.Value = ds.Tables[0];
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            rpvHDmaxtongtien.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            rpvHDmaxtongtien.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            rpvHDmaxtongtien.RefreshReport();
        }
    }
}
