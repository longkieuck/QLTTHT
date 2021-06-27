
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

            HocVien hv = new HocVienDAO().GetHocVienByMaHV(mahv);
            lbten.Text = hv.HoTen;
            dtpNgayThu.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int mabl = Int32.Parse(lbMaBLTHP.Text);
            DateTime ngaythu = DateTime.Parse(dtpNgayThu.Text);
            if (BienLaiThuHocPhiDAO.Instance.ThuHocPhi(mabl, ngaythu))
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

        private void dgvBLTHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBLTHP.Rows[e.RowIndex];
                lbMaBLTHP.Text = row.Cells[0].Value.ToString();
                lbSoTien.Text = row.Cells[3].Value.ToString();
                lbThang.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
