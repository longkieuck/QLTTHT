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

        public bool ThemLopChoGiaoVien(string tenlop, int mamonhoc, int mamhp, int magv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec THEMLH @TenLH , @MaMHP , @MaMH , @MaGV", new object[] { tenlop, mamhp, mamonhoc, magv });
            return result > 0;
        }

        public List<LopHoc> GetLopHocByMaLH(int malophoc)
        {
            List<LopHoc> list = new List<LopHoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GETLOPHOC @MALH", new object[] { malophoc });
            foreach (DataRow item in data.Rows)
            {
                LopHoc entry = new LopHoc(item);
                list.Add(entry);
            }
            return list;
        }

        public bool SuaLopChoGiaoVien(int malophoc, string tenlophoc, int mamhp, int mamh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec SUALH @MaLH , @TenLH , @MaMHP , @MaMH", new object[] { malophoc, tenlophoc, mamhp, mamh });
            return result > 0;
        }

        public bool XoaLopChoGiaoVien(int malh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec XOALH @MALH", new object[] { malh });
            return result > 0;
        }

        public int GetMaMonHoc(string tenmonhoc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GETMAMONHOC @TENMH", new object[] { tenmonhoc });
            MonHoc mh = new MonHoc(data.Rows[0]);
            return mh.MaMH;
        }

        public int GetMaMHP(float hp1buoi)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GETMAMHP @HP1BUOI", new object[] { hp1buoi });
            MucHocPhi mh = new MucHocPhi(data.Rows[0]);
            return mh.MaMHP;
        }
    }
}
