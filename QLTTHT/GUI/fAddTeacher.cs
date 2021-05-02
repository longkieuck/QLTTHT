using QLTTHT.DAO;
using QLTTHT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTHT
{
    public partial class fAddTeacher : Form
    {
        public fAddTeacher()
        {
            InitializeComponent();
            LoadAddTeacher();
        }

        public void LoadAddTeacher()
        {
            LoadMucTT();
            LamTrong();
        }

        public void LoadMucTT()
        {
            List<MucThanhToan> listMucThanhToan = MucThanhToanDAO.Instance.GetAll();
            cbMucTT.DataSource = listMucThanhToan;
            cbMucTT.DisplayMember = "MaMTT";
        }

        public void LamTrong()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMK.Text = "";
            txtMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMK.UseSystemPasswordChar = true;
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            cbMucTT.Text = "";

        }

        private void btnXNThemGV_Click(object sender, EventArgs e)
        {
            string tk = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;
            string xnmk = txtXacNhanMK.Text;
            string hoten = txtHoTen.Text;
            DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string gioitinh = "";
            if (rbtnNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else if (rbtnNu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            int mamtt = Int32.Parse(cbMucTT.Text);
            if (tk == "" || mk == "" || xnmk == "" || hoten == "" || sdt == "" || diachi == "" || (rbtnNam.Checked == false && rbtnNu.Checked == false) || mamtt == 0)
            {
                MessageBox.Show("Xin Vui Lòng Điền Đầy Đủ Thông Tin");
            }
            else if (mk.CompareTo(xnmk) != 0)
            {
                MessageBox.Show("Xác Nhận Mật Khẩu Không Khớp! Vui Lòng Kiểm Tra Lại");
            }
            else
            {
                if (GiaoVienDAO.Instance.InsertGiaoVien(hoten, ngaysinh, diachi, gioitinh, sdt, mamtt, tk, mk))
                {
                    MessageBox.Show("Thêm Mới Giáo Viên Thành Công!");
                }
                else
                {
                    MessageBox.Show("Đã Xảy Ra Lỗi Trong Quá Trình Thêm Mới Giáo Viên!");
                }
            }

        }

        private void cBMk_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMk.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void cBXmmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cBXmmk.Checked)
            {
                txtXacNhanMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtXacNhanMK.UseSystemPasswordChar = true;
            }
        }
    }
}
