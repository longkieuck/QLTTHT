using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DTO
{
    class TaiKhoan
    {
        public string TK { set; get; }
        public string MK { set; get; }

        public int MaQuyen { set; get; }

        public TaiKhoan() { }

        public TaiKhoan(DataRow datarow)
        {
            
            this.TK = datarow["TK"].ToString();
            this.MK = datarow["MK"].ToString();
            this.MaQuyen = Int32.Parse(datarow["MaQuyen"].ToString());
        }
    }
}
