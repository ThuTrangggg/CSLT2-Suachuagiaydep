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
            if (rdoQuy.Checked == false && rdoThang.Checked == false &&rdoNam.Checked==false|| cboLuachon.Text == "")
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
                cmd.Parameters.Add(new SqlParameter("@ngaynhan",Convert.ToString(12)));
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
            if(rdoNam.Checked==true)
            {
                cboLuachon.Items.Clear();
                cboLuachon.Items.Add("2022");
                cboLuachon.Items.Add("2021");
            }
        }
        private void cboLuachonmax_DropDown(object sender, EventArgs e)
        {
            if (rdoQuymax.Checked == true)
            {
                cboLuachonmax.Items.Clear();
                cboLuachonmax.Items.Add("1");
                cboLuachonmax.Items.Add("2");
                cboLuachonmax.Items.Add("3");
                cboLuachonmax.Items.Add("4");
            }
            if (rdoThangmax.Checked == true)
            {
                cboLuachonmax.Items.Clear();
                cboLuachonmax.Items.Add("1");
                cboLuachonmax.Items.Add("2");
                cboLuachonmax.Items.Add("3");
                cboLuachonmax.Items.Add("4");
                cboLuachonmax.Items.Add("5");
                cboLuachonmax.Items.Add("6");
                cboLuachonmax.Items.Add("7");
                cboLuachonmax.Items.Add("8");
                cboLuachonmax.Items.Add("9");
                cboLuachonmax.Items.Add("10");
                cboLuachonmax.Items.Add("11");
                cboLuachonmax.Items.Add("12");
            }
            if(rdoNammax.Checked==true)
            {
                cboLuachonmax.Items.Clear();
                cboLuachonmax.Items.Add("2022");
                cboLuachonmax.Items.Add("2021");
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
        private void rdoThangmax_CheckedChanged(object sender, EventArgs e)
        {
            cboLuachonmax.Text = "";
        }
        private void rdoQuymax_CheckedChanged(object sender, EventArgs e)
        {
            cboLuachonmax.Text = "";
        }
        private void rdoNammax_CheckedChanged(object sender, EventArgs e)
        {
            cboLuachonmax.Text = "";
            cboLuachonmax.Text = "2022";
        }
    }
}
