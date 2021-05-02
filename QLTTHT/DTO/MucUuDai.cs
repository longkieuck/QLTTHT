using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class MucUuDai
    {
        public int MaMUD { set; get; }
        public float MUD { set; get; }
        public MucUuDai() { }
        public MucUuDai(DataRow datarow)
        {
            this.MaMUD = Int32.Parse(datarow["MaMUD"].ToString());
            this.MUD = float.Parse(datarow["MucUuDai"].ToString());
        }
    }
}
