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
    public partial class fAddClassForTeacher : Form
    {
        public int magv;
        public int mamh;
        public int mamuchp;

        public fAddClassForTeacher()
        {
            InitializeComponent();
        }

        public fAddClassForTeacher(int magv)
        {
            this.magv = magv;
            InitializeComponent();
            LoadInfo();
        }

        public void LoadInfo()
        {
            LoadMonHoc();
            LoadMucHocPhi();
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

        private void cbMonHoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            MonHoc selected = cbMonHoc.SelectedItem as MonHoc;
            mamh = selected.MaMH;
        }

        private void cbMucHocPhi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            MucHocPhi selected = cbMucHocPhi.SelectedItem as MucHocPhi;
            mamuchp = selected.MaMHP;
        }

        private void btnThemLop_Click_1(object sender, EventArgs e)
        {
            string tenlop = txtTenLop.Text;
            if (LopHocDAO.Instance.ThemLopChoGiaoVien(tenlop, mamh, mamuchp, magv))
            {
                MessageBox.Show("Thêm Lớp Thành Công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra Trong Quá Trình Thêm Lớp!");
            }
        }


    }
}
