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
    public partial class fTeacher : Form
    {
        public fTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fAddTeacher f = new fAddTeacher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
