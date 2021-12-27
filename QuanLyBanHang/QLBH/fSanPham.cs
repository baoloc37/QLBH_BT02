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
    public partial class fSanPham : Form
    {
        ConnectionDB cd = new ConnectionDB();
        int flag = 0;
        public fSanPham()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            txt_MaSP.DataBindings.Clear();
            txt_MaSP.DataBindings.Add("Text", dgv_SanPham.DataSource, "MaSP", true, DataSourceUpdateMode.Never);
            txt_TenSP.DataBindings.Clear();
            txt_TenSP.DataBindings.Add("Text", dgv_SanPham.DataSource, "TenSanPham", true, DataSourceUpdateMode.Never);
            txt_SoLuongSP.DataBindings.Clear();
            txt_SoLuongSP.DataBindings.Add("Text", dgv_SanPham.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
            txt_GiaBanSP.DataBindings.Clear();
            txt_GiaBanSP.DataBindings.Add("Text", dgv_SanPham.DataSource, "GiaBan", true, DataSourceUpdateMode.Never);
        }
        void dis_enb(bool e)
        {
            btn_HuySP.Enabled = e;
            btn_LuuSP.Enabled = e;

            btn_ThemSP.Enabled = !e;
            btn_XoaSP.Enabled = !e;
            btn_SuaSP.Enabled = !e;
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {
            string sql = "Select * from SanPham";
            try
            {
                cd.DataConnection();
                var cmd = new SqlCommand(sql, cd.conStr);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                var dap = new SqlDataAdapter(cmd);
                var tblKH = new DataTable();
                dap.Fill(tblKH);

                dgv_SanPham.DataSource = tblKH;
                dgv_SanPham.AllowUserToAddRows = false;
                dgv_SanPham.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txt_MaSP.Enabled = false;
            txt_TenSP.Enabled = false;
            txt_SoLuongSP.Enabled = false;
            txt_GiaBanSP.Enabled = false;
            LoadDataGridView();

            dis_enb(false);
        }

        private void btn_HuySP_Click(object sender, EventArgs e)
        {
            fSanPham_Load(sender, e);
            dis_enb(false);
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enb(true);
            txt_MaSP.Enabled = false;
            txt_TenSP.Enabled = true;
            txt_SoLuongSP.Enabled = true;
            txt_GiaBanSP.Enabled = true;
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            flag = 0;

            txt_MaSP.Text = "";
            txt_TenSP.Text = "";
            txt_SoLuongSP.Text = "";
            txt_GiaBanSP.Text = "";

            txt_MaSP.Enabled = false;
            txt_TenSP.Enabled = true;
            txt_SoLuongSP.Enabled = true;
            txt_GiaBanSP.Enabled = true;
            dis_enb(true);
        }

        private void btn_XoaSP_Click_1(object sender, EventArgs e)
        {
            string name = txt_TenSP.Text;
            try
            {
                if (MessageBox.Show(string.Format($"Bạn có muốn xóa sản phẩm {name}"), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    cd.DataConnection();
                    var cmd = new SqlCommand("USP_DeleteKH", cd.conStr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = txt_MaSP.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fSanPham_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Xoá sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_TimSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_TieuchiSP.Text != "" && txt_TimSP.Text != "")
                {
                    cd.DataConnection();
                    var cmd = new SqlCommand("USP_TimKiemSP", cd.conStr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cb_TieuchiSP.Text;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txt_TimSP.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    dgv_SanPham.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không thể tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dis_enb(true);
            btn_LuuSP.Enabled = false;
        }

        private void btn_LuuSP_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Int32.Parse(txt_GiaBanSP.Text);
                if (flag == 0)
                {
                    if (txt_TenSP.Text != "" && txt_SoLuongSP.Text != "" && txt_GiaBanSP.Text != "")
                    {
                        if (n < 0)
                        {
                            MessageBox.Show("Hãy nhập lại giá trị đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cd.DataConnection();
                            var cmd = new SqlCommand("USP_ThemSP", cd.conStr);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@tenSP", SqlDbType.NVarChar).Value = txt_TenSP.Text;
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Convert.ToInt32(txt_SoLuongSP.Text);
                            cmd.Parameters.Add("@DonGiaBan", SqlDbType.Int).Value = Convert.ToInt32(txt_GiaBanSP.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm sản phẩm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fSanPham_Load(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (txt_TenSP.Text != "" && txt_SoLuongSP.Text != "" && txt_GiaBanSP.Text != "")
                    {
                        if (n < 0)
                        {
                            MessageBox.Show("Hãy nhập lại giá trị đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cd.DataConnection();
                            var cmd = new SqlCommand("USP_UpdateSP", cd.conStr);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = txt_MaSP.Text;
                            cmd.Parameters.Add("@tenSP", SqlDbType.NVarChar).Value = txt_TenSP.Text;
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Char).Value = txt_SoLuongSP.Text;
                            cmd.Parameters.Add("@DonGiaBan", SqlDbType.NVarChar).Value = txt_GiaBanSP.Text;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sửa thông tin sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fSanPham_Load(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_GiaBanSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
