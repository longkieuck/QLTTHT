using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class MucHocPhiDAO
    {
        private static MucHocPhiDAO instance;

        public static MucHocPhiDAO Instance
        {
            get { if (instance == null) instance = new MucHocPhiDAO(); return instance; }
            private set { instance = value; }
        }

        public List<MucHocPhi> GetAllMucHocPhi()
        {
            List<MucHocPhi> list = new List<MucHocPhi>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GETALLMUCHP");
            foreach (DataRow item in data.Rows)
            {
                MucHocPhi entry = new MucHocPhi(item);
                list.Add(entry);
            }
            return list;
        }

        public float GetMucHocPhi(int mamhp)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GETMAMUCHOCPHI @MAMHP", new object[] { mamhp });
            MucHocPhi mhp = new MucHocPhi(data.Rows[0]);
            return mhp.HP1Buoi;
        }
    }
}
