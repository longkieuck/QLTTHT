using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class BienLaiThuHocPhi
    {
        public int MaBLTHP { set; get; }
        public DateTime NgayThu { set; get; }
        public int Thang { get; set; }
        public float HocPhi { set; get; }
        public int DaThanhToan { set; get; }
        public int MaHV { set; get; }
        
        public BienLaiThuHocPhi() { }
        public BienLaiThuHocPhi(DataRow dataRow)
        {
            this.MaBLTHP = Int32.Parse(dataRow["MaBLTHP"].ToString());
            this.NgayThu = DateTime.Parse(dataRow["NgayThu"].ToString());
            this.Thang=Int32.Parse(dataRow["Thang"].ToString());
            this.HocPhi = float.Parse(dataRow["HocPhi"].ToString());
            this.DaThanhToan = Int32.Parse(dataRow["DaThanhToan"].ToString());
            this.MaHV = Int32.Parse(dataRow["MaHV"].ToString());
        }
    }
}
