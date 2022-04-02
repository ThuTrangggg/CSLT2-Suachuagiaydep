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
namespace CSLT2_Suachuagiaydep.Form_Baocao
{
    public partial class frmBaocao : Form
    {
        DataTable tbl;
        public frmBaocao()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data();
        }
        private void load_data()
        {
            string sql = "select *from tblSP";
            tbl = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tbl;
        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {

        }
    }
}
