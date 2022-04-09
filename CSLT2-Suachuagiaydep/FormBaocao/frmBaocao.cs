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
namespace CSLT2_Suachuagiaydep
{
    public partial class frmBaocao : Form
    {
        DataTable tbl;
        public frmBaocao()
        {
            InitializeComponent();
        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baocaoHDduaxuong.tblHDduaxuong' table. You can move, or remove it, as needed.
           // this.tblHDduaxuongTableAdapter.Fill(this.baocaoHDduaxuong.tblHDduaxuong);
            // TODO: This line of code loads data into the 'bcaoSPdatra.Bcaodanhsachhd' table. You can move, or remove it, as needed.
           // this.bcaodanhsachhdTableAdapter.Fill(this.bcaoSPdatra.Bcaodanhsachhd,dtpSPdatra.Value);
            //this.reportViewer1.RefreshReport();
           // this.reportViewer1.RefreshReport();
            //this.rptSPdatra.RefreshReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "Select * from tblHDduaxuong Where month(ngaydua) ='" + dtpNgaydua.Value.Date.Month.ToString() + "'";
            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = Properties.Settings.Default.QuanLyGiayDepConnectionString;
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\FormBaocao\\BaocaoHDduaxuong.rdlc";
            //Nếu có dữ liệu
            
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
            
            //else MessageBox.Show("Khong có bản ghi nào");
            
           // this.reportViewer1.RefreshReport();

        }

        private void btnThongkedatra_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QuanLyGiayDepConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Bcaodanhsachhd";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ngaynhan",dtpSPdatra.Value.Date.Month));

            //Khai báo dataset để chứa dữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //Thiết lập thông số liên quan đến báo cáo
            rptSPdatra.ProcessingMode = ProcessingMode.Local; //sử dụng dữ liệu ở local
            rptSPdatra.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\FormBaocao\\BaocaoSPdatra.rdlc";
            MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
           
          
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "datasetbcaosp";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rptSPdatra.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rptSPdatra.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rptSPdatra.RefreshReport();
           
        }
    }
}
