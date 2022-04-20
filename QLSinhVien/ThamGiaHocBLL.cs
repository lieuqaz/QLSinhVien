using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class ThamGiaHocBLL
    {
        ThamGiaHocDAL dalSV;
        public ThamGiaHocBLL()
        {
            dalSV = new ThamGiaHocDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool AddSinhVien(ThamGiaHoc sv)
        {
            return dalSV.AddSinhVien(sv);
        }
        public bool UpdateSinhVien(ThamGiaHoc sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(ThamGiaHoc sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
