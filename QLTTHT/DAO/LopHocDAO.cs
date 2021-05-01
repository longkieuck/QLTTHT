using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTHT.DTO;

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

        public List<LopHoc> GetLopHocByMaHV(int mahv)
        {
            List<LopHoc> list = new List<LopHoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetLopHocByMaHV @mahv", new object[] { mahv });
            foreach (DataRow item in data.Rows)
            {
                LopHoc entry = new LopHoc(item);
                list.Add(entry);
            }
            return list;
        }
        public List<LopHoc> GetLopHoc()
        {
            List<LopHoc> list = new List<LopHoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetLopHoc");
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
            MucHocPhi hv = new MucHocPhi(data.Rows[0]);
            return hv;
        }
        public MonHoc GetMonHoc(int malh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetMonHocByMaLH @malh", new object[] { malh });
            MonHoc mh = new MonHoc(data.Rows[0]);
            return mh;
        }
        public GiaoVien GetGiaoVien(int malh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetGiaoVienByMaLH @malh", new object[] { malh });
            GiaoVien gv = new GiaoVien(data.Rows[0]);
            return gv;
        }
        public bool ThemLopHocVien(int malh, int mahv)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("exec ThemLopHocForHocVien @MaLH , @MaHV", new object[] { malh, mahv });
            return result > 0;
          
        }
        public bool DeleteLopHoc(int malh)
        {
            int result=DataProvider.Instance.ExecuteNonQuery("exec XOALH @MaLH",new object[] { malh });
            return result > 0;
        }
    }
}