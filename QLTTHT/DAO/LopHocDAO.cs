using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTHT.DTO;

namespace QLTTHT.DAO
{
    class LopHocDAO
    {
        private static LopHocDAO instance;

        internal static LopHocDAO Instance
        {
            get { if (instance == null) instance = new LopHocDAO(); return instance; }
            private set { instance = value; }
        }
        public List<LopHoc> GetAll()
        {
            List<LopHoc> list = new List<LopHoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_LopHoc_GetAll");
            foreach (DataRow item in data.Rows)
            {
                LopHoc entry = new LopHoc(item);
                list.Add(entry);
            }
            return list;
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

        public MucHocPhi GetHocPhi(int malh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetHocPhi @malh", new object[] { malh });
            MucHocPhi gv = new MucHocPhi(data.Rows[0]);
            return gv;
        }


    }
}
