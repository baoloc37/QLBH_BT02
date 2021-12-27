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
    public partial class fKhachHang : Form
    {
        ConnectionDB cd = new ConnectionDB();
        int flag = 0;
        public fKhachHang()
        {
            InitializeComponent();
        }
        private void fKhachHang_Load(object sender, EventArgs e)
        {
            string sql = "Select * from KhachHang";
            try
            {
                cd.DataConnection();
                var cmd = new SqlCommand(sql, cd.conStr);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                var dap = new SqlDataAdapter(cmd);
                var tblKH = new DataTable();
                dap.Fill(tblKH);

                dgv_KhachHang.DataSource = tblKH;
                dgv_KhachHang.AllowUserToAddRows = false;
                dgv_KhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txt_MaKH.Enabled = false;
            txt_TenKH.Enabled = false;
            txt_SDT.Enabled = false;
            txt_DiaChi.Enabled = false;
            LoadDataGridView();

            dis_enb(false);
        }
        private void LoadDataGridView()
        {
            txt_MaKH.DataBindings.Clear();
            txt_MaKH.DataBindings.Add("Text", dgv_KhachHang.DataSource, "MaKH", true, DataSourceUpdateMode.Never);
            txt_TenKH.DataBindings.Clear();
            txt_TenKH.DataBindings.Add("Text", dgv_KhachHang.DataSource, "HoTen", true, DataSourceUpdateMode.Never);
            txt_SDT.DataBindings.Clear();
            txt_SDT.DataBindings.Add("Text", dgv_KhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never);
            txt_DiaChi.DataBindings.Clear();
            txt_DiaChi.DataBindings.Add("Text", dgv_KhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
        }
        void dis_enb(bool e)
        {
            btn_HuyKH.Enabled = e;
            btn_LuuKH.Enabled = e;

            btn_ThemKH.Enabled = !e;
            btn_XoaKH.Enabled = !e;
            btn_SuaKH.Enabled = !e;
        }

        private void btn_HuyKH_Click(object sender, EventArgs e)
        {
            fKhachHang_Load(sender, e);
            dis_enb(false);
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enb(true);
            txt_MaKH.Enabled = false;
            txt_TenKH.Enabled = true;
            txt_SDT.Enabled = true;
            txt_DiaChi.Enabled = true;
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            flag = 0;

            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";

            txt_MaKH.Enabled = false;
            txt_TenKH.Enabled = true;
            txt_SDT.Enabled = true;
            txt_DiaChi.Enabled = true;
            dis_enb(true);
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            string name = txt_TenKH.Text;
            try
            {
                if (MessageBox.Show(string.Format($"Bạn có muốn xóa khách hàng {name}"), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    cd.DataConnection();
                    var cmd = new SqlCommand("USP_DeleteKH", cd.conStr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = txt_MaKH.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fKhachHang_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Xoá khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_TimKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_TieuchiKH.Text != "" && txt_TimKH.Text != "")
                {
                    cd.DataConnection();
                    var cmd = new SqlCommand("USP_TimKiemKH", cd.conStr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cb_TieuchiKH.Text;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txt_TimKH.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    dgv_KhachHang.DataSource = table;
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
            btn_LuuKH.Enabled = false;
        }

        private void btn_LuuKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == 0)
                {
                    if (txt_TenKH.Text != "" && txt_SDT.Text != "" && txt_DiaChi.Text != "")
                    {
                        if (txt_SDT.Text.Trim().Length != 10)
                        {
                            MessageBox.Show("Số điện thoại phải là 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cd.DataConnection();
                            var cmd = new SqlCommand("USP_ThemKH", cd.conStr);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = txt_TenKH.Text;
                            cmd.Parameters.Add("@dienThoai", SqlDbType.Char).Value = txt_SDT.Text;
                            cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txt_DiaChi.Text;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm khách hàng mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (txt_TenKH.Text != "" && txt_SDT.Text != "" && txt_DiaChi.Text != "")
                    {
                        if (txt_SDT.Text.Trim().Length != 10)
                        {
                            MessageBox.Show("Số điện thoại phải là 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cd.DataConnection();
                            var cmd = new SqlCommand("USP_UpdateKH", cd.conStr);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = txt_MaKH.Text;
                            cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = txt_TenKH.Text;
                            cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = txt_SDT.Text;
                            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txt_DiaChi.Text;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sửa thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fKhachHang_Load(sender, e);
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}


