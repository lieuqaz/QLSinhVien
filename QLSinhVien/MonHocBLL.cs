using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class MonHocBLL
    {
        MonHocDAL dalSV;
        public MonHocBLL()
        {
            dalSV = new MonHocDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool AddSinhVien(MonHoc sv)
        {
            return dalSV.AddSinhVien(sv);
        }
        public bool UpdateSinhVien(MonHoc sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(MonHoc sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
