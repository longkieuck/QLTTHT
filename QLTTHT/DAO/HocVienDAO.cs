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
    class HocVienDAO
    {
        private static HocVienDAO instance;

        internal static HocVienDAO Instance
        {
            get { if (instance == null) instance = new HocVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<HocVien> GetAll_HocVien(int MaLH)
        {
            List<HocVien> list = new List<HocVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_HocVien_GetAll @MaLH", new object[] { MaLH });
            foreach (DataRow item in data.Rows)
            {
                HocVien entry = new HocVien(item);
                list.Add(entry);
            }
            return list;
        }

    }
}
