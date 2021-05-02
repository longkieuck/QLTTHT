using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class HocVien
    {
        public int MaHV { set; get; }
        public string HoTen { set; get; }
        public string SDT { set; get; }
        public DateTime  NgaySinh { set; get; }
        public string DiaChi { set; get; }
        public string GioiTinh { set; get; }
        public int MaMUD { set; get; }
        
        public HocVien() { }
        public HocVien(DataRow dataRow)
        {
            this.MaHV = Int32.Parse(dataRow["MaHV"].ToString());
            this.HoTen = dataRow["HoTen"].ToString();
            this.SDT = dataRow["SDT"].ToString();
            this.NgaySinh = DateTime.Parse(dataRow["NgaySinh"].ToString());
            this.DiaChi = dataRow["DiaChi"].ToString();
            this.GioiTinh =dataRow["GioiTinh"].ToString();
            this.MaMUD = Int32.Parse(dataRow["MaMUD"].ToString());
        }

    }
}
