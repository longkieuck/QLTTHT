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
            cbMTT.DisplayMember = "MaMTT";
        }

        public void LoadThongTinGV()
        {
            LoadMucTT();
            GiaoVien gv = GiaoVienDAO.Instance.GetGiaoVienByMaGV(magiaovien);
            lbID.Text = gv.MaGV.ToString();
            txtHoTen.Text = gv.HoTen;
            txtDiaChi.Text = gv.DiaChi;
            txtSDT.Text = gv.SDT;
            dtpNgaySinh.Value = gv.NgaySinh;
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
            cbMTT.Text = gv.MaMTT.ToString();
            LoadDSLop();
        }

        public void LoadDSLop()
        {
            List<LopHoc> listLop = LopHocDAO.Instance.GetLopHocByMaGV(magiaovien);
            cbLopDay.DataSource = listLop;
            cbLopDay.DisplayMember = "TenLH";
        }

        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            int magv = Int32.Parse(lbID.Text);
            string hoten = txtHoTen.Text;
           
        }
    }
}
