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
    public partial class frmBaocaoSPchuatra : Form
    {
        SqlConnection con = new SqlConnection();

        public frmBaocaoSPchuatra()
        {
            InitializeComponent();
        }

        private void frmBaocaoSPchuatra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bcaoSPxuongchuatra.BcaoSPxuongchuatra' table. You can move, or remove it, as needed.
            this.bcaoSPxuongchuatraTableAdapter.Fill(this.bcaoSPxuongchuatra._BcaoSPxuongchuatra,dtpSPchuatracuahang.Value);
            rpvSPchuatracuahang.LocalReport.ReportPath = @"C:\Users\ADMIN\source\repos\Nhóm7_CT\CSLT2-Suachuagiaydep\DatasetReport\BcaoSPxuongchuatra.rdlc";
            //rptSPdatra.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BaocaoSPdatra.rdlc";
            this.bcaodanhsachhdTableAdapter.Fill(this.bCaoSPchuatrakhach.Bcaodanhsachhd, dtpSPdatra.Value);
            // TODO: This line of code loads data into the 'bcaoSPdatra.Bcaodanhsachhd' table. You can move, or remove it, as needed.
            //this.bcaoSPxuongchuatraTableAdapter.Fill(this.bcaoSPxuongchuatra._BcaoSPxuongchuatra, dtpSPchuatracuahang.Value);
           // this.bcaodanhsachhdTableAdapter.Fill(this.bcaoSPdatra.Bcaodanhsachhd,dtpSPdatra.Value);

            this.rptSPdatra.RefreshReport();
            this.rpvSPchuatracuahang.RefreshReport();
            // this.rptSPdatra.RefreshReport();
            this.rptSPdatra.RefreshReport();
        }

        private void btnSPchuatracuahang_Click(object sender, EventArgs e)
        {
            con.ConnectionString = Properties.Settings.Default.QuanLyGiayDepConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BcaoSPxuongchuatra";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ngaydua", dtpSPchuatracuahang.Value.Date));

            //Khai báo dataset để chứa dữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //Thiết lập thông số liên quan đến báo cáo
            rpvSPchuatracuahang.ProcessingMode = ProcessingMode.Local; //sử dụng dữ liệu ở local
            rpvSPchuatracuahang.LocalReport.ReportPath = @"C:\Users\ADMIN\source\repos\Nhóm7_CT\CSLT2-Suachuagiaydep\DatasetReport\BcaoSPxuongchuatra.rdlc";
            MessageBox.Show("Có " + ds.Tables[0].Rows.Count.ToString() + " dữ liệu thoả mãn");
            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "BcaoSPxuongchuatraDataSet";
            rds.Value = ds.Tables[0];
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            rpvSPchuatracuahang.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            rpvSPchuatracuahang.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            rpvSPchuatracuahang.RefreshReport();
        }

        private void btnThongkedatra_Click_1(object sender, EventArgs e)
        {
            con.ConnectionString = Properties.Settings.Default.QuanLyGiayDepConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Bcaodanhsachhd";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ngaynhan", dtpSPdatra.Value.Date));

            //Khai báo dataset để chứa dữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //Thiết lập thông số liên quan đến báo cáo
            rptSPdatra.ProcessingMode = ProcessingMode.Local; //sử dụng dữ liệu ở local
            rptSPdatra.LocalReport.ReportPath = @"C:\Users\ADMIN\source\repos\Nhóm7_CT\CSLT2-Suachuagiaydep\DatasetReport\RpBcaoSPchuatrakhach.rdlc";
            MessageBox.Show("Có " + ds.Tables[0].Rows.Count.ToString() + " dữ liệu thoả mãn");
            
            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DatasetSPchuatrakhach";
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
