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
    public partial class fTeacher : Form
    {
        BindingSource giaovienlist = new BindingSource();

        public fTeacher()
        {
            InitializeComponent();
            LoadTeacher();
        }

        void LoadTeacher()
        {
            dtgvGiaoVien.DataSource = giaovienlist;
            LoadTeacherList();
        }
       
        void LoadTeacherList()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("GetTeacherList");
            giaovienlist.DataSource = data;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string name = txtHoTen.Text;

            string query = string.Format("exec SearchGiaoVienByName @name");
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            dtgvGiaoVien.DataSource = data;
        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            fAddTeacher f = new fAddTeacher();
            this.Hide();
            f.ShowDialog();
            LoadTeacher();
            this.Show();
        }

        private void dtgvGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int MaGVSelected = Int32.Parse(dtgvGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString());          

            fTeacherInfo f = new fTeacherInfo(MaGVSelected);
            this.Hide();
            f.ShowDialog();
            LoadTeacher();
            this.Show();
        }
    }
}
