using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class NguoiDungBLL
    {
        NguoiDungDAL dalSV;
        public NguoiDungBLL()
        {
            dalSV = new NguoiDungDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool AddSinhVien(NguoiDung sv)
        {
            return dalSV.AddSinhVien(sv);
        }
        public bool UpdateSinhVien(NguoiDung sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(NguoiDung sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
