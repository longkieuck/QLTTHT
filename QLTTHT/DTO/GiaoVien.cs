using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class GiaoVien
    {
        public int MaGV { set; get; }
        public string HoTen { set; get; }
        public string SDT { set; get; }
        public DateTime NgaySinh { set; get; }
        public string DiaChi { set; get; }
        public string GioiTinh { set; get; }
        public int MaMTT { set; get; }

        public GiaoVien() { }
        public GiaoVien(DataRow dataRow)
        {
            this.MaGV = Int32.Parse(dataRow["MaGV"].ToString());
            this.HoTen = dataRow["HoTen"].ToString();
            this.SDT = dataRow["SDT"].ToString();
            this.NgaySinh = DateTime.Parse(dataRow["NgaySinh"].ToString());
            this.DiaChi = dataRow["DiaChi"].ToString();
            this.GioiTinh = dataRow["GioiTinh"].ToString();
            this.MaMTT = Int32.Parse(dataRow["MaMTT"].ToString());
        }
    }
}
