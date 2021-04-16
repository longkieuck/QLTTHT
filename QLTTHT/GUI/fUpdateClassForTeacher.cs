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

namespace QLTTHT.GUI
{
    public partial class fUpdateClassForTeacher : Form
    {
        public int malh;

        public fUpdateClassForTeacher()
        {
            InitializeComponent();
        }

        public fUpdateClassForTeacher(int malh)
        {
            this.malh = malh;
            InitializeComponent();
            LoadInfo();
        }

        public void LoadInfo()
        {
            LoadMonHoc();
            LoadMucHocPhi();
            LoadInfoLopHoc();
        }

        public void LoadMonHoc()
        {
            List<MonHoc> listMonHoc = MonHocDAO.Instance.GetAllMonHoc();
            cbMonHoc.DataSource = listMonHoc;
            cbMonHoc.DisplayMember = "TenMH";
        }

        public void LoadMucHocPhi()
        {
            List<MucHocPhi> listMucHP = MucHocPhiDAO.Instance.GetAllMucHocPhi();
            cbMucHocPhi.DataSource = listMucHP;
            cbMucHocPhi.DisplayMember = "HP1Buoi";
        }

        public void LoadInfoLopHoc()
        {
            List<LopHoc> lh = LopHocDAO.Instance.GetLopHocByMaLH(malh);
            txtTenLop.Text = lh[0].TenLH;
            cbMonHoc.Text = MonHocDAO.Instance.GetTenMonHoc(lh[0].MaMH);
            cbMucHocPhi.Text = MucHocPhiDAO.Instance.GetMucHocPhi(lh[0].MaMHP).ToString();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            string tenlophoc = txtTenLop.Text;
            int mamuchp = LopHocDAO.Instance.GetMaMHP(float.Parse(cbMucHocPhi.Text));
            int mamh = LopHocDAO.Instance.GetMaMonHoc(cbMonHoc.Text);
            if (LopHocDAO.Instance.SuaLopChoGiaoVien(malh,tenlophoc, mamuchp, mamh))
            {
                MessageBox.Show("Sửa Thông Tin Lớp Học Thành Công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã Xảy Ra Lỗi Trong Quá Trình Sửa Đổi Thông Tin!");
            }

        }
    }
}
