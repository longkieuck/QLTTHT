using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
        public List<HocVien> GetAll()
        {
            List<HocVien> list = new List<HocVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("HocSinh_GetAll");
            foreach (DataRow item in data.Rows)
            {
                HocVien entry = new HocVien(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
