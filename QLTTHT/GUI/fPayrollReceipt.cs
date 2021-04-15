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
        }

        public void LoadBLTL()
        {
            GiaoVien gv = new GiaoVienDAO().GetGiaoVienByMaGV(magiaovien);
            lbTenGV.Text = gv.HoTen;
        }
    }
}
