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
    public partial class fHoaDon : Form
    {
        ConnectionDB cd = new ConnectionDB();
        int flag;
        public fHoaDon()
        {
            InitializeComponent();
        }
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            fKhachHang fm = new fKhachHang();
            fm.ShowDialog();
            this.Show();
            FillComboKH();
        }
        private void fHoaDon_Load(object sender, EventArgs e)
        { 
            try
            {
                cd.DataConnection();
                var cmd = new SqlCommand("SelectAllHD", cd.conStr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                var dap = new SqlDataAdapter(cmd);
                var tblHD = new DataTable();
                dap.Fill(tblHD);

                dgv_HoaDon.DataSource = tblHD;
                dgv_HoaDon.AllowUserToAddRows = false;
                dgv_HoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
                LoadDataGridView();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FillComboHD();
            FillComboKH();

            txt_MaSP.Enabled = false;
            txt_TenSP.Enabled = false;
            txt_TenKH.Enabled = false;
            txt_NgayBan.Enabled = false;
            txt_SDT.Enabled = false;
            txt_SoLuong.Enabled = false;

            btn_SuaCTHD.Enabled = true;
            dis_enb(false);
        }

        void dis_enb(bool e)
        {
            btn_HuyHD.Enabled = e;
            btn_LuuHD.Enabled = e;

            btn_ThemHD.Enabled = !e;
            btn_XoaHD.Enabled = !e;
        }
        private void LoadDataGridView()
        {
            cb_MaHD.DataBindings.Clear();
            cb_MaHD.DataBindings.Add("Text", dgv_HoaDon.DataSource, "MaHD", true, DataSourceUpdateMode.Never);
            cb_MaKH.DataBindings.Clear();
            cb_MaKH.DataBindings.Add("Text", dgv_HoaDon.DataSource, "MaKH", true, DataSourceUpdateMode.Never);
            txt_NgayBan.DataBindings.Clear();
            txt_NgayBan.DataBindings.Add("Text", dgv_HoaDon.DataSource, "NgayBan", true, DataSourceUpdateMode.Never);
            lbl_TongTien.DataBindings.Clear();
            lbl_TongTien.DataBindings.Add("Text", dgv_HoaDon.DataSource, "TongTien", true, DataSourceUpdateMode.Never);
        }
        private void LoadDataGridView_CTHD()
        {
            cd.DataConnection();
            var cmd = new SqlCommand("USP_SelectAllCTHD", cd.conStr);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cb_MaHD.Text;
            cmd.ExecuteNonQuery();
            var dap = new SqlDataAdapter(cmd);
            var tblCTHD = new DataTable();
            dap.Fill(tblCTHD);
            dgv_CTHD.DataSource = tblCTHD;
            txt_MaSP.DataBindings.Clear();
            txt_MaSP.DataBindings.Add("Text", dgv_CTHD.DataSource, "MaSP", true, DataSourceUpdateMode.Never);
            txt_SoLuong.DataBindings.Clear();
            txt_SoLuong.DataBindings.Add("Text", dgv_CTHD.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
            txt_TenSP.DataBindings.Clear();
            txt_TenSP.DataBindings.Add("Text", dgv_CTHD.DataSource, "TenSanPham", true, DataSourceUpdateMode.Never);
            lbl_ThanhTien.DataBindings.Clear();
            lbl_ThanhTien.DataBindings.Add("Text", dgv_CTHD.DataSource, "ThanhTien", true, DataSourceUpdateMode.Never);
        }
        private void FillComboHD()
        {
            cd.DataConnection();
            var cmd = new SqlCommand("Select * From HoaDon", cd.conStr);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ada.Fill(tb);
            cb_MaHD.DataSource = tb;
            cb_MaHD.ValueMember = "MaHD";
            cb_MaHD.DisplayMember = "MaHD";
            cb_MaKH.DataBindings.Clear();
            cb_MaKH.DataBindings.Add("Text", cb_MaHD.DataSource, "MaKH", true, DataSourceUpdateMode.Never);
        }
        private void FillComboKH()
        {
            cd.DataConnection();
            var cmd = new SqlCommand("Select * From KhachHang", cd.conStr);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ada.Fill(tb);
            cb_MaKH.DataSource = tb;
            cb_MaKH.ValueMember = "MaKH";
            cb_MaKH.DisplayMember = "MaKH";
            txt_TenKH.DataBindings.Clear();
            txt_TenKH.DataBindings.Add("Text", cb_MaKH.DataSource, "HoTen");
            txt_SDT.DataBindings.Clear();
            txt_SDT.DataBindings.Add("Text", cb_MaKH.DataSource, "SDT");
        }
        private void btn_HuyHD_Click(object sender, EventArgs e)
        {
            fHoaDon_Load(sender, e);
            dis_enb(false);
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            string name = cb_MaHD.Text;
            try
            {
                if (MessageBox.Show(string.Format($"Bạn có muốn xóa hoá đơn có mã {name}"), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    cd.DataConnection();
                    var cmd = new SqlCommand("USP_DeleteHD", cd.conStr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cb_MaHD.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa hoá đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fHoaDon_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_TimHD_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txt_TimKiemHD.Text != "")
                {
                    cd.DataConnection();
                    var cmd = new SqlCommand("USP_TimKiemHD", cd.conStr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cb_TieuChi.Text;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txt_TimKiemHD.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    dgv_HoaDon.DataSource = table;
                    LoadDataGridView();
                    LoadDataGridView_CTHD();
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
            btn_LuuHD.Enabled = false;
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            flag = 1;
            FillComboKH();
            cb_MaHD.Text = "";
            lbl_TongTien.Text = "0";

            cb_MaKH.Enabled = true;
            txt_TenKH.Enabled = false;
            txt_NgayBan.Enabled = true;
            dis_enb(true);
        }
        private int CheckDay(string date)
        {
            DateTime dt1 = DateTime.Parse(date);
            DateTime dt2 = DateTime.Now;

            return (dt1.Date >= dt2.Date) ? 1 : 0;
        }
        private void btn_LuuHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == 1)
                {
                    if (CheckDay(txt_NgayBan.Text) == 0)
                    {
                        MessageBox.Show("Ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cd.DataConnection();
                        var cmd = new SqlCommand("USP_ThemHD", cd.conStr);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = cb_MaKH.Text;
                        cmd.Parameters.Add("@NgayBan", SqlDbType.DateTime).Value = txt_NgayBan.Text;
                        cmd.ExecuteNonQuery();
                        fCTHD f = new fCTHD();
                        f.ShowDialog();
                    }
                }
                else
                {
                    if (txt_SoLuong.Text == "")
                    {
                        MessageBox.Show("Không được để trống số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (Convert.ToInt32(txt_SoLuong.Text) > CheckSP(txt_MaSP.Text))
                        {
                            string thongbao = string.Format("Số lượng hàng còn lại của {0} là không đủ!" + System.Environment.NewLine + "Còn lại: {1} ", txt_TenSP.Text, CheckSP(txt_MaSP.Text));
                            MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cd.DataConnection();
                            var cmd = new SqlCommand("USP_UpdateCTHD", cd.conStr);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cb_MaHD.Text;
                            cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = txt_MaSP.Text;
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Convert.ToInt32(txt_SoLuong.Text);
                            cmd.ExecuteNonQuery();
                            LoadDataGridView_CTHD();
                            dis_enb(false);
                            btn_SuaCTHD.Enabled = true;
                        }
                    }
                }    
                
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int CheckSP(string sp)
        {
            int valueRow = 0;
            cd.DataConnection();
            var cmd = new SqlCommand("select SoLuong from SanPham where MaSP = @MaSP", cd.conStr);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = sp;
            cmd.ExecuteNonQuery();
            SqlDataReader rds = cmd.ExecuteReader();
            while (rds.Read())
                valueRow = Convert.ToInt32(rds.GetValue(0).ToString());

            return valueRow;
        }
        private void cb_MaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView_CTHD();
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_XoaCTHD_Click_1(object sender, EventArgs e)
        {
            string name = txt_TenSP.Text;
            string ma = cb_MaHD.Text;
            try
            {
                if (MessageBox.Show(string.Format($"Bạn có muốn xóa sản phẩm {name} của hoá đơn {ma} ?"), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    cd.DataConnection();
                    var cmd = new SqlCommand("USP_DeleteCTHD", cd.conStr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cb_MaHD.Text;
                    cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = txt_MaSP.Text;
                    cmd.ExecuteNonQuery();
                    LoadDataGridView_CTHD();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xoá sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_SuaCTHD_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            txt_SoLuong.Text = "0";
            txt_SoLuong.Enabled = true;

            btn_SuaCTHD.Enabled = false;
            dis_enb(true);
        }
    }
}
