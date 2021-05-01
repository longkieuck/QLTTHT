using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTHT.DTO;
namespace QLTTHT.DAO
{
    class HocVienLopHocDAO
    {
        private static HocVienLopHocDAO instance;

        internal static HocVienLopHocDAO Instance
        {
            get { if (instance == null) instance = new HocVienLopHocDAO(); return instance; }
            private set { instance = value; }
        }
        public List<HocVienLopHoc> GetMaLopHocByMaHV(int mahv)
        {
            List<HocVienLopHoc> list = new List<HocVienLopHoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetMaLopHocByMaHV @mahv", new object[] { mahv });
            foreach (DataRow item in data.Rows)
            {
                HocVienLopHoc entry = new HocVienLopHoc(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
