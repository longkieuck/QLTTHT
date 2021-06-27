using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTTHT.DAO;
using QLTTHT.DTO;

namespace QLTTHT
{
    public partial class fStudent : Form
    {
        BindingSource HocVienList = new BindingSource();
        public int MaHV = -1;
        public fStudent()
        {
            InitializeComponent();
            LoadFirstTime();
        }

      

       
        private void LoadFirstTime()
        {
            dgvHocVien.DataSource = HocVienList;
            LoadListHocVien();
            EditDataGridView();
         //   BindingDataToFrom();
        }
        private void LoadListHocVien()
        {
            HocVienList.DataSource = HocVienDAO.Instance.GetAll();
        }
        private void EditDataGridView()
        {
            dgvHocVien.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dgvHocVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvHocVien.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvHocVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";        
            dgvHocVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvHocVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvHocVien.Columns["MaMUD"].HeaderText = "Mã Mức Ưu Đãi";
        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            fAddStudent f = new fAddStudent();
            this.Hide();
            f.ShowDialog();
            LoadFirstTime();
            this.Show();
        
         

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = txtTimKiemHV.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            HocVienList.DataSource = HocVienDAO.Instance.Search(str);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadFirstTime();
        }

      

        private void dgvHocVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MaHV = Int32.Parse(dgvHocVien.CurrentRow.Cells["MaHV"].Value.ToString());
            fStudentInfo f = new fStudentInfo(MaHV);
            this.Hide();
            f.ShowDialog();
            LoadFirstTime();
            this.Show();

        }

        private void dgvHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
