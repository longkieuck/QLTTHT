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
            this.label1.Location = new System.Drawing.Point(60, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thu học phí";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(99, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Học Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số tiền:";
            // 
            // dgvBLTHP
            // 
            this.dgvBLTHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBLTHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBLTHP,
            this.NgayThu,
            this.Thang,
            this.HocPhi,
            this.DaThanhToan});
            this.dgvBLTHP.Location = new System.Drawing.Point(323, 53);
            this.dgvBLTHP.Name = "dgvBLTHP";
            this.dgvBLTHP.Size = new System.Drawing.Size(475, 353);
            this.dgvBLTHP.TabIndex = 6;
            // 
            // MaBLTHP
            // 
            this.MaBLTHP.DataPropertyName = "MaBLTHP";
            this.MaBLTHP.HeaderText = "Mã BLTHP";
            this.MaBLTHP.Name = "MaBLTHP";
            this.MaBLTHP.Width = 75;
            // 
            // NgayThu
            // 
            this.NgayThu.DataPropertyName = "NgayThu";
            this.NgayThu.HeaderText = "Ngày Thu";
            this.NgayThu.Name = "NgayThu";
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.Width = 60;
            // 
            // HocPhi
            // 
            this.HocPhi.DataPropertyName = "HocPhi";
            this.HocPhi.HeaderText = "Tổng học phí";
            this.HocPhi.Name = "HocPhi";
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.DataPropertyName = "DaThanhToan";
            this.DaThanhToan.HeaderText = "Tình Trạng";
            this.DaThanhToan.Name = "DaThanhToan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tháng:";
            // 
            // lbMaBLTHP
            // 
            this.lbMaBLTHP.AutoSize = true;
            this.lbMaBLTHP.Location = new System.Drawing.Point(138, 87);
            this.lbMaBLTHP.Name = "lbMaBLTHP";
            this.lbMaBLTHP.Size = new System.Drawing.Size(16, 13);
            this.lbMaBLTHP.TabIndex = 9;
            this.lbMaBLTHP.Text = "-1";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(137, 125);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(50, 20);
            this.lbten.TabIndex = 10;
            this.lbten.Text = "Trống";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(104, 180);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(18, 20);
            this.lbSoTien.TabIndex = 11;
            this.lbSoTien.Text = "0";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(95, 283);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(18, 20);
            this.lbThang.TabIndex = 12;
            this.lbThang.Text = "0";
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.Location = new System.Drawing.Point(90, 231);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayThu.TabIndex = 13;
            // 
            // fReceiptTuition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "fReceiptTuition";
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