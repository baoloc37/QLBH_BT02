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
    public partial class fCTHD : Form
    {
        ConnectionDB cd = new ConnectionDB();
        public fCTHD()
        {
            InitializeComponent();
        }
        private void fCTHD_Load(object sender, EventArgs e)
        {
            try
            {
                FillComboSP();
                FillComboCTHD();
                LoadDataGridView();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txt_TenSP.Enabled = false;
            txt_GiaBan.Enabled = false;


            cb_MaSP.Enabled = false;
            cb_MaHD.Enabled = false;
            dis_enb(false);
        }
        void dis_enb(bool e)
        {
            btn_LuuCTHD.Enabled = e;

            btn_ThemCTHD.Enabled = !e;
            btn_XoaCTHD.Enabled = !e;
        }
        private void LoadDataGridView()
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
            dgv_CTHD.AllowUserToAddRows = false;
            dgv_CTHD.EditMode = DataGridViewEditMode.EditProgrammatically;
            cb_MaSP.DataBindings.Clear();
            cb_MaSP.DataBindings.Add("Text", dgv_CTHD.DataSource, "MaSP", true, DataSourceUpdateMode.Never);
            txt_TenSP.DataBindings.Clear();
            txt_TenSP.DataBindings.Add("Text", dgv_CTHD.DataSource, "TenSanPham", true, DataSourceUpdateMode.Never);
            txt_SoLuong.DataBindings.Clear();
            txt_SoLuong.DataBindings.Add("Text", dgv_CTHD.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
            lbl_ThanhTien.DataBindings.Clear();
            lbl_ThanhTien.DataBindings.Add("Text", dgv_CTHD.DataSource, "ThanhTien", true, DataSourceUpdateMode.Never);
            txt_GiaBan.DataBindings.Clear();
            txt_GiaBan.DataBindings.Add("Text", dgv_CTHD.DataSource, "GiaBan", true, DataSourceUpdateMode.Never);
        }

        private void FillComboCTHD()
        {
            cd.DataConnection();
            var cmd = new SqlCommand("Select Max(MaHD) as NewMaHD From HoaDon", cd.conStr);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ada.Fill(tb);
            cb_MaHD.DataSource = tb;
            cb_MaHD.ValueMember = "NewMaHD";
            cb_MaHD.DisplayMember = "NewMaHD";
        }
        private void FillComboSP()
        {
            cd.DataConnection();
            var cmd = new SqlCommand("Select * From SanPham", cd.conStr);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ada.Fill(tb);
            cb_MaSP.DataSource = tb;
            cb_MaSP.ValueMember = "MaSP";
            cb_MaSP.DisplayMember = "MaSP";
            txt_TenSP.DataBindings.Clear();
            txt_TenSP.DataBindings.Add("Text", cb_MaSP.DataSource, "TenSanPham", true, DataSourceUpdateMode.Never);
            txt_GiaBan.DataBindings.Clear();
            txt_GiaBan.DataBindings.Add("Text", cb_MaSP.DataSource, "GiaBan", true, DataSourceUpdateMode.Never);
        }
        private void btn_ThemCTHD_Click(object sender, EventArgs e)
        {
            FillComboSP();
            txt_SoLuong.Text = "0";

            cb_MaSP.Enabled = true;
            dis_enb(true);
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
        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_ThanhTien.Text = (Convert.ToInt32(txt_GiaBan.Text) * Convert.ToInt32(txt_SoLuong.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số lượng mua!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_LuuCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_SoLuong.Text) > CheckSP(cb_MaSP.Text))
                {
                    string thongbao = string.Format("Số lượng hàng còn lại của {0} là không đủ!" + System.Environment.NewLine + "Còn lại: {1} ", txt_TenSP.Text, CheckSP(cb_MaSP.Text));
                    MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cd.DataConnection();
                    var cmd = new SqlCommand("USP_InsertCTHD", cd.conStr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cb_MaHD.Text;
                    cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = cb_MaSP.Text;
                    cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = txt_SoLuong.Text;
                    cmd.ExecuteNonQuery();
                    fCTHD_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_XoaCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                cd.DataConnection();
                var cmd = new SqlCommand("USP_DeleteCTHD", cd.conStr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cb_MaHD.Text;
                cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = cb_MaSP.Text;
                cmd.ExecuteNonQuery();
                fCTHD_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xoá sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void fCTHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            string ma = cb_MaHD.Text;
            MessageBox.Show($"Thêm thành công hoá đơn có mã {ma}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
