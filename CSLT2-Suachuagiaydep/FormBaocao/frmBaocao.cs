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
            load();
            //this.reportViewer1.RefreshReport();
        }
        private void load()
        {
            string sql = "	SELECT a.MaSP,TenSP,Ngaynhan,Makhach from tblSanpham as a, tblChitietHDnhanhang as b, tblHDnhanhang as c    where a.MaSP = b.MaSP and b.MaHDnhan = c.MaHDnhan";
            tbl = Functions.GetDataToTable(sql);
            dtagridview.DataSource = tbl;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\QuanLyGiayDep.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Bcaodanhsachhd";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ngaynhan"), dateTimePicker1.Value.Date);
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);*/
            string sql = "Select * from tblHDnhanhang where ngaynhan="+dtpNgay.Value.ToString()+"";
            Functions.runsql(sql);
            load_data();
        }
        private void load_data()
        {
            string sql;
            sql = "select * from tblHDnhanhang";
            //viet code lay du lieu tu tblchat lieu len datagridview (dung chung cho nhieu bang => viet trong functions)
            DataTable tblCL = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblCL; //Hiển thị dữ liệu lên datagridview
        }
    }
}
