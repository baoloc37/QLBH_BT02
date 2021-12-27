
namespace QLBH
{
    partial class fSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TieuchiSP = new System.Windows.Forms.ComboBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_GiaBanSP = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_SuaSP = new System.Windows.Forms.Button();
            this.btn_HuySP = new System.Windows.Forms.Button();
            this.btn_ThemSP = new System.Windows.Forms.Button();
            this.btn_LuuSP = new System.Windows.Forms.Button();
            this.txt_SoLuongSP = new System.Windows.Forms.NumericUpDown();
            this.txt_TimSP = new System.Windows.Forms.TextBox();
            this.btn_TimSP = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgv_SanPham);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 709);
            this.panel1.TabIndex = 0;
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SanPham.ColumnHeadersHeight = 29;
            this.dgv_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_SanPham.Location = new System.Drawing.Point(4, 245);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 24;
            this.dgv_SanPham.Size = new System.Drawing.Size(1203, 461);
            this.dgv_SanPham.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 159;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSanPham";
            this.Column2.HeaderText = "Tên sản phẩm";
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
            this.Column4.DataPropertyName = "GiaBan";
            this.Column4.HeaderText = "Đơn giá bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(497, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 37);
            this.label8.TabIndex = 35;
            this.label8.Text = "Sản phẩm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cb_TieuchiSP);
            this.panel3.Controls.Add(this.txt_TenSP);
            this.panel3.Controls.Add(this.txt_MaSP);
            this.panel3.Controls.Add(this.txt_GiaBanSP);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txt_SoLuongSP);
            this.panel3.Controls.Add(this.txt_TimSP);
            this.panel3.Controls.Add(this.btn_TimSP);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1204, 188);
            this.panel3.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(546, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Tìm theo";
            // 
            // cb_TieuchiSP
            // 
            this.cb_TieuchiSP.BackColor = System.Drawing.Color.White;
            this.cb_TieuchiSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TieuchiSP.FormattingEnabled = true;
            this.cb_TieuchiSP.Items.AddRange(new object[] {
            "Tên sản phẩm",
            "Mã sản phẩm"});
            this.cb_TieuchiSP.Location = new System.Drawing.Point(548, 51);
            this.cb_TieuchiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TieuchiSP.Name = "cb_TieuchiSP";
            this.cb_TieuchiSP.Size = new System.Drawing.Size(171, 28);
            this.cb_TieuchiSP.TabIndex = 92;
            this.cb_TieuchiSP.Text = "Mã sản phẩm";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.BackColor = System.Drawing.Color.White;
            this.txt_TenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_TenSP.Location = new System.Drawing.Point(193, 51);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(275, 27);
            this.txt_TenSP.TabIndex = 86;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.BackColor = System.Drawing.Color.White;
            this.txt_MaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_MaSP.Location = new System.Drawing.Point(26, 51);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(105, 27);
            this.txt_MaSP.TabIndex = 81;
            // 
            // txt_GiaBanSP
            // 
            this.txt_GiaBanSP.BackColor = System.Drawing.Color.White;
            this.txt_GiaBanSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_GiaBanSP.Location = new System.Drawing.Point(193, 123);
            this.txt_GiaBanSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaBanSP.Name = "txt_GiaBanSP";
            this.txt_GiaBanSP.Size = new System.Drawing.Size(160, 27);
            this.txt_GiaBanSP.TabIndex = 80;
            this.txt_GiaBanSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaBanSP_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_SuaSP);
            this.panel4.Controls.Add(this.btn_XoaSP);
            this.panel4.Controls.Add(this.btn_HuySP);
            this.panel4.Controls.Add(this.btn_ThemSP);
            this.panel4.Controls.Add(this.btn_LuuSP);
            this.panel4.Location = new System.Drawing.Point(547, 100);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 59);
            this.panel4.TabIndex = 78;
            // 
            // btn_SuaSP
            // 
            this.btn_SuaSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SuaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SuaSP.FlatAppearance.BorderSize = 0;
            this.btn_SuaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaSP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_SuaSP.ForeColor = System.Drawing.Color.White;
            this.btn_SuaSP.Location = new System.Drawing.Point(260, 6);
            this.btn_SuaSP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaSP.Name = "btn_SuaSP";
            this.btn_SuaSP.Size = new System.Drawing.Size(120, 49);
            this.btn_SuaSP.TabIndex = 59;
            this.btn_SuaSP.Text = "Sửa";
            this.btn_SuaSP.UseVisualStyleBackColor = false;
            this.btn_SuaSP.Click += new System.EventHandler(this.btn_SuaSP_Click);
            // 
            // btn_HuySP
            // 
            this.btn_HuySP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_HuySP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuySP.FlatAppearance.BorderSize = 0;
            this.btn_HuySP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuySP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_HuySP.ForeColor = System.Drawing.Color.White;
            this.btn_HuySP.Location = new System.Drawing.Point(516, 6);
            this.btn_HuySP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HuySP.Name = "btn_HuySP";
            this.btn_HuySP.Size = new System.Drawing.Size(120, 49);
            this.btn_HuySP.TabIndex = 55;
            this.btn_HuySP.Text = "Hủy";
            this.btn_HuySP.UseVisualStyleBackColor = false;
            this.btn_HuySP.Click += new System.EventHandler(this.btn_HuySP_Click);
            // 
            // btn_ThemSP
            // 
            this.btn_ThemSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemSP.FlatAppearance.BorderSize = 0;
            this.btn_ThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemSP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSP.ForeColor = System.Drawing.Color.White;
            this.btn_ThemSP.Location = new System.Drawing.Point(4, 6);
            this.btn_ThemSP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemSP.Name = "btn_ThemSP";
            this.btn_ThemSP.Size = new System.Drawing.Size(120, 49);
            this.btn_ThemSP.TabIndex = 56;
            this.btn_ThemSP.Text = "Thêm";
            this.btn_ThemSP.UseVisualStyleBackColor = false;
            this.btn_ThemSP.Click += new System.EventHandler(this.btn_ThemSP_Click);
            // 
            // btn_LuuSP
            // 
            this.btn_LuuSP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_LuuSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LuuSP.FlatAppearance.BorderSize = 0;
            this.btn_LuuSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LuuSP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_LuuSP.ForeColor = System.Drawing.Color.White;
            this.btn_LuuSP.Location = new System.Drawing.Point(388, 6);
            this.btn_LuuSP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LuuSP.Name = "btn_LuuSP";
            this.btn_LuuSP.Size = new System.Drawing.Size(120, 49);
            this.btn_LuuSP.TabIndex = 57;
            this.btn_LuuSP.Text = "Lưu";
            this.btn_LuuSP.UseVisualStyleBackColor = false;
            this.btn_LuuSP.Click += new System.EventHandler(this.btn_LuuSP_Click);
            // 
            // txt_SoLuongSP
            // 
            this.txt_SoLuongSP.BackColor = System.Drawing.Color.White;
            this.txt_SoLuongSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongSP.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_SoLuongSP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txt_SoLuongSP.Location = new System.Drawing.Point(26, 123);
            this.txt_SoLuongSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuongSP.Name = "txt_SoLuongSP";
            this.txt_SoLuongSP.Size = new System.Drawing.Size(132, 27);
            this.txt_SoLuongSP.TabIndex = 77;
            // 
            // txt_TimSP
            // 
            this.txt_TimSP.BackColor = System.Drawing.Color.White;
            this.txt_TimSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_TimSP.Location = new System.Drawing.Point(728, 51);
            this.txt_TimSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimSP.Name = "txt_TimSP";
            this.txt_TimSP.Size = new System.Drawing.Size(307, 27);
            this.txt_TimSP.TabIndex = 75;
            // 
            // btn_TimSP
            // 
            this.btn_TimSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_TimSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimSP.FlatAppearance.BorderSize = 0;
            this.btn_TimSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimSP.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimSP.ForeColor = System.Drawing.Color.White;
            this.btn_TimSP.Location = new System.Drawing.Point(1044, 42);
            this.btn_TimSP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimSP.Name = "btn_TimSP";
            this.btn_TimSP.Size = new System.Drawing.Size(136, 42);
            this.btn_TimSP.TabIndex = 74;
            this.btn_TimSP.Text = "Tìm kiếm";
            this.btn_TimSP.UseVisualStyleBackColor = false;
            this.btn_TimSP.Click += new System.EventHandler(this.btn_TimSP_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(21, 95);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 25);
            this.label14.TabIndex = 56;
            this.label14.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(21, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 53;
            this.label12.Text = "Mã SP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(187, 95);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 25);
            this.label15.TabIndex = 55;
            this.label15.Text = "Đơn giá bán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(188, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 25);
            this.label13.TabIndex = 49;
            this.label13.Text = "Tên sản phẩm";
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_XoaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaSP.FlatAppearance.BorderSize = 0;
            this.btn_XoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaSP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_XoaSP.ForeColor = System.Drawing.Color.White;
            this.btn_XoaSP.Location = new System.Drawing.Point(132, 6);
            this.btn_XoaSP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(120, 49);
            this.btn_XoaSP.TabIndex = 59;
            this.btn_XoaSP.Text = "Xóa";
            this.btn_XoaSP.UseVisualStyleBackColor = false;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click_1);
            // 
            // fSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 733);
            this.Controls.Add(this.panel1);
            this.Name = "fSanPham";
            this.Text = "fSanPham";
            this.Load += new System.EventHandler(this.fSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TieuchiSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_GiaBanSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_SuaSP;
        private System.Windows.Forms.Button btn_HuySP;
        private System.Windows.Forms.Button btn_ThemSP;
        private System.Windows.Forms.Button btn_LuuSP;
        private System.Windows.Forms.NumericUpDown txt_SoLuongSP;
        private System.Windows.Forms.TextBox txt_TimSP;
        private System.Windows.Forms.Button btn_TimSP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_XoaSP;
    }
}