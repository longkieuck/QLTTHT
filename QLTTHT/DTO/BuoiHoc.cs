using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class BuoiHoc
    {
        public int MaBH { set; get; }
        public DateTime ThoiGian { set; get; }

        public BuoiHoc() { }

        public BuoiHoc(DataRow datarow)
        {
            this.MaBH = Int32.Parse(datarow["MaBH"].ToString());
            this.ThoiGian = DateTime.Parse(datarow["ThoiGian"].ToString());
        }



    }
}