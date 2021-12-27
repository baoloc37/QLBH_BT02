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


namespace QLBH
{
    public partial class fQuanLy : Form
    {
        string loaiTK = "";
        public fQuanLy()
        {
            InitializeComponent();
        }
        public fQuanLy(string loaiTK)
        {
            InitializeComponent();
            this.loaiTK = loaiTK;
        }
        private void fQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_BaoCao_Click_1(object sender, EventArgs e)
        {
            if (loaiTK == "User")
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Focus();
            }
            else
            {
                fBaoCao fm = new fBaoCao();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
        }

        private void btn_TaiKhoan_Click_1(object sender, EventArgs e)
        {
            if (loaiTK == "User")
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Focus();
            }
            else
            {
                fTaiKhoan fm = new fTaiKhoan();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Bạn có muốn đăng xuất?"), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                fLogin fm = new fLogin();
                this.Close();
                fm.ShowDialog();
            }
        }

        private void btn_HoaDon_Click_1(object sender, EventArgs e)
        {
            fHoaDon fm = new fHoaDon();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btn_SanPham_Click_1(object sender, EventArgs e)
        {
            if (loaiTK == "User")
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Focus();
            }
            else
            {
                fSanPham fm = new fSanPham();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang fm = new fKhachHang();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

    }
}
