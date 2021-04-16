using QLTTHT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class BienLaiTraLuongDAO
    {
        private static BienLaiTraLuongDAO instance;

        public static BienLaiTraLuongDAO Instance
        {
            get { if (instance == null) instance = new BienLaiTraLuongDAO(); return instance; }
            private set { instance = value; }
        }

        public List<BienLaiTraLuong> GetBLTLByMaGV(int magv)
        {
            List<BienLaiTraLuong> list = new List<BienLaiTraLuong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetBLTLByMaGV @magv", new object[] { magv });
            foreach (DataRow item in data.Rows)
            {
                BienLaiTraLuong entry = new BienLaiTraLuong(item);
                list.Add(entry);
            }
            return list;
        }

        public bool ThanhToanLuong(int magv, DateTime ngaytra)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec THANHTOANLUONG @magv , @ngaytra", new object[] { magv, ngaytra });
            return result > 0;
        }
    }
}
