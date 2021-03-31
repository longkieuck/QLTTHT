using QLTTHT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamHocThem_NhomLongThiepQuynhVan
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TaiKhoanDAO.Instance.MaQuyen == 2)
            {
                fTeacher f = new fTeacher();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fClass f = new fClass();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAO.Instance.MaQuyen == 2)
            {
                fStudent f = new fStudent();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
            }
        }
    }
}
