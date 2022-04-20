using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class LopHocPhanBLL
    {
        LopHocPhanDAL dalSV;
        public LopHocPhanBLL()
        {
            dalSV = new LopHocPhanDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool AddSinhVien(LopHocPhan sv)
        {
            return dalSV.AddSinhVien(sv);
        }
        public bool UpdateSinhVien(LopHocPhan sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(LopHocPhan sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
