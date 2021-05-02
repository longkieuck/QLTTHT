﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTHT.DTO;

namespace QLTTHT.DAO
{
    class BienLaiThuHocPhiDAO
    {
        private static BienLaiThuHocPhiDAO instance;

        internal static BienLaiThuHocPhiDAO Instance
        {
            get { if (instance == null) instance = new BienLaiThuHocPhiDAO(); return instance; }
            private set { instance = value; }
        }
        public List<BienLaiThuHocPhi> GetBLTHPByMaHV(int mahv)
        {
            List<BienLaiThuHocPhi> list = new List<BienLaiThuHocPhi>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetBLTHPByMaHV @mahv", new object[] { mahv });
            foreach (DataRow item in data.Rows)
            {
                BienLaiThuHocPhi entry = new BienLaiThuHocPhi(item);
                list.Add(entry);
            }
            return list;
        }

        public bool ThuHocPhi(int mabl, DateTime ngaythu)//sua mahv thanh mabl
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec THUHOCPHI @mabl , @ngaythu", new object[] { mabl, ngaythu });
            return result > 0;
        }
        public int TongHocPhi(int mahv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec TongHocPhiTheoMaHV @mahv", new object[] { mahv });
            int result;

            foreach (DataRow item in data.Rows)
            {
                result = Int32.Parse(item["HP"].ToString());
                return result;
            }

            return 0;
        }

    }
}