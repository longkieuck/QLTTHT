using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamHocThem_NhomLongThiepQuynhVan.DAO
{
    class MonHoc
    {
        public int MaMH { set; get; }
        public string TenMH { set; get; }
        public MonHoc() { }

        public MonHoc(DataRow datarow)
        {
            this.MaMH = Int32.Parse(datarow["MaMH"].ToString());
            this.TenMH = datarow["TenMH"].ToString();
        }
    }
}