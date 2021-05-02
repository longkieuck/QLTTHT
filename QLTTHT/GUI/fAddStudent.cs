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
    public partial class fAddStudent : Form
    {
        

       
        public fAddStudent()
        {
            InitializeComponent();
            LoadAddStudent();
        }

        public void LoadAddStudent()
        {
           
            LamTrong();
        }

        

        public void LamTrong()
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
            dtpNgaySinh.Text = "";
 
            txtDiaChi.Text = "";
            
           
            rdbNam.Checked = false;
            rdbNu.Checked = false;
           

        }
        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
           
            string hoten = txtHoTen.Text;
            DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string gioitinh = "";
            if (rdbNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else if (rdbNu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            
            if (hoten == "" || sdt == "" || diachi == "" || (rdbNam.Checked == false && rdbNu.Checked == false))
            {
                MessageBox.Show("Xin Vui Lòng Điền Đầy Đủ Thông Tin");
            }
            else
            {
                if (HocVienDAO.Instance.InsertHocVien(hoten,sdt,ngaysinh,diachi,gioitinh,1))
                {
                    MessageBox.Show("Thêm Mới Học Viên Thành Công!");
                }
                else
                {
                    MessageBox.Show("Đã Xảy Ra Lỗi Trong Quá Trình Thêm Mới Học Viên!");
                }
            }

        }
    }
}

