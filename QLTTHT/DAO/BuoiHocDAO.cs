using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTHT.DTO;

namespace QLTTHT.DAO
{
    class BuoiHocDAO
    {
        private static BuoiHocDAO instance;

        internal static BuoiHocDAO Instance
        {
            get { if (instance == null) instance = new BuoiHocDAO(); return instance; }
            private set { instance = value; }
        }

        public bool Insert(DateTime ThoiGian, int MaLH)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_Insert_BuoiHoc @ThoiGian , @MaLh", new object[] { ThoiGian, MaLH });
            return result > 0;
        }
    }
}
