using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class GiangVienBLL
    {
        GiangVienDAL dalSV;
        public GiangVienBLL(int i)
        {
            dalSV = new GiangVienDAL(i);
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool AddSinhVien(GiangVien sv)
        {
            return dalSV.AddSinhVien(sv);
        }
        public bool UpdateSinhVien(GiangVien sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(GiangVien sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
