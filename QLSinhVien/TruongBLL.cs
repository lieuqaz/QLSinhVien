using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class TruongBLL
    {
        TruongDAL dalSV;
        public TruongBLL()
        {
            dalSV = new TruongDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool AddSinhVien(Truong sv)
        {
            return dalSV.AddSinhVien(sv);
        }
        public bool UpdateSinhVien(Truong sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(Truong sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
