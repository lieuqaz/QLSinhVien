using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class NganhBLL
    {
        NganhDAL dalSV;
        public NganhBLL(int i)
        {
            dalSV = new NganhDAL(i);
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool AddSinhVien(Nganh sv)
        {
            return dalSV.AddSinhVien(sv);
        }
        public bool UpdateSinhVien(Nganh sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(Nganh sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
