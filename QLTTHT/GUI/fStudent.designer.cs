namespace QLTTHT
{
    partial class fStudent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemHV = new System.Windows.Forms.TextBox();
            this.dgvHocVien = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(39, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 75);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(376, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Học Viên";
            // 
            // btnThemHV
            // 
            this.btnThemHV.Location = new System.Drawing.Point(39, 117);
            this.btnThemHV.Name = "btnThemHV";
            this.btnThemHV.Size = new System.Drawing.Size(148, 34);
            this.btnThemHV.TabIndex = 4;
            this.btnThemHV.Text = "Thêm học viên";
            this.btnThemHV.UseVisualStyleBackColor = true;
            this.btnThemHV.Click += new System.EventHandler(this.btnThemHV_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1064, 117);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 34);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemHV
            // 
            this.txtTimKiemHV.Location = new System.Drawing.Point(802, 117);
            this.txtTimKiemHV.MinimumSize = new System.Drawing.Size(100, 34);
            this.txtTimKiemHV.Name = "txtTimKiemHV";
            this.txtTimKiemHV.Size = new System.Drawing.Size(254, 26);
            this.txtTimKiemHV.TabIndex = 8;
            // 
            // dgvHocVien
            // 
            this.dgvHocVien.AllowUserToAddRows = false;
            this.dgvHocVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVien.Location = new System.Drawing.Point(39, 197);
            this.dgvHocVien.Name = "dgvHocVien";
            this.dgvHocVien.RowHeadersWidth = 62;
            this.dgvHocVien.RowTemplate.Height = 28;
            this.dgvHocVien.Size = new System.Drawing.Size(1118, 478);
            this.dgvHocVien.TabIndex = 9;
            this.dgvHocVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocVien_CellContentClick);
            this.dgvHocVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocVien_CellDoubleClick);
            // 
            // fStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgvHocVien);
            this.Controls.Add(this.txtTimKiemHV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemHV);
            this.Controls.Add(this.panel2);
            this.Name = "fStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fStudent";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemHV;
        private System.Windows.Forms.DataGridView dgvHocVien;
    }
}