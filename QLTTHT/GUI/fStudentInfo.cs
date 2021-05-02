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
using QLTTHT.GUI;

namespace QLTTHT
{
    public partial class fStudentInfo : Form
    {
        public int mahocvien;
        public int mamud;
        public int malh;
        
        public fStudentInfo(int mahocvien)
        {
            this.mahocvien = mahocvien;
            InitializeComponent();
            LoadTTHocVien();
        }
        //public void LoadMucUD()
        //{
        //    List<MucUuDai> listMucUuDai = MucUuDaiDAO.Instance.GetAll();
        //    cbbMucUuDai.DataSource = listMucUuDai;
        //    cbbMucUuDai.DisplayMember = "MUD";
        //}

        public void LoadTTHocVien()
        {
           // LoadMucUD();
            HocVien hv = HocVienDAO.Instance.GetHocVienByMaHV(mahocvien);
            lbID.Text = hv.MaHV.ToString();
            txtHoTen.Text = hv.HoTen;
            txtDiaChi.Text = hv.DiaChi;
            txtSDT.Text = hv.SDT;
            dtpNgaySinh.Text = hv.NgaySinh.ToString();
            if (hv.GioiTinh.CompareTo("Nam") == 0)
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
            }
            else
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
            }
            txtMucUuDai.Text = MucUuDaiDAO.Instance.GetUD(hv.MaMUD).MUD.ToString();
            LoadDSLop();
            loadTongHocPhi();
        }

        public void LoadDSLop()
        {
            List<LopHoc> listLop = LopHocDAO.Instance.GetLopHocByMaHV(mahocvien);
            cbbLopHoc.DataSource = listLop;
            cbbLopHoc.DisplayMember = "TenLH";
        }
        public void loadTongHocPhi()
        {
            List<BienLaiThuHocPhi> list = BienLaiThuHocPhiDAO.Instance.GetBLTHPByMaHV(mahocvien);
            lbhocphi.Text = list[0].HocPhi.ToString();
        }

       

        //private void cbbMucUuDai_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox cb = sender as ComboBox;
        //    if (cb.SelectedItem == null)
        //        return;

        //    MucUuDai selected = cbbMucUuDai.SelectedItem as MucUuDai;
        //    mamud = selected.MaMUD;
            
        //}

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)               
                return;

            LopHoc selected = cbbLopHoc.SelectedItem as LopHoc;

            lbmhp.Text = LopHocDAO.Instance.GetHocPhi(selected.MaLH).HP1Buoi.ToString();
            malh = selected.MaLH;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            int mahv = Int32.Parse(lbID.Text);
            string hoten = txtHoTen.Text;
            DateTime ngaysinh;
            DateTime.TryParse(dtpNgaySinh.Text, out ngaysinh);
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string gioitinh = "";
            if (rdbNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            int mamud = this.mamud;

            if ( mahv== 0 || hoten == "" || sdt == "" || diachi == "" || gioitinh == "")
            {
                MessageBox.Show("Xin Vui Lòng Điền Đầy Đủ Thông Tin");
            }
            else
            {
                if (HocVienDAO.Instance.UpdateHocVien(mahv, hoten, sdt, ngaysinh, diachi, gioitinh))
                {
                    MessageBox.Show("Chỉnh Sửa Thông Tin Học Viên Thành Công!");
                    LoadTTHocVien();
                }
                else
                {
                    MessageBox.Show("Đã Có Lỗi Trong Quá Trình Chỉnh Sửa Thông Tin!");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int mahv = Int32.Parse(lbID.Text);
            DialogResult result = MessageBox.Show("bạn có chắc chắn muốn xóa không?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (result == System.Windows.Forms.DialogResult.Yes){
                if (HocVienDAO.Instance.DeleteHocvien(mahv))
                {
                    MessageBox.Show("Đã Xóa Thành Công!");
                }
                else
                {
                    MessageBox.Show("Đã Xảy Ra Lỗi Trong Quá Trình Xóa!");
                }
            }
            else
            {
                MessageBox.Show("Thoát");
            }
        }

        private void btnnophocphi_Click(object sender, EventArgs e)
        {
            fReceiptTuition f = new fReceiptTuition(mahocvien);
            f.Show();
        }

        private void txtMucUuDai_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fAddClassStudent f = new fAddClassStudent(mahocvien);
            this.Hide();
            f.ShowDialog();
            LoadTTHocVien();
            this.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int mahv = Int32.Parse(lbID.Text);
            DialogResult result = MessageBox.Show("bạn có chắc chắn muốn xóa không?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (LopHocDAO.Instance.DeleteLopHoc(malh))
                {
                    MessageBox.Show("Đã Xóa Thành Công!");
                    LoadTTHocVien();
                }
                else
                {
                    MessageBox.Show("Đã Xảy Ra Lỗi Trong Quá Trình Xóa!");
                }
            }
            else
            {
                MessageBox.Show("Thoát");
            }
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
