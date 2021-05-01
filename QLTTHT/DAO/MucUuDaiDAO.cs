using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTHT.DTO;

namespace QLTTHT.DAO
{
    class MucUuDaiDAO
    {
        private static MucUuDaiDAO instance;
        public static MucUuDaiDAO Instance
        {
            get { if (instance == null) instance = new MucUuDaiDAO(); return instance; }
            private set { instance = value; }
        }

        public List<MucUuDai> GetAll()
        {
            List<MucUuDai> list = new List<MucUuDai>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetMucUDList");
            foreach (DataRow item in data.Rows)
            {
                MucUuDai entry = new MucUuDai(item);
                list.Add(entry);
            }
            return list;
        }

        public MucUuDai GetUD(int mamud)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetMucUuDai @mamud", new object[] { mamud });
            MucUuDai mud = new MucUuDai(data.Rows[0]);
            return mud;
        }
    }
}
