namespace QLTTHT.GUI
{
    partial class fAddClassForTeacher
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
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMucHocPhi = new System.Windows.Forms.ComboBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Lớp";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(158, 79);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(144, 24);
            this.cbMonHoc.TabIndex = 1;
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(158, 31);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(202, 22);
            this.txtTenLop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mức Học Phí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Môn Học";
            // 
            // cbMucHocPhi
            // 
            this.cbMucHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMucHocPhi.FormattingEnabled = true;
            this.cbMucHocPhi.Location = new System.Drawing.Point(158, 136);
            this.cbMucHocPhi.Name = "cbMucHocPhi";
            this.cbMucHocPhi.Size = new System.Drawing.Size(121, 24);
            this.cbMucHocPhi.TabIndex = 5;
            this.cbMucHocPhi.SelectedIndexChanged += new System.EventHandler(this.cbMucHocPhi_SelectedIndexChanged);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLop.Location = new System.Drawing.Point(158, 196);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(121, 23);
            this.btnThemLop.TabIndex = 6;
            this.btnThemLop.Text = "Thêm Lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // fAddClassForTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 241);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.cbMucHocPhi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.label1);
            this.Name = "fAddClassForTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddClassForTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMucHocPhi;
        private System.Windows.Forms.Button btnThemLop;
    }
}