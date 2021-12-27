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
    public partial class fLogin : Form
    {
        ConnectionDB cd = new ConnectionDB();
        Encrypt E = new Encrypt();
        string loaiTK = "Vô hiệu hoá";
        public fLogin()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_User.Text != "" && txt_Pass.Text != "")
            {
                cd.DataConnection();
                var cmd = new SqlCommand("USP_Login", cd.conStr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txt_User.Text;
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = E.HashCode(txt_Pass.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);

                if (table.Rows.Count == 1)
                {
                    if (table.Rows[0][3].ToString() == loaiTK)
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị vô hiệu hoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Focus();
                    }    
                    else
                    {
                        fQuanLy fm = new fQuanLy(table.Rows[0][3].ToString()); ;
                        fm.Show();
                        this.Hide();
                    }    
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = true;
            }
        }
    }
}

