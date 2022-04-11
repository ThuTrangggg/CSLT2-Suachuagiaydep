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
    public partial class frmBcaoKH : Form
    {
        public frmBcaoKH()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();

        private void frmBcaoKH_Load(object sender, EventArgs e)
        {

            this.rpvKH.RefreshReport();
            this.rpvKHmax.RefreshReport();
            rpvKH.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BcaoKHrpv.rdlc";
            con.ConnectionString = Properties.Settings.Default.QuanLyGiayDepConnectionString;
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (rdoQuy.Checked == false && rdoThang.Checked == false || cboLuachon.Text == "")
            {
                MessageBox.Show("Hãy nhập lựa chọn");
                return;
            }
            if (rdoQuy.Checked == true)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BcaoKH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@ngaynhan",'0'));
                cmd.Parameters.Add(new SqlParameter("@ngaynhanquy", cboLuachon.Text));

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "BcaoKHDS";
                rds.Value = ds.Tables[0];
                MessageBox.Show("Có " + ds.Tables[0].Rows.Count.ToString() + " dữ liệu thoả mãn");
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvKH.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvKH.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvKH.RefreshReport();
            }
            if(rdoThang.Checked==true)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BcaoKH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@ngaynhanquy",'0'));
                cmd.Parameters.Add(new SqlParameter("@ngaynhan",cboLuachon.Text));
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
                ReportDataSource rds = new ReportDataSource();
                MessageBox.Show("Có " + ds.Tables[0].Rows.Count.ToString() + " dữ liệu thoả mãn");

                rds.Name = "BcaoKHDS";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvKH.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvKH.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvKH.RefreshReport();
            }
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
            if (rdoThang.Checked == true)
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
        
        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            cboLuachon.Text = "";
        }
        private void rdoQuy_CheckedChanged(object sender, EventArgs e)
        {
            cboLuachon.Text = "";
        }
        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {
            cboLuachon.Text = "";
            cboLuachon.Text = "2022";

        }

        private void rdoTongtien_CheckedChanged(object sender, EventArgs e)
        {
            rpvKHmax.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BcaoKHmaxtongtien.rdlc";
            String sql = "Select top 3 a.Makhach,Tenkhach,sum(tongtien) from tblHDnhanhang a, tblKhachhang b " +
                "where a.Makhach = b.Makhach " +
                "group by a.Makhach,Tenkhach order by sum(tongtien) desc";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "KHMaxtongtien";
            rds.Value = ds.Tables[0];
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            rpvKHmax.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            rpvKHmax.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            rpvKHmax.RefreshReport();
        }

        private void rdoSoluongHD_CheckedChanged(object sender, EventArgs e)
        {
            rpvKHmax.LocalReport.ReportPath = "C:\\Users\\ADMIN\\source\\repos\\CSLT2-Suachuagiaydep\\CSLT2-Suachuagiaydep\\DatasetReport\\BcaoKHmaxsoluong.rdlc";
            String sql = "Select top 3 a.Makhach,Tenkhach,count(mahdnhan) from tblHDnhanhang a, tblKhachhang b " +
                "where a.Makhach = b.Makhach " +
                "group by a.Makhach,Tenkhach order by count(mahdnhan) desc";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "BcaoKHmaxsoluongds";
            rds.Value = ds.Tables[0];
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            rpvKHmax.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            rpvKHmax.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            rpvKHmax.RefreshReport();
        }
    }
}
