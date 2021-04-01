using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class MucHocPhi
    {
        public int MaMHP { set; get; }
        public float MucUuDai { set; get; }
        public MucHocPhi() { }
        public MucHocPhi(DataRow datarow)
        {
            this.MaMHP = Int32.Parse(datarow["MaMHP"].ToString());
            this.MucUuDai = float.Parse(datarow["MucUuDai"].ToString());
        }
    }
}