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
        public List<HocVien> Search(string searchValue)
        {
            List<HocVien> list = new List<HocVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_Student_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                HocVien entry = new HocVien(item);
                list.Add(entry);
            }
            return list;
        }
        public HocVien GetHocVienByMaHV(int mahocvien)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetHocVien @mahv", new object[] { mahocvien });
            HocVien hv = new HocVien(data.Rows[0]);
            return hv;
        }

        public bool InsertHocVien(string hoten, string sdt, DateTime ngaysinh, string diachi, string gioitinh, int mamud)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec InsertHocVien @hoten , @sdt , @ngaysinh , @diachi , @gioitinh , @mamud", new object[] { hoten, sdt, ngaysinh, diachi, gioitinh, mamud});
            return result > 0;
        }

        public bool UpdateHocVien(int mahv, string hoten, string sdt, DateTime ngaysinh, string diachi, string gioitinh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdateHocVien @mahv , @hoten , @sdt , @ngaysinh , @diachi , @gioitinh", new object[] { mahv, hoten, sdt, ngaysinh, diachi, gioitinh});
            return result > 0;
        }

        public bool DeleteHocvien(int mahv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec DeleteHocVien @mahv", new object[] { mahv });
            return result > 0;
        }
    }
}
