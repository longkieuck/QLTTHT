namespace QLTTHT.GUI
{
    partial class fReceiptTuition
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBLTHP = new System.Windows.Forms.DataGridView();
            this.MaBLTHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMaBLTHP = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBLTHP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(90, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thu học phí";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 566);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Học Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số tiền:";
            // 
            // dgvBLTHP
            // 
            this.dgvBLTHP.AllowUserToAddRows = false;
            this.dgvBLTHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBLTHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBLTHP,
            this.NgayThu,
            this.Thang,
            this.HocPhi,
            this.DaThanhToan});
            this.dgvBLTHP.Location = new System.Drawing.Point(484, 82);
            this.dgvBLTHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBLTHP.Name = "dgvBLTHP";
            this.dgvBLTHP.RowHeadersWidth = 62;
            this.dgvBLTHP.Size = new System.Drawing.Size(712, 543);
            this.dgvBLTHP.TabIndex = 6;
            this.dgvBLTHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBLTHP_CellClick);
            // 
            // MaBLTHP
            // 
            this.MaBLTHP.DataPropertyName = "MaBLTHP";
            this.MaBLTHP.HeaderText = "Mã BLTHP";
            this.MaBLTHP.MinimumWidth = 8;
            this.MaBLTHP.Name = "MaBLTHP";
            this.MaBLTHP.Width = 75;
            // 
            // NgayThu
            // 
            this.NgayThu.DataPropertyName = "NgayThu";
            this.NgayThu.HeaderText = "Ngày Thu";
            this.NgayThu.MinimumWidth = 8;
            this.NgayThu.Name = "NgayThu";
            this.NgayThu.Width = 150;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 8;
            this.Thang.Name = "Thang";
            this.Thang.Width = 60;
            // 
            // HocPhi
            // 
            this.HocPhi.DataPropertyName = "HocPhi";
            this.HocPhi.HeaderText = "Tổng học phí";
            this.HocPhi.MinimumWidth = 8;
            this.HocPhi.Name = "HocPhi";
            this.HocPhi.Width = 150;
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.DataPropertyName = "DaThanhToan";
            this.DaThanhToan.HeaderText = "Tình Trạng";
            this.DaThanhToan.MinimumWidth = 8;
            this.DaThanhToan.Name = "DaThanhToan";
            this.DaThanhToan.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tháng:";
            // 
            // lbMaBLTHP
            // 
            this.lbMaBLTHP.AutoSize = true;
            this.lbMaBLTHP.Location = new System.Drawing.Point(207, 134);
            this.lbMaBLTHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaBLTHP.Name = "lbMaBLTHP";
            this.lbMaBLTHP.Size = new System.Drawing.Size(23, 20);
            this.lbMaBLTHP.TabIndex = 9;
            this.lbMaBLTHP.Text = "-1";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(206, 192);
            this.lbten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(78, 29);
            this.lbten.TabIndex = 10;
            this.lbten.Text = "Trống";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(156, 277);
            this.lbSoTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(26, 29);
            this.lbSoTien.TabIndex = 11;
            this.lbSoTien.Text = "0";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(142, 435);
            this.lbThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(26, 29);
            this.lbThang.TabIndex = 12;
            this.lbThang.Text = "0";
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.Location = new System.Drawing.Point(135, 355);
            this.dtpNgayThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(298, 26);
            this.dtpNgayThu.TabIndex = 13;
            // 
            // fReceiptTuition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dtpNgayThu);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbMaBLTHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvBLTHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fReceiptTuition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fReceiptTuition";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBLTHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBLTHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBLTHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMaBLTHP;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
    }
}