using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class MucThanhToan
    {
        public int MaMTT { set; get; }
        public float TiLe { set; get; }
        public MucThanhToan() { }

        public MucThanhToan(DataRow datarow)
        {
            this.MaMTT = Int32.Parse(datarow["MaMTT"].ToString());
            this.TiLe = float.Parse(datarow["TiLe"].ToString());
        }
    }
}
