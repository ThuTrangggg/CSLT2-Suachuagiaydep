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
            pic1.Visible = false;
            pic2.Visible = false;
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmBaocao a = new frmBaocao();
//a.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanpham a = new frmSanpham();
            a.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang a = new frmKhachhang();
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

        private void danhSáchSảnPhẩmChưaTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaocao.frmBaocaoSPchuatra a = new FormBaocao.frmBaocaoSPchuatra();
            a.Show();
        }

        private void danhSáchHoáĐơnĐưaXưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaocao.frmBcaoHDduaxuong a = new FormBaocao.frmBcaoHDduaxuong();
            a.Show();
        }

        private void mnuBcaoHDnhan_Click(object sender, EventArgs e)
        {
            FormBaocao.frmBcaoHDnhanhang a = new FormBaocao.frmBcaoHDnhanhang();
            a.Show();
        }

        private void mnuHDnhanhang_Click(object sender, EventArgs e)
        {
            frmHDnhan a = new frmHDnhan();
            a.Show();
        }

        private void mnuHDduaxuong_Click(object sender, EventArgs e)
        {
            frmHDduaxuong a = new frmHDduaxuong();
            a.Show();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            frmTimkiemKH a = new frmTimkiemKH();
            a.Show();
        }

        private void mnuSanpham_Click(object sender, EventArgs e)
        {
            frmTimkiemSP a = new frmTimkiemSP();
            a.Show();
        }

        private void mnuFindHDnhanhang_Click(object sender, EventArgs e)
        {
            frmTimkiemHDnhan a = new frmTimkiemHDnhan();
            a.Show();
        }

        private void mnuFindHDduaxuong_Click(object sender, EventArgs e)
        {
            frmTimkiemHDdua a = new frmTimkiemHDdua();
            a.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBcaoDSKH_Click(object sender, EventArgs e)
        {
            FormBaocao.frmBcaoKH a = new FormBaocao.frmBcaoKH();
            a.Show();
        }

        private void danhMụcToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void hoáĐơnToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic0.Visible = false;
            pic1.Visible = true;
            pic2.Visible = false;
            lblNhom7.Visible = false;
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic0.Visible = false;
            pic1.Visible = false;
            pic2.Visible = true;
            lblNhom7.Visible = false;

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic0.Visible = true;
            pic1.Visible = false;
            pic2.Visible = false;
            lblNhom7.Visible = false;
        }

        private void báoCáoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pic0.Visible = false;
            pic1.Visible = false;
            pic2.Visible = true;
            lblNhom7.Visible = false;
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
