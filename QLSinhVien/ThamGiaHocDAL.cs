using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class ThamGiaHocDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ThamGiaHocDAL() { dc = new DataConnection(); }
        public DataTable getAllSinhVien()
        {
            String sql = "SELECT * FROM ThamGiaHoc";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool AddSinhVien(ThamGiaHoc sv)
        {
            String sql = "INSERT INTO ThamGiaHoc(IDLopHocPhan,IDSinhVien,DiemSo,TenLopHoc) VALUES (@IDLopHocPhan,@IDSinhVien,@DiemSo,@TenLopHoc)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDLopHocPhan", SqlDbType.NVarChar).Value = sv.IDLopHocPhan;
                cmd.Parameters.Add("@IDSinhVien", SqlDbType.NVarChar).Value = sv.IDSinhVien;
                cmd.Parameters.Add("@DiemSo", SqlDbType.Float).Value = sv.DiemSo;
                cmd.Parameters.Add("@TenLopHoc", SqlDbType.NVarChar).Value = sv.TenLopHoc;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool UpdateSinhVien(ThamGiaHoc sv)
        {
            String sql = "UPDATE ThamGiaHoc SET IDLopHocPhan=@IDLopHocPhan,IDSinhVien=@IDSinhVien,DiemSo=@DiemSo WHERE TenLopHoc=@TenLopHoc";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@IDLopHocPhan", SqlDbType.NVarChar).Value = sv.IDLopHocPhan;
                cmd.Parameters.Add("@IDSinhVien", SqlDbType.NVarChar).Value = sv.IDSinhVien;
                cmd.Parameters.Add("@DiemSo", SqlDbType.Float).Value = sv.DiemSo;
                cmd.Parameters.Add("@TenLopHoc", SqlDbType.NVarChar).Value = sv.TenLopHoc;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DeleteSinhVien(ThamGiaHoc sv)
        {
            String sql = "DELETE ThamGiaHoc WHERE TenLopHoc=@TenLopHoc";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TenLopHoc", SqlDbType.NVarChar).Value = sv.TenLopHoc;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}
