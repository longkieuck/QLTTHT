using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamHocThem_NhomLongThiepQuynhVan.DAO
{
    class DiemDanh
    {
        public int MaBH { set; get; }
        public int MaHV { set; get; }

        public DiemDanh() { }

        public DiemDanh(DataRow datarow)
        {
            this.MaBH = Int32.Parse(datarow["MaBH"].ToString());
            this.MaHV = Int32.Parse(datarow["MaHV"].ToString());

        }


    }
}