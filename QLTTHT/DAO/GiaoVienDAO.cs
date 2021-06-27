using QLTTHT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTHT.DAO
{
    class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public int MaGV { set; get; }
        public string HoTen { set; get; }
        public string SDT { set; get; }
        public DateTime NgaySinh { set; get; }
        public string DiaChi { set; get; }
        public int GioiTinh { set; get; }
        public int MaMHP { set; get; }

        public static GiaoVienDAO Instance
        {
            get { if (instance == null) instance = new GiaoVienDAO(); return instance; }
            private set { instance = value; }
        }

        public List<GiaoVien> GetAll()
        {
            List<GiaoVien> list = new List<GiaoVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetTeacherList");
            foreach (DataRow item in data.Rows)
            {
                GiaoVien entry = new GiaoVien(item);
                list.Add(entry);
            }
            return list;
        }

        public GiaoVien GetGiaoVienByMaGV(int magiaovien)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetGiaoVien @magv", new object[] { magiaovien });
            GiaoVien gv = new GiaoVien(data.Rows[0]);
            return gv;
        }

        public bool InsertGiaoVien(string hoten, DateTime ngaysinh, string diachi, string gioitinh, string sdt, int mamtt, string tk, string mk)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec InsertGiaoVien @hoten , @ngaysinh , @diachi , @gioitinh , @sdt , @mamtt , @tk , @mk", new object[] { hoten, ngaysinh, diachi, gioitinh, sdt, mamtt, tk, mk });
            return result > 0;
        }

        public bool UpdateGiaoVien(int magv, string hoten, DateTime ngaysinh, string diachi, string gioitinh, string sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdateGiaoVien @magv , @hoten , @sdt , @ngaysinh , @diachi , @gioitinh", new object[] { magv, hoten, sdt, ngaysinh, diachi, gioitinh });
            return result > 0;
        }

        public bool DeleteGiaoVien(int magv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec DeleteGiaoVien @magv", new object[] { magv });
            return result > 0;
        }
    }
}