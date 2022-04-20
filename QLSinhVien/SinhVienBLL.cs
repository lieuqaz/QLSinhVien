using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class SinhVienBLL
    {
        SinhVienDAL dalSV;
        public SinhVienBLL(){
            dalSV = new SinhVienDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool AddSinhVien(SinhVien sv)
        {
            return dalSV.AddSinhVien(sv);
        }
        public bool UpdateSinhVien(SinhVien sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(SinhVien sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
