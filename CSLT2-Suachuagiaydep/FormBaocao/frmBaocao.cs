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
            this.tblHDduaxuongTableAdapter.Fill(this.baocaoHDduaxuong.tblHDduaxuong);
            // TODO: This line of code loads data into the 'quanLyGiayDepDataSet.tblSanpham' table. You can move, or remove it, as needed.
            load();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void load()
        {
            /*string sql = "	SELECT a.MaSP,TenSP,Ngaynhan,Makhach from tblSanpham as a, tblChitietHDnhanhang as b, tblHDnhanhang as c    where a.MaSP = b.MaSP and b.MaHDnhan = c.MaHDnhan";
            tbl = Functions.GetDataToTable(sql);
            dtagridview.DataSource = tbl;*/
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "Select * from tblHDduaxuong Where month(ngaydua) >='" + dtpNgaydua.Value.Month.ToString() + "'";
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
            reportViewer1.LocalReport.ReportPath = "BaocaoHDduaxuong.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "tblHDduaxuong";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                reportViewer1.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }
        }
        private void load_data()
        {
          /*  string sql;
            sql = "select * from tblHDnhanhang";
            //viet code lay du lieu tu tblchat lieu len datagridview (dung chung cho nhieu bang => viet trong functions)
            DataTable tblCL = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblCL; //Hiển thị dữ liệu lên datagridview*/
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
