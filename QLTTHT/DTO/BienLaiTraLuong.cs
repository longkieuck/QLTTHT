using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamHocThem_NhomLongThiepQuynhVan.DTO
{
    class BienLaiTraLuong
    {
        public int MaBLTL { set; get; }
        public DateTime NgayThu { set; get; }
        public float Luong { set; get; }
        public int MaGV { set; get; }

        public BienLaiTraLuong() { }
        public BienLaiTraLuong(DataRow dataRow)
        {
            this.MaBLTL = Int32.Parse(dataRow["MaBLTL"].ToString());
            this.NgayThu = DateTime.Parse(dataRow["NgayThu"].ToString());
            this.Luong = float.Parse(dataRow["GioiTinh"].ToString());
            this.MaGV = Int32.Parse(dataRow["MaGV"].ToString());
        }
    }
}
