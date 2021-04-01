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

namespace QLTTHT
{
    public partial class fStudent : Form
    {
        BindingSource HocVienList = new BindingSource();
        public fStudent()
        {
            InitializeComponent();
            LoadFirstTime();
        }

      

       
        private void LoadFirstTime()
        {
            dgvHocVien.DataSource = HocVienList;
            LoadListGiaoVien();
            EditDataGridView();
         //   BindingDataToFrom();
        }
        private void LoadListGiaoVien()
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

        }

        private void fStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
