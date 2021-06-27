namespace QLTTHT
{
    partial class fTeacher
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
            this.dtgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnThemGiaoVien = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaoVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvGiaoVien
            // 
            this.dtgvGiaoVien.AllowUserToAddRows = false;
            this.dtgvGiaoVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTen,
            this.NgaySinh,
            this.GT,
            this.DiaChi,
            this.SDT,
            this.MTT});
            this.dtgvGiaoVien.Location = new System.Drawing.Point(27, 125);
            this.dtgvGiaoVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvGiaoVien.Name = "dtgvGiaoVien";
            this.dtgvGiaoVien.RowHeadersWidth = 62;
            this.dtgvGiaoVien.RowTemplate.Height = 28;
            this.dtgvGiaoVien.Size = new System.Drawing.Size(823, 392);
            this.dtgvGiaoVien.TabIndex = 14;
            this.dtgvGiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGiaoVien_CellDoubleClick);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.MinimumWidth = 8;
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 80;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 120;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 120;
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GioiTinh";
            this.GT.HeaderText = "Giới Tính";
            this.GT.MinimumWidth = 8;
            this.GT.Name = "GT";
            this.GT.Width = 80;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 120;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 120;
            // 
            // MTT
            // 
            this.MTT.DataPropertyName = "TiLe";
            this.MTT.HeaderText = "Mức Thanh Toán";
            this.MTT.MinimumWidth = 8;
            this.MTT.Name = "MTT";
            this.MTT.Width = 120;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(27, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 49);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(290, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Giáo Viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(592, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(167, 20);
            this.txtHoTen.TabIndex = 15;
            // 
            // btnThemGiaoVien
            // 
            this.btnThemGiaoVien.Location = new System.Drawing.Point(27, 80);
            this.btnThemGiaoVien.Name = "btnThemGiaoVien";
            this.btnThemGiaoVien.Size = new System.Drawing.Size(106, 23);
            this.btnThemGiaoVien.TabIndex = 16;
            this.btnThemGiaoVien.Text = "Thêm Giáo Viên";
            this.btnThemGiaoVien.UseVisualStyleBackColor = true;
            this.btnThemGiaoVien.Click += new System.EventHandler(this.btnThemGiaoVien_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(775, 82);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // fTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 487);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemGiaoVien);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.dtgvGiaoVien);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaoVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGiaoVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThemGiaoVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTT;
    }
}