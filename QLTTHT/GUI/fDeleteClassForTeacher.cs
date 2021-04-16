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
    public partial class fDeleteClassForTeacher : Form
    {
        public int malophoc;

        public fDeleteClassForTeacher()
        {
            InitializeComponent();
        }

        public fDeleteClassForTeacher(int malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
            LoadInfoLop();
        }

        void LoadInfoLop()
        {
            List<LopHoc> lh = LopHocDAO.Instance.GetLopHocByMaLH(malophoc);
            lbTenLop.Text = lh[0].TenLH;
            lbMonHoc.Text = MonHocDAO.Instance.GetTenMonHoc(lh[0].MaMH);
            lbMucHocPhi.Text = MucHocPhiDAO.Instance.GetMucHocPhi(lh[0].MaMHP).ToString();
        }

        private void btnXacNhanXoa_Click(object sender, EventArgs e)
        {
            if (LopHocDAO.Instance.XoaLopChoGiaoVien(malophoc))
            {
                MessageBox.Show("Xóa Thông Tin Lớp Học Thành Công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã Xảy Ra Lỗi Trong Quá Trình Xóa Lớp Học!");
            }
        }
    }
}
