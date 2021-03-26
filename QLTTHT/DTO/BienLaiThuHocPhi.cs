using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamHocThem_NhomLongThiepQuynhVan.DTO
{
    class BienLaiThuHocPhi
    {
        public int MaBLTHP { set; get; }
        public DateTime NgayThu { set; get; }
        public float HocPhi { set; get; }
        public int MaHV { set; get; }
        public BienLaiThuHocPhi() { }
        public BienLaiThuHocPhi(DataRow dataRow)
        {
            this.MaBLTHP = Int32.Parse(dataRow["MaBLTL"].ToString());
            this.NgayThu = DateTime.Parse(dataRow["NgayThu"].ToString());
            this.HocPhi = float.Parse(dataRow["GioiTinh"].ToString());
            this.MaHV = Int32.Parse(dataRow["MaGV"].ToString());
        }
    }
}
