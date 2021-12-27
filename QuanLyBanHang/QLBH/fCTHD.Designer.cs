
namespace QLBH
{
    partial class fCTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_CTHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.cb_MaHD = new System.Windows.Forms.ComboBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_MaSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_LuuCTHD = new System.Windows.Forms.Button();
            this.btn_XoaCTHD = new System.Windows.Forms.Button();
            this.btn_ThemCTHD = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgv_CTHD);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 609);
            this.panel1.TabIndex = 0;
            // 
            // dgv_CTHD
            // 
            this.dgv_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTHD.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CTHD.ColumnHeadersHeight = 29;
            this.dgv_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgv_CTHD.Location = new System.Drawing.Point(4, 282);
            this.dgv_CTHD.Name = "dgv_CTHD";
            this.dgv_CTHD.RowHeadersWidth = 51;
            this.dgv_CTHD.RowTemplate.Height = 24;
            this.dgv_CTHD.Size = new System.Drawing.Size(662, 324);
            this.dgv_CTHD.TabIndex = 94;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hoá đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaSP";
            this.Column5.HeaderText = "Mã sản phẩm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSanPham";
            this.Column2.HeaderText = "Sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThanhTien";
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaBan";
            this.Column6.HeaderText = "Giá bán";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.lbl_ThanhTien);
            this.panel2.Controls.Add(this.cb_MaHD);
            this.panel2.Controls.Add(this.txt_GiaBan);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cb_MaSP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_SoLuong);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_TenSP);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 271);
            this.panel2.TabIndex = 38;
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.ForeColor = System.Drawing.Color.Red;
            this.lbl_ThanhTien.Location = new System.Drawing.Point(430, 142);
            this.lbl_ThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(23, 25);
            this.lbl_ThanhTien.TabIndex = 96;
            this.lbl_ThanhTien.Text = "0";
            // 
            // cb_MaHD
            // 
            this.cb_MaHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaHD.FormattingEnabled = true;
            this.cb_MaHD.Location = new System.Drawing.Point(28, 46);
            this.cb_MaHD.Name = "cb_MaHD";
            this.cb_MaHD.Size = new System.Drawing.Size(121, 28);
            this.cb_MaHD.TabIndex = 95;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.BackColor = System.Drawing.Color.White;
            this.txt_GiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_GiaBan.Location = new System.Drawing.Point(225, 140);
            this.txt_GiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(147, 27);
            this.txt_GiaBan.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(220, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 93;
            this.label6.Text = "Giá bán";
            // 
            // cb_MaSP
            // 
            this.cb_MaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaSP.FormattingEnabled = true;
            this.cb_MaSP.Location = new System.Drawing.Point(225, 46);
            this.cb_MaSP.Name = "cb_MaSP";
            this.cb_MaSP.Size = new System.Drawing.Size(121, 28);
            this.cb_MaSP.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(430, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 89;
            this.label4.Text = "Thành tiền";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BackColor = System.Drawing.Color.White;
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_SoLuong.Location = new System.Drawing.Point(28, 139);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(147, 27);
            this.txt_SoLuong.TabIndex = 88;
            this.txt_SoLuong.Text = "0";
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 87;
            this.label3.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(220, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Mã HD";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.BackColor = System.Drawing.Color.White;
            this.txt_TenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_TenSP.Location = new System.Drawing.Point(425, 43);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(147, 27);
            this.txt_TenSP.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(775, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_LuuCTHD);
            this.panel3.Controls.Add(this.btn_XoaCTHD);
            this.panel3.Controls.Add(this.btn_ThemCTHD);
            this.panel3.Location = new System.Drawing.Point(87, 196);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 57);
            this.panel3.TabIndex = 78;
            // 
            // btn_LuuCTHD
            // 
            this.btn_LuuCTHD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_LuuCTHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LuuCTHD.FlatAppearance.BorderSize = 0;
            this.btn_LuuCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LuuCTHD.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_LuuCTHD.ForeColor = System.Drawing.Color.White;
            this.btn_LuuCTHD.Location = new System.Drawing.Point(273, 4);
            this.btn_LuuCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LuuCTHD.Name = "btn_LuuCTHD";
            this.btn_LuuCTHD.Size = new System.Drawing.Size(120, 49);
            this.btn_LuuCTHD.TabIndex = 97;
            this.btn_LuuCTHD.Text = "Lưu";
            this.btn_LuuCTHD.UseVisualStyleBackColor = false;
            this.btn_LuuCTHD.Click += new System.EventHandler(this.btn_LuuCTHD_Click);
            // 
            // btn_XoaCTHD
            // 
            this.btn_XoaCTHD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_XoaCTHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaCTHD.FlatAppearance.BorderSize = 0;
            this.btn_XoaCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaCTHD.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_XoaCTHD.ForeColor = System.Drawing.Color.White;
            this.btn_XoaCTHD.Location = new System.Drawing.Point(136, 4);
            this.btn_XoaCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaCTHD.Name = "btn_XoaCTHD";
            this.btn_XoaCTHD.Size = new System.Drawing.Size(120, 49);
            this.btn_XoaCTHD.TabIndex = 58;
            this.btn_XoaCTHD.Text = "Xóa";
            this.btn_XoaCTHD.UseVisualStyleBackColor = false;
            this.btn_XoaCTHD.Click += new System.EventHandler(this.btn_XoaCTHD_Click);
            // 
            // btn_ThemCTHD
            // 
            this.btn_ThemCTHD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ThemCTHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemCTHD.FlatAppearance.BorderSize = 0;
            this.btn_ThemCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemCTHD.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemCTHD.ForeColor = System.Drawing.Color.White;
            this.btn_ThemCTHD.Location = new System.Drawing.Point(4, 4);
            this.btn_ThemCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemCTHD.Name = "btn_ThemCTHD";
            this.btn_ThemCTHD.Size = new System.Drawing.Size(120, 49);
            this.btn_ThemCTHD.TabIndex = 56;
            this.btn_ThemCTHD.Text = "Thêm";
            this.btn_ThemCTHD.UseVisualStyleBackColor = false;
            this.btn_ThemCTHD.Click += new System.EventHandler(this.btn_ThemCTHD_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(420, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 25);
            this.label16.TabIndex = 55;
            this.label16.Text = "Tên sản phẩm";
            // 
            // fCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 633);
            this.Controls.Add(this.panel1);
            this.Name = "fCTHD";
            this.Text = "fCTHD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fCTHD_FormClosed);
            this.Load += new System.EventHandler(this.fCTHD_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_XoaCTHD;
        private System.Windows.Forms.Button btn_ThemCTHD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_MaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_CTHD;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_MaHD;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_LuuCTHD;
    }
}