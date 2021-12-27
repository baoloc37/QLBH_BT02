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
    public partial class fTaiKhoan : Form
    {
        ConnectionDB cd = new ConnectionDB();
        Encrypt E = new Encrypt();
        int flag;
        public fTaiKhoan()
        {
            InitializeComponent();
        }
        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            cd.DataConnection();
            var cmd = new SqlCommand("Select * from TaiKhoan", cd.conStr);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);

            dgv_TaiKhoan.DataSource = table;
            dgv_TaiKhoan.AllowUserToAddRows = false;
            dgv_TaiKhoan.EditMode = DataGridViewEditMode.EditProgrammatically;
            txt_ID.DataBindings.Clear();
            txt_ID.DataBindings.Add("Text", dgv_TaiKhoan.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txt_User.DataBindings.Clear();
            txt_User.DataBindings.Add("Text", dgv_TaiKhoan.DataSource, "Username", true, DataSourceUpdateMode.Never);
            txt_Pass.DataBindings.Clear();
            txt_Pass.DataBindings.Add("Text", dgv_TaiKhoan.DataSource, "Pass", true, DataSourceUpdateMode.Never);
            cb_Loai.DataBindings.Clear();
            cb_Loai.DataBindings.Add("Text", dgv_TaiKhoan.DataSource, "Loai", true, DataSourceUpdateMode.Never);
        }
        void dis_enb(bool e)
        {
            btn_HuyTK.Enabled = e;
            btn_LuuTK.Enabled = e;

            btn_ThemTK.Enabled = !e;
            btn_XoaTK.Enabled = !e;
            btn_SuaTK.Enabled = !e;
        }
        private void btn_LuuTK_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cd.DataConnection();
                var cmd = new SqlCommand("USP_ThemTK", cd.conStr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txt_User.Text;
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = E.HashCode(txt_Pass.Text);
                cmd.Parameters.Add("@Loai", SqlDbType.NVarChar).Value = cb_Loai.Text;
                cmd.ExecuteNonQuery();
            }    
            else
            {
                cd.DataConnection();
                var cmd = new SqlCommand("USP_SuaTK", cd.conStr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = txt_ID.Text;
                cmd.Parameters.Add("@Loai", SqlDbType.NVarChar).Value = cb_Loai.Text;
                cmd.ExecuteNonQuery();
            }    
            fTaiKhoan_Load(sender, e);
        }
        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            flag = 1;
            txt_ID.Text = "";
            txt_Pass.Text = "";
            txt_User.Text = "";

            txt_Pass.Enabled = true;
            txt_User.Enabled = true;
            cb_Loai.Enabled = true;
            dis_enb(true);
        }

        private void btn_HuyTK_Click(object sender, EventArgs e)
        {
            dis_enb(false);
        }

        private void btn_SuaTK_Click(object sender, EventArgs e)
        {
            flag = 0;

            cb_Loai.Enabled = true;
            dis_enb(true);
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            try
            {
                cd.DataConnection();
                var cmd = new SqlCommand("USP_XoaTK", cd.conStr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = txt_ID.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fTaiKhoan_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xoá thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
