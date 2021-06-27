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

namespace QLTTHT.GUI
{
    public partial class fAddClassStudent : Form
    {
        public int mahv;
        private int malh;
       
       
        public fAddClassStudent(int mahv)
        {
            this.mahv = mahv;
            InitializeComponent();
            LoadInfo();

        }
        public void LoadInfo()
        {
            LoadClass();
            //GiaoVien gv = LopHocDAO.Instance.GetGiaoVien(malh);
            //txtGiaoVien.Text = gv.HoTen.ToString();
            //MonHoc mh = LopHocDAO.Instance.GetMonHoc(malh);
            //txtMonHoc.Text = mh.TenMH.ToString();
            //MucHocPhi hp = LopHocDAO.Instance.GetHocPhi(malh);
            //txtHocPhi.Text = hp.HP1Buoi.ToString();
        }
        public void LoadClass()
        {
            List<LopHoc> listMonHoc = LopHocDAO.Instance.GetLopHoc();
            cbbTenLop.DataSource = listMonHoc;
            cbbTenLop.DisplayMember = "TenLH";
        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            LopHoc selected = cbbTenLop.SelectedItem as LopHoc;
            malh = selected.MaLH;
            txtGiaoVien.Text = LopHocDAO.Instance.GetGiaoVien(selected.MaLH).HoTen.ToString();
            txtMonHoc.Text = LopHocDAO.Instance.GetMonHoc(selected.MaLH).TenMH.ToString();
            txtHocPhi.Text = LopHocDAO.Instance.GetHocPhi(selected.MaLH).HP1Buoi.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            if (LopHocDAO.Instance.ThemLopHocVien(malh,mahv))
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
