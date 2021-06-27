namespace QLTTHT.GUI
{
    partial class fAddClassStudent
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
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.txtGiaoVien = new System.Windows.Forms.TextBox();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(243, 68);
            this.cbbTenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(148, 28);
            this.cbbTenLop.TabIndex = 0;
            this.cbbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbbTenLop_SelectedIndexChanged);
            // 
            // txtGiaoVien
            // 
            this.txtGiaoVien.Location = new System.Drawing.Point(243, 163);
            this.txtGiaoVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaoVien.Name = "txtGiaoVien";
            this.txtGiaoVien.Size = new System.Drawing.Size(148, 26);
            this.txtGiaoVien.TabIndex = 1;
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Location = new System.Drawing.Point(243, 254);
            this.txtMonHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(148, 26);
            this.txtMonHoc.TabIndex = 2;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Location = new System.Drawing.Point(243, 363);
            this.txtHocPhi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(148, 26);
            this.txtHocPhi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mức Học Phí";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(210, 458);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(112, 35);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "thêm";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // fAddClassStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 546);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.txtGiaoVien);
            this.Controls.Add(this.cbbTenLop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAddClassStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddClassStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTenLop;
        private System.Windows.Forms.TextBox txtGiaoVien;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXacNhan;
    }
}