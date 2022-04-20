using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class LopHocPhanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public LopHocPhanDAL(int i) { dc = new DataConnection(i); }
        public DataTable getAllSinhVien()
        {
            String sql = "SELECT * FROM LopHocPhan";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool AddSinhVien(LopHocPhan sv)
        {
            String sql = "INSERT INTO LopHocPhan(IDLopHocPhan,NamHoc,HocKy,IDMonHoc,IDGiangVien,GioiHanSV) VALUES (@IDLopHocPhan,@NamHoc,@HocKy,@IDMonHoc,@IDGiangVien,@GioiHanSV)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDLopHocPhan", SqlDbType.NVarChar).Value = sv.IDLopHocPhan;
                cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = sv.NamHoc;
                cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = sv.HocKy;
                cmd.Parameters.Add("@IDMonHoc", SqlDbType.NVarChar).Value = sv.IDMonHoc;
                cmd.Parameters.Add("@IDGiangVien", SqlDbType.NVarChar).Value = sv.IDGiangVien;
                cmd.Parameters.Add("@GioiHanSV", SqlDbType.NVarChar).Value = sv.GioiHanSV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool UpdateSinhVien(LopHocPhan sv)
        {
            String sql = "UPDATE LopHocPhan SET NamHoc=@NamHoc,HocKy=@HocKy,IDMonHoc=@IDMonHoc,IDGiangVien=@IDGiangVien,GioiHanSV=@GioiHanSV WHERE IDLopHocPhan=@IDLopHocPhan";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@IDLopHocPhan", SqlDbType.NVarChar).Value = sv.IDLopHocPhan;
                cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = sv.NamHoc;
                cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = sv.HocKy;
                cmd.Parameters.Add("@IDMonHoc", SqlDbType.NVarChar).Value = sv.IDMonHoc;
                cmd.Parameters.Add("@IDGiangVien", SqlDbType.NVarChar).Value = sv.IDGiangVien;
                cmd.Parameters.Add("@GioiHanSV", SqlDbType.NVarChar).Value = sv.GioiHanSV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DeleteSinhVien(LopHocPhan sv)
        {
            String sql = "DELETE LopHocPhan WHERE IDLopHocPhan=@IDLopHocPhan";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDLopHocPhan", SqlDbType.NVarChar).Value = sv.IDLopHocPhan;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}
