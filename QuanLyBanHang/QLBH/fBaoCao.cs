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
using Microsoft.Reporting.WinForms;

namespace QLBH
{
    public partial class fBaoCao : Form
    {
        ConnectionDB cd = new ConnectionDB();
        public fBaoCao()
        {
            InitializeComponent();
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {

            this.rpv_BaoCao.RefreshReport();

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

        }

        private void btn_BaoCao_Click_1(object sender, EventArgs e)
        {
            cd.DataConnection();
            SqlCommand cmd = new SqlCommand("USP_BaoCao", cd.conStr);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = cb_MaSP.Text;

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);

            rpv_BaoCao.ProcessingMode = ProcessingMode.Local;
            rpv_BaoCao.LocalReport.ReportPath = "ReportSP.rdlc";
            if(ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "BaoCaoSP";
                rds.Value = ds.Tables[0];
                rpv_BaoCao.LocalReport.DataSources.Clear();
                rpv_BaoCao.LocalReport.DataSources.Add(rds);
                rpv_BaoCao.RefreshReport();
            }    
        }
    }
}
