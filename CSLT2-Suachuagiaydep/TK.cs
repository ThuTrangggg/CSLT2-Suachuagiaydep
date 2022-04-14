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
using System.Data.Sql;
namespace CSLT2_Suachuagiaydep
{
    public partial class TK : Form
    {
        public TK()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Functions.connect();
            string sql = "select * from tblTK where Id = '" + txtID.Text.Trim() + "' " +
                "and Password = '" + txtPass.Text.Trim() + "'";
            SqlDataAdapter adptr = new SqlDataAdapter(sql, Functions.Conn);
            DataTable lgin = new DataTable();
            adptr.Fill(lgin);
            if (lgin.Rows.Count == 1)
            {
                this.Hide();
                FrmMenu frm = new FrmMenu();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hãy nhập lại đúng tài khoản và mật khẩu");
                txtPass.Text = "";
                txtID.Text = "";
            }
        }
    }
}
