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
        public int GioiTinh { set; get; }
        public int MaMHP { set; get; }
        
        public HocVien() { }
        public HocVien(DataRow dataRow)
        {
            this.MaHV = Int32.Parse(dataRow["MaHV"].ToString());
            this.HoTen = dataRow["HoTen"].ToString();
            this.SDT = dataRow["SDT"].ToString();
            this.NgaySinh = DateTime.Parse(dataRow["NgaySinh"].ToString());
            this.GioiTinh = Int32.Parse(dataRow["GioiTinh"].ToString());
            this.MaMHP = Int32.Parse(dataRow["MaMHP"].ToString());
        }

    }
}
