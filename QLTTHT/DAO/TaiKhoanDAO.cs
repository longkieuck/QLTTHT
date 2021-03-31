using QLTTHT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public int MaQuyen { set; get; }
        public int MaGV { set; get; }
        
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO(DataRow item) {
            this.MaQuyen = 2;
            this.MaGV = 0;
        }

        public TaiKhoanDAO()
        {
        }

        public bool Login(string userName, string pass)
        {
            string query = "SP_Login @username , @pass";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, pass });
            TaiKhoanDAO.Instance.SetMaGVByUserName(userName);
            TaiKhoanDAO.Instance.SetMaQuyenByUserName(userName);
            return result.Rows.Count > 0;
        }

        public void SetMaQuyenByUserName(string userName)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            string query = "SP_GetMaQuyenByUserName @username";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                taiKhoan = new TaiKhoan(item);
            }
            this.MaQuyen = taiKhoan.MaQuyen;
        }

        public void SetMaGVByUserName(string userName)
        {
            GiaoVien giaoVien = new GiaoVien();
            string query = "SP_GetMaGVByUserName @username";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                giaoVien = new GiaoVien(item);
            }
            this.MaGV = giaoVien.MaGV;
        }

        
    }
}
