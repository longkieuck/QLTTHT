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
    public partial class fPayrollReceipt : Form
    {
        public int magiaovien;

        public fPayrollReceipt()
        {
            InitializeComponent();
        }

        public fPayrollReceipt(int magv)
        {
            this.magiaovien = magv;
            InitializeComponent();
            LoadBLTL();
            LoadAllBLTL();
        }

        public void LoadAllBLTL()
        {
            dtgvBLTL.DataSource = DataProvider.Instance.ExecuteQuery("exec GETALLBTLTBYMAGV @magv", new object[] { magiaovien });
        }
        public void LoadBLTL()
        {
            List<BienLaiTraLuong> list = new List<BienLaiTraLuong>();
            list = BienLaiTraLuongDAO.Instance.GetBLTLByMaGV(magiaovien);
            lbMaBLTL.Text = list[0].MaBLTL.ToString();
            GiaoVien gv = new GiaoVienDAO().GetGiaoVienByMaGV(magiaovien);
            lbTenGV.Text = gv.HoTen;
            dtpNgayTra.Value = DateTime.Now;
            lbThang.Text = list[0].Thang.ToString();
            lbTongTien.Text = list[0].Luong.ToString();          
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            DateTime ngaytra = DateTime.Parse(dtpNgayTra.Text);
            if (BienLaiTraLuongDAO.Instance.ThanhToanLuong(magiaovien, ngaytra))
            {
                MessageBox.Show("Thanh Toán Lương Giáo Viên Thành Công!");
                LoadBLTL();
                LoadAllBLTL();
            }
            else
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra Trong Quá Trình Thanh Toán!");
            }
        }
    }
}
