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
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BaocaoHDduaxuong.rdlc";
            // TODO: This line of code loads data into the 'baocaoHDduaxuong.tblHDduaxuong' table. You can move, or remove it, as needed.
            this.tblHDduaxuongTableAdapter.Fill(this.baocaoHDduaxuong.tblHDduaxuong);
            reportViewer1.RefreshReport();
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
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BaocaoHDduaxuong.rdlc";
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

        
    }
}
