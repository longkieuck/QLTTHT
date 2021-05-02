using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTTHT.DAO;
using QLTTHT.DTO;

namespace QLTTHT
{
    public partial class fClass : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_TTHT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        BindingSource HocVienCheckList = new BindingSource();
        public fClass()
        {
            InitializeComponent();
            LoadFirstTime();
        }
        public void LoadData()
        {
            int MaLH;
            Int32.TryParse(cbIdLopHoc.SelectedValue.ToString(), out MaLH);
            command = connection.CreateCommand();
            command.CommandText = "ThongKeBuoiHocTheoLop '" + MaLH + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvHocVien.DataSource = table;
        }
        private void LoadFirstTime()
        {
            checkedListBox1.DataSource = HocVienCheckList;
            LoadComboboxIdLopHoc();
            LoadComboboxHocVien();
        }
        private void LoadComboboxIdLopHoc()
        {
            cbIdLopHoc.DataSource = LopHocDAO.Instance.GetAll();
            cbIdLopHoc.DisplayMember = "TenLH";
            cbIdLopHoc.ValueMember = "MaLH";
        }
        private void LoadComboboxHocVien()
        {
            int MaLH = 0;
            Int32.TryParse(cbIdLopHoc.SelectedValue.ToString(), out MaLH);
            HocVienCheckList.DataSource = HocVienDAO.Instance.GetAll_HocVien(MaLH);
            checkedListBox1.DisplayMember = "HoTen";
            //checkedListBox1.ValueMember = "MaHV";
        }


        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn ghi nhận kết quả điểm danh này không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Ghi nhận thành công!");
                DateTime ThoiGian;
                DateTime.TryParse(dateTimePicker1.Text, out ThoiGian);
                int MaLH;
                Int32.TryParse(cbIdLopHoc.SelectedValue.ToString(), out MaLH);
                BuoiHocDAO.Instance.Insert(ThoiGian, MaLH);
                connection = new SqlConnection(str);
                connection.Open();
                SqlCommand cmd = new SqlCommand("BuoiHocVuaThem '" + MaLH + "'", connection);
                cmd.CommandType = CommandType.Text;
                int count = (int)cmd.ExecuteScalar();
                foreach (var s in checkedListBox1.CheckedItems.OfType<HocVien>())
                {
                    DiemDanhDAO.Instance.Insert(count, s.MaHV);
                }
                LoadData();
                LoadComboboxHocVien();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadComboboxHocVien();
        }

        private void cbIdLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboboxHocVien();
        }
    }
}
