namespace QLTTHT.GUI
{
    partial class fDeleteClassForTeacher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.lbMucHocPhi = new System.Windows.Forms.Label();
            this.btnXacNhanXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMucHocPhi);
            this.groupBox1.Controls.Add(this.lbMonHoc);
            this.groupBox1.Controls.Add(this.lbTenLop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lớp Học Xóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mức Học Phí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Lớp";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Location = new System.Drawing.Point(174, 46);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(35, 13);
            this.lbTenLop.TabIndex = 15;
            this.lbTenLop.Text = "Trống";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Location = new System.Drawing.Point(174, 100);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(35, 13);
            this.lbMonHoc.TabIndex = 16;
            this.lbMonHoc.Text = "Trống";
            // 
            // lbMucHocPhi
            // 
            this.lbMucHocPhi.AutoSize = true;
            this.lbMucHocPhi.Location = new System.Drawing.Point(174, 157);
            this.lbMucHocPhi.Name = "lbMucHocPhi";
            this.lbMucHocPhi.Size = new System.Drawing.Size(35, 13);
            this.lbMucHocPhi.TabIndex = 17;
            this.lbMucHocPhi.Text = "Trống";
            // 
            // btnXacNhanXoa
            // 
            this.btnXacNhanXoa.Location = new System.Drawing.Point(161, 255);
            this.btnXacNhanXoa.Name = "btnXacNhanXoa";
            this.btnXacNhanXoa.Size = new System.Drawing.Size(110, 34);
            this.btnXacNhanXoa.TabIndex = 1;
            this.btnXacNhanXoa.Text = "Xác Nhận Xóa";
            this.btnXacNhanXoa.UseVisualStyleBackColor = true;
            this.btnXacNhanXoa.Click += new System.EventHandler(this.btnXacNhanXoa_Click);
            // 
            // fDeleteClassForTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 315);
            this.Controls.Add(this.btnXacNhanXoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "fDeleteClassForTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDeleteClassForTeacher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMucHocPhi;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhanXoa;
    }
}