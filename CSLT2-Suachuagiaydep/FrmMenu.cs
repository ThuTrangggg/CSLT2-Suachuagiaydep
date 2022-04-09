using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLT2_Suachuagiaydep
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Functions.connect();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocao a = new frmBaocao();
            a.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanpham a = new frmSanpham();
            a.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhangcs a = new frmKhachhangcs();
            a.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien a = new frmNhanvien();
            a.Show();
        }

        private void xưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuong a = new frmXuong();
            a.Show();
        }
    }
}
