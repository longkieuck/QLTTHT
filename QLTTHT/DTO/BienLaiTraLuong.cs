using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class BienLaiTraLuong
    {
        public int MaBLTL { set; get; }
        public DateTime NgayTra { set; get; }
        public int Thang { set; get; }
        public float Luong { set; get; }
        public int DaThanhToan { set; get; }
        public int MaGV { set; get; }

        public BienLaiTraLuong() { }
        public BienLaiTraLuong(DataRow dataRow)
        {
            this.MaBLTL = Int32.Parse(dataRow["MaBLTL"].ToString());
            if (dataRow["NgayTra"].ToString().Equals(""))
            {
                this.NgayTra = DateTime.Now;
            }
            else
                this.NgayTra = DateTime.Parse(dataRow["NgayTra"].ToString());
            this.Thang = Int32.Parse(dataRow["Thang"].ToString());
            this.Luong = float.Parse(dataRow["Luong"].ToString());
            this.DaThanhToan = Int32.Parse(dataRow["DaThanhToan"].ToString());
            this.MaGV = Int32.Parse(dataRow["MaGV"].ToString());
        }
    }
}
