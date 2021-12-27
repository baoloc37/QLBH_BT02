
namespace QLBH
{
    partial class fKhachHang
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
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TieuchiKH = new System.Windows.Forms.ComboBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_SuaKH = new System.Windows.Forms.Button();
            this.btn_HuyKH = new System.Windows.Forms.Button();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.btn_LuuKH = new System.Windows.Forms.Button();
            this.txt_TimKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TimKH = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgv_KhachHang);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 688);
            this.panel1.TabIndex = 0;
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhachHang.ColumnHeadersHeight = 29;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_KhachHang.Location = new System.Drawing.Point(4, 232);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1298, 453);
            this.dgv_KhachHang.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_TieuchiKH);
            this.panel2.Controls.Add(this.txt_TenKH);
            this.panel2.Controls.Add(this.txt_MaKH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_SDT);
            this.panel2.Controls.Add(this.txt_DiaChi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txt_TimKH);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_TimKH);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 170);
            this.panel2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(625, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Tìm theo";
            // 
            // cb_TieuchiKH
            // 
            this.cb_TieuchiKH.BackColor = System.Drawing.Color.White;
            this.cb_TieuchiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TieuchiKH.FormattingEnabled = true;
            this.cb_TieuchiKH.Items.AddRange(new object[] {
            "Số điện thoại",
            "Tên khách hàng"});
            this.cb_TieuchiKH.Location = new System.Drawing.Point(631, 41);
            this.cb_TieuchiKH.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TieuchiKH.Name = "cb_TieuchiKH";
            this.cb_TieuchiKH.Size = new System.Drawing.Size(164, 28);
            this.cb_TieuchiKH.TabIndex = 86;
            this.cb_TieuchiKH.Text = "Tên khách hàng";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.BackColor = System.Drawing.Color.White;
            this.txt_TenKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_TenKH.Location = new System.Drawing.Point(116, 43);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(257, 27);
            this.txt_TenKH.TabIndex = 85;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.Color.White;
            this.txt_MaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_MaKH.Location = new System.Drawing.Point(24, 43);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(69, 27);
            this.txt_MaKH.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(111, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Tên khách hàng";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.Color.White;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_SDT.Location = new System.Drawing.Point(384, 43);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(147, 27);
            this.txt_SDT.TabIndex = 80;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.Color.White;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_DiaChi.Location = new System.Drawing.Point(25, 103);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(505, 27);
            this.txt_DiaChi.TabIndex = 79;
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
            this.panel3.Controls.Add(this.btn_SuaKH);
            this.panel3.Controls.Add(this.btn_HuyKH);
            this.panel3.Controls.Add(this.btn_XoaKH);
            this.panel3.Controls.Add(this.btn_ThemKH);
            this.panel3.Controls.Add(this.btn_LuuKH);
            this.panel3.Location = new System.Drawing.Point(631, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 57);
            this.panel3.TabIndex = 78;
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SuaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SuaKH.FlatAppearance.BorderSize = 0;
            this.btn_SuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_SuaKH.ForeColor = System.Drawing.Color.White;
            this.btn_SuaKH.Location = new System.Drawing.Point(260, 4);
            this.btn_SuaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(120, 49);
            this.btn_SuaKH.TabIndex = 59;
            this.btn_SuaKH.Text = "Sửa";
            this.btn_SuaKH.UseVisualStyleBackColor = false;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_HuyKH
            // 
            this.btn_HuyKH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_HuyKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyKH.FlatAppearance.BorderSize = 0;
            this.btn_HuyKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_HuyKH.ForeColor = System.Drawing.Color.White;
            this.btn_HuyKH.Location = new System.Drawing.Point(516, 4);
            this.btn_HuyKH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HuyKH.Name = "btn_HuyKH";
            this.btn_HuyKH.Size = new System.Drawing.Size(120, 49);
            this.btn_HuyKH.TabIndex = 55;
            this.btn_HuyKH.Text = "Hủy";
            this.btn_HuyKH.UseVisualStyleBackColor = false;
            this.btn_HuyKH.Click += new System.EventHandler(this.btn_HuyKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_XoaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaKH.FlatAppearance.BorderSize = 0;
            this.btn_XoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_XoaKH.ForeColor = System.Drawing.Color.White;
            this.btn_XoaKH.Location = new System.Drawing.Point(132, 4);
            this.btn_XoaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(120, 49);
            this.btn_XoaKH.TabIndex = 58;
            this.btn_XoaKH.Text = "Xóa";
            this.btn_XoaKH.UseVisualStyleBackColor = false;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemKH.FlatAppearance.BorderSize = 0;
            this.btn_ThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemKH.ForeColor = System.Drawing.Color.White;
            this.btn_ThemKH.Location = new System.Drawing.Point(4, 4);
            this.btn_ThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(120, 49);
            this.btn_ThemKH.TabIndex = 56;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.UseVisualStyleBackColor = false;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // btn_LuuKH
            // 
            this.btn_LuuKH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_LuuKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LuuKH.FlatAppearance.BorderSize = 0;
            this.btn_LuuKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LuuKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_LuuKH.ForeColor = System.Drawing.Color.White;
            this.btn_LuuKH.Location = new System.Drawing.Point(388, 4);
            this.btn_LuuKH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LuuKH.Name = "btn_LuuKH";
            this.btn_LuuKH.Size = new System.Drawing.Size(120, 49);
            this.btn_LuuKH.TabIndex = 57;
            this.btn_LuuKH.Text = "Lưu";
            this.btn_LuuKH.UseVisualStyleBackColor = false;
            this.btn_LuuKH.Click += new System.EventHandler(this.btn_LuuKH_Click);
            // 
            // txt_TimKH
            // 
            this.txt_TimKH.BackColor = System.Drawing.Color.White;
            this.txt_TimKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_TimKH.Location = new System.Drawing.Point(816, 41);
            this.txt_TimKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKH.Name = "txt_TimKH";
            this.txt_TimKH.Size = new System.Drawing.Size(321, 27);
            this.txt_TimKH.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(20, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Địa chỉ";
            // 
            // btn_TimKH
            // 
            this.btn_TimKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_TimKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKH.FlatAppearance.BorderSize = 0;
            this.btn_TimKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKH.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKH.ForeColor = System.Drawing.Color.White;
            this.btn_TimKH.Location = new System.Drawing.Point(1147, 36);
            this.btn_TimKH.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKH.Name = "btn_TimKH";
            this.btn_TimKH.Size = new System.Drawing.Size(121, 39);
            this.btn_TimKH.TabIndex = 74;
            this.btn_TimKH.Text = "Tìm kiếm";
            this.btn_TimKH.UseVisualStyleBackColor = false;
            this.btn_TimKH.Click += new System.EventHandler(this.btn_TimKH_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(379, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 25);
            this.label16.TabIndex = 55;
            this.label16.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(505, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 37);
            this.label8.TabIndex = 36;
            this.label8.Text = "Thông tin khách hàng";
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 712);
            this.Controls.Add(this.panel1);
            this.Name = "fKhachHang";
            this.Text = "fKhachHang";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TieuchiKH;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_SuaKH;
        private System.Windows.Forms.Button btn_HuyKH;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.Button btn_LuuKH;
        private System.Windows.Forms.TextBox txt_TimKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_TimKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}