
namespace QLBH
{
    partial class fBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rpv_BaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.cb_MaSP = new System.Windows.Forms.ComboBox();
            this.btn_BaoCao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_BaoCao);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_TenSP);
            this.panel1.Controls.Add(this.cb_MaSP);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 608);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rpv_BaoCao);
            this.groupBox1.Location = new System.Drawing.Point(4, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 481);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị báo cáo";
            // 
            // rpv_BaoCao
            // 
            this.rpv_BaoCao.Location = new System.Drawing.Point(7, 32);
            this.rpv_BaoCao.Name = "rpv_BaoCao";
            this.rpv_BaoCao.ServerReport.BearerToken = null;
            this.rpv_BaoCao.Size = new System.Drawing.Size(1000, 443);
            this.rpv_BaoCao.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(195, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 55;
            this.label12.Text = "Mã SP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(362, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 25);
            this.label13.TabIndex = 54;
            this.label13.Text = "Tên sản phẩm";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Enabled = false;
            this.txt_TenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSP.Location = new System.Drawing.Point(367, 67);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(233, 27);
            this.txt_TenSP.TabIndex = 2;
            // 
            // cb_MaSP
            // 
            this.cb_MaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaSP.FormattingEnabled = true;
            this.cb_MaSP.Location = new System.Drawing.Point(186, 67);
            this.cb_MaSP.Name = "cb_MaSP";
            this.cb_MaSP.Size = new System.Drawing.Size(131, 28);
            this.cb_MaSP.TabIndex = 1;
            // 
            // btn_BaoCao
            // 
            this.btn_BaoCao.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_BaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BaoCao.FlatAppearance.BorderSize = 0;
            this.btn_BaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BaoCao.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaoCao.ForeColor = System.Drawing.Color.White;
            this.btn_BaoCao.Location = new System.Drawing.Point(654, 45);
            this.btn_BaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(142, 68);
            this.btn_BaoCao.TabIndex = 57;
            this.btn_BaoCao.Text = "Tạo Báo Cáo";
            this.btn_BaoCao.UseVisualStyleBackColor = false;
            this.btn_BaoCao.Click += new System.EventHandler(this.btn_BaoCao_Click_1);
            // 
            // fBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 633);
            this.Controls.Add(this.panel1);
            this.Name = "fBaoCao";
            this.Text = "fBaoCao";
            this.Load += new System.EventHandler(this.fBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.ComboBox cb_MaSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_BaoCao;
        private System.Windows.Forms.Button btn_BaoCao;
    }
}