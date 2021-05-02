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
    public partial class fReceiptTuition : Form
    {
        private int mahv;
        

        public fReceiptTuition()
        {
            InitializeComponent();
        }

        public fReceiptTuition(int mahv)
        {
            this.mahv = mahv;
            InitializeComponent();
            LoadBLTHP();
            LoadAllBLTHP();
        }

        public void LoadAllBLTHP()
        {
            dgvBLTHP.DataSource = DataProvider.Instance.ExecuteQuery("exec GETALLBLTHPBYMAHV @mahv", new object[] { mahv });
        }
        public void LoadBLTHP()
        {
            List<BienLaiThuHocPhi> list = new List<BienLaiThuHocPhi>();
            list = BienLaiThuHocPhiDAO.Instance.GetBLTHPByMaHV(mahv);
            lbMaBLTHP.Text = list[0].MaBLTHP.ToString();
            HocVien hv = new HocVienDAO().GetHocVienByMaHV(mahv);
            lbten.Text = hv.HoTen;
            dtpNgayThu.Value = DateTime.Now;
            lbThang.Text = list[0].Thang.ToString();
            lbSoTien.Text = list[0].HocPhi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime ngaythu = DateTime.Parse(dtpNgayThu.Text);
            if (BienLaiThuHocPhiDAO.Instance.ThuHocPhi(mahv, ngaythu))
            {
                MessageBox.Show("Thu Thành Công!");
                LoadBLTHP();
                LoadAllBLTHP();
            }
            else
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra Trong Quá Trình Thu!");
            }
        }
    }
}
