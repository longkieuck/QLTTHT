using QLTTHT.DAO;
using QLTTHT.DTO;
using QLTTHT.GUI;
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
    public partial class fTeacherInfo : Form
    {
        public int magiaovien;
        public int malophoc;
        public fTeacherInfo()
        {
            InitializeComponent();

        }
        public fTeacherInfo(int magiaovien)
        {
            this.magiaovien = magiaovien;
            InitializeComponent();
            LoadThongTinGV();
        }

        public void LoadTongLuong()
        {
            List<BienLaiTraLuong> list = BienLaiTraLuongDAO.Instance.GetBLTLByMaGV(magiaovien);
            lbTongLuong.Text = list[0].Luong.ToString();
        }

        public void LoadThongTinGV()
        {
            GiaoVien gv = GiaoVienDAO.Instance.GetGiaoVienByMaGV(magiaovien);
            lbID.Text = gv.MaGV.ToString();
            txtHoTen.Text = gv.HoTen;
            txtDiaChi.Text = gv.DiaChi;
            txtSDT.Text = gv.SDT;
            dtpNgaySinh.Text = gv.NgaySinh.ToString();
            if (gv.GioiTinh.CompareTo("Nam") == 0)
            {
                rBNam.Checked = true;
                rBNu.Checked = false;
            }
            else
            {
                rBNu.Checked = true;
                rBNam.Checked = false;
            }
            cbMTT.Text = MucThanhToanDAO.Instance.GetTiLeTT(gv.MaMTT).TiLe.ToString();
            LoadDSLop();
            LoadTongLuong();
        }

        public void LoadDSLop()
        {
            List<LopHoc> listLop = LopHocDAO.Instance.GetLopHocByMaGV(magiaovien);
            cbLopDay.DataSource = listLop;
            cbLopDay.DisplayMember = "TenLH";
        }

        private void cbLopDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            LopHoc selected = cbLopDay.SelectedItem as LopHoc;
            lbHocPhiLop.Text = LopHocDAO.Instance.GetHocPhi(selected.MaLH).HP1Buoi.ToString();
            malophoc = selected.MaLH;
        }

        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            int magv = Int32.Parse(lbID.Text);
            string hoten = txtHoTen.Text;
            DateTime ngaysinh;
            DateTime.TryParse(dtpNgaySinh.Text, out ngaysinh);
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string gioitinh = "";
            if (rBNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            int mamtt = Int32.Parse(cbMTT.Text);

            if (magv == 0 || hoten == "" || sdt == "" || diachi == "" || mamtt == 0 || gioitinh == "" || mamtt == 0)
            {
                MessageBox.Show("Xin Vui Lòng Điền Đầy Đủ Thông Tin");
            }
            else
            {
                if (GiaoVienDAO.Instance.UpdateGiaoVien(magv, hoten, ngaysinh, diachi, gioitinh, sdt, mamtt))
                {
                    MessageBox.Show("Chỉnh Sửa Thông Tin Giáo Viên Thành Công!");
                }
                else
                {
                    MessageBox.Show("Đã Có Lỗi Trong Quá Trình Chỉnh Sửa Thông Tin!");
                }
            }
        }

        private void btnXoaHoSo_Click(object sender, EventArgs e)
        {
            int magv = Int32.Parse(lbID.Text);

            if (GiaoVienDAO.Instance.DeleteGiaoVien(magv))
            {
                MessageBox.Show("Đã Xóa Hồ Sơ Giáo Viên Thành Công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã Xảy Ra Lỗi Trong Quá Trình Xóa!");
            }

        }

        private void btnTraLuong_Click(object sender, EventArgs e)
        {
            fPayrollReceipt f = new fPayrollReceipt(magiaovien);
            f.Show();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            fAddClassForTeacher f = new fAddClassForTeacher(magiaovien);
            this.Hide();
            f.ShowDialog();
            LoadThongTinGV();
            this.Show();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            fUpdateClassForTeacher f = new fUpdateClassForTeacher(malophoc);
            this.Hide();
            f.ShowDialog();
            LoadThongTinGV();
            this.Show();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            fDeleteClassForTeacher f = new fDeleteClassForTeacher(malophoc);
            this.Hide();
            f.ShowDialog();
            LoadThongTinGV();
            this.Show();
        }
    }
}
