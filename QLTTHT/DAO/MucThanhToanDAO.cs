using QLTTHT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class MucThanhToanDAO
    {
        private static MucThanhToanDAO instance;

        public static MucThanhToanDAO Instance
        {
            get { if (instance == null) instance = new MucThanhToanDAO(); return instance; }
            private set { instance = value; }
        }

        public List<MucThanhToan> GetAll()
        {
            List<MucThanhToan> list = new List<MucThanhToan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetMucTTList");
            foreach (DataRow item in data.Rows)
            {
                MucThanhToan entry = new MucThanhToan(item);
                list.Add(entry);
            }
            return list;
        }

        public MucThanhToan GetTiLeTT(int mamtt)
        {           
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetMucThanhToan @mamtt", new object[] { mamtt });
            MucThanhToan mtt = new MucThanhToan(data.Rows[0]);
            return mtt;
        }
    }
}
