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
    public partial class frmBcaoHDnhanhang : Form
    {
        SqlConnection con = new SqlConnection();

        public frmBcaoHDnhanhang()
        {
            InitializeComponent();
        }

        private void frmBcaoHDnhanhang_Load(object sender, EventArgs e)
        {

            con.ConnectionString = Properties.Settings.Default.QuanLyGiayDepConnectionString;
            this.rpvBcaoHDnhan.RefreshReport();

        }

        private void cboLuachon_DropDown(object sender, EventArgs e)
        {
            if (rdoQuy.Checked == true)
            {
                cboLuachon.Items.Clear();
                cboLuachon.Items.Add("1");
                cboLuachon.Items.Add("2");
                cboLuachon.Items.Add("3");
                cboLuachon.Items.Add("4");
            }
            else
            {
                cboLuachon.Items.Clear();
                cboLuachon.Items.Add("1");
                cboLuachon.Items.Add("2");
                cboLuachon.Items.Add("3");
                cboLuachon.Items.Add("4");
                cboLuachon.Items.Add("5");
                cboLuachon.Items.Add("6");
                cboLuachon.Items.Add("7");
                cboLuachon.Items.Add("8");
                cboLuachon.Items.Add("9");
                cboLuachon.Items.Add("10");
                cboLuachon.Items.Add("11");
                cboLuachon.Items.Add("12");
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if(rdoQuy.Checked==false &&rdoThang.Checked== false || cboLuachon.Text == "")
            {
                MessageBox.Show("Hãy nhập lựa chọn");
                return;
            }
            if (rdoQuy.Checked == true)
            {
                String sql = "Select * from tblHDnhanhang Where datepart(qq,ngaynhan)= '" + cboLuachon.Text + "'";
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
                rds.Name = "DataSetBcaoHDnhanhang";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvBcaoHDnhan.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvBcaoHDnhan.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvBcaoHDnhan.RefreshReport();
            }
            else
            {
                String sql = "Select * from tblHDnhanhang Where month(ngaynhan)= '" + cboLuachon.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);

               /* //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
                rpvBcaoHDnhan.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                //Đường dẫn báo cáo
                rpvBcaoHDnhan.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BcaoHDnhanhangrp.rdlc";
                //Nếu có dữ liệu
                MessageBox.Show("Có " + ds.Tables[0].Rows.Count.ToString() + " dữ liệu thoả mãn");
*/
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSetBcaoHDnhanhang";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvBcaoHDnhan.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvBcaoHDnhan.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvBcaoHDnhan.RefreshReport();
            } 

            
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            String sql = "Select * from tblHDnhanhang";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetBcaoHDnhanhang";
            rds.Value = ds.Tables;
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            //rpvBcaoHDnhan.LocalReport.DataSources.Clear();

        }

        private void rdoQuy_CheckedChanged(object sender, EventArgs e)
        {
            String sql = "Select * from tblHDnhanhang";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
           /* //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rpvBcaoHDnhan.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpvBcaoHDnhan.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BcaoHDnhanhangrp.rdlc";
            //Nếu có dữ liệu
            MessageBox.Show("Có " + ds.Tables[0].Rows.Count.ToString() + " dữ liệu thoả mãn");
            //Tạo nguồn dữ liệu cho báo cáo*/
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetBcaoHDnhanhang";
            rds.Value = ds.Tables;
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            //rpvBcaoHDnhan.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            //rpvBcaoHDnhan.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            rpvBcaoHDnhan.RefreshReport();
        }
    }
}
