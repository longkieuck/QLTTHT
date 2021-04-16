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

        public MucHocPhi GetHocPhi(int malh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetHocPhi @malh", new object[] { malh });
            MucHocPhi gv = new MucHocPhi(data.Rows[0]);
            return gv;
        }

        public bool ThemLopChoGiaoVien(string tenlop, int mamonhoc, int mamhp, int magv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec THEMLH @TenLH , @MaMHP , @MaMH , @MaGV", new object[] { tenlop, mamhp, mamonhoc, magv });
            return result > 0;
        }
    }
}
