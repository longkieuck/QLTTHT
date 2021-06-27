using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class LopHoc
    {
        public int MaLH { set; get; }
        public string TenLH { set; get; }
        public int MaMHP { set; get; }
        public int MaMH { set; get; }
        public int MaGV { set; get; }

        public LopHoc() { }
        public LopHoc(DataRow dataRow)
        {
            this.MaLH = Int32.Parse(dataRow["MaLH"].ToString());
            this.TenLH = dataRow["TenLH"].ToString();
            this.MaMHP = Int32.Parse(dataRow["MaMHP"].ToString());
            this.MaMH = Int32.Parse(dataRow["MaMH"].ToString());
        }
    }
}
