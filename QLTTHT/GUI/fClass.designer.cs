namespace QLTTHT
{
    partial class fClass
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.dgvHocVien = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIdLopHoc = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(68, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 49);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(255, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Lớp Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(534, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGhiNhan);
            this.panel1.Controls.Add(this.dgvHocVien);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(27, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 390);
            this.panel1.TabIndex = 4;
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(84, 353);
            this.btnGhiNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(61, 23);
            this.btnGhiNhan.TabIndex = 9;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // dgvHocVien
            // 
            this.dgvHocVien.AllowUserToAddRows = false;
            this.dgvHocVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVien.Location = new System.Drawing.Point(261, 2);
            this.dgvHocVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHocVien.Name = "dgvHocVien";
            this.dgvHocVien.RowHeadersWidth = 62;
            this.dgvHocVien.RowTemplate.Height = 28;
            this.dgvHocVien.Size = new System.Drawing.Size(564, 335);
            this.dgvHocVien.TabIndex = 2;
            this.dgvHocVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocVien_CellContentClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(2, 2);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(255, 334);
            this.checkedListBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 105);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(107, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Điểm danh";
            // 
            // cbIdLopHoc
            // 
            this.cbIdLopHoc.FormattingEnabled = true;
            this.cbIdLopHoc.Location = new System.Drawing.Point(27, 104);
            this.cbIdLopHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbIdLopHoc.Name = "cbIdLopHoc";
            this.cbIdLopHoc.Size = new System.Drawing.Size(105, 21);
            this.cbIdLopHoc.TabIndex = 10;
            this.cbIdLopHoc.SelectedIndexChanged += new System.EventHandler(this.cbIdLopHoc_SelectedIndexChanged);
            // 
            // fClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 516);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIdLopHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fClass";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fClass";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIdLopHoc;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.DataGridView dgvHocVien;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}