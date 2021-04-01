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
    public partial class fStudent : Form
    {
        public fStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fAddStudent f = new fAddStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
    }
}
