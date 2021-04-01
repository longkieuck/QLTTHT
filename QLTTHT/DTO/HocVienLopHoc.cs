using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class HocVienLopHoc
    {
        public int MaLH { set; get; }
        public int MaHV { set; get; }
        public HocVienLopHoc() { }
        public HocVienLopHoc(DataRow datarow)
        {
            this.MaLH = Int32.Parse(datarow["MaLH"].ToString());
            this.MaHV = Int32.Parse(datarow["MaHV"].ToString());
        }
    }
}