using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class MonHocDAO
    {
        private static MonHocDAO instance;

        public static MonHocDAO Instance
        {
            get { if (instance == null) instance = new MonHocDAO(); return instance; }
            private set { instance = value; }
        }

        public List<MonHoc> GetAllMonHoc()
        {
            List<MonHoc> list = new List<MonHoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GETALLMONHOC");
            foreach (DataRow item in data.Rows)
            {
                MonHoc entry = new MonHoc(item);
                list.Add(entry);
            }
            return list;
        }

        public string GetTenMonHoc(int mamonhoc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GETMONHOC @MAMH", new object[] { mamonhoc });
            MonHoc mh = new MonHoc(data.Rows[0]);
            return mh.TenMH;
        }
    }
}
