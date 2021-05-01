using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTHT.DAO;

namespace QLTTHT.DAO
{
    class DiemDanhDAO
    {
        private static DiemDanhDAO instance;

        internal static DiemDanhDAO Instance
        {
            get { if (instance == null) instance = new DiemDanhDAO(); return instance; }
            private set { instance = value; }
        }

        public bool Insert(int MaBH, int MaHV)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_Insert_DiemDanh @MaBH , @MaHV", new object[] { MaBH, MaHV });
            return result > 0;
        }
    }
}
