using QLTTHT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class LopHocDAO
    {
        private static LopHocDAO instance;

        public int MaLH { set; get; }
        public string TenLH { set; get; }
        public float Hp1Buoi { set; get; }
        public int MaMH { set; get; }
        public int MaGV { set; get; }

        public static LopHocDAO Instance
        {
            get { if (instance == null) instance = new LopHocDAO(); return instance; }
            private set { instance = value; }
        }

        public List<LopHoc> GetLopHocByMaGV(int magv)
        {
            List<LopHoc> list = new List<LopHoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetLopHocByMaGV @magv", new object[] { magv });
            foreach (DataRow item in data.Rows)
            {
                LopHoc entry = new LopHoc(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
