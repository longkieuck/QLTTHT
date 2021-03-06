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
    public partial class fTeacherInfo : Form
    {
        public int magiaovien;
        int mamucthanhtoan;
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

        public void LoadMucTT()
        {
            List<MucThanhToan> listMucThanhToan = MucThanhToanDAO.Instance.GetAll();
            cbMTT.DataSource = listMucThanhToan;
            cbMTT.DisplayMember = "TiLe";
        }

        public void LoadThongTinGV()
        {
            LoadMucTT();
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
        }

        public void LoadDSLop()
        {
            List<LopHoc> listLop = LopHocDAO.Instance.GetLopHocByMaGV(magiaovien);
            cbLopDay.DataSource = listLop;
            cbLopDay.DisplayMember = "TenLH";
        }

        private void cbMTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            MucThanhToan selected = cbMTT.SelectedItem as MucThanhToan;
            mamucthanhtoan = selected.MaMTT;
        }

        private void cbLopDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            LopHoc selected = cbLopDay.SelectedItem as LopHoc;
            lbHocPhiLop.Text = LopHocDAO.Instance.GetHocPhi(selected.MaMHP).HP1Buoi.ToString();
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
            if(rBNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            int mamtt = mamucthanhtoan;
            
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
            } else
            {
                MessageBox.Show("Đã Xảy Ra Lỗi Trong Quá Trình Xóa!");
            }

        }
    }
}
