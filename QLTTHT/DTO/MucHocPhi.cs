using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class MucHocPhi
    {
        public int MaMHP { set; get; }
        public float HP1Buoi { set; get; }
        public MucHocPhi() { }
        public MucHocPhi(DataRow datarow)
        {
            this.MaMHP = Int32.Parse(datarow["MaMHP"].ToString());
            this.HP1Buoi = float.Parse(datarow["HP1Buoi"].ToString());
        }
    }
}