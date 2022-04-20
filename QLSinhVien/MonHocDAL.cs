using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class MonHocDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public MonHocDAL(int i) { dc = new DataConnection(i); }
        public DataTable getAllSinhVien()
        {
            String sql = "SELECT * FROM MocHoc";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool AddSinhVien(MonHoc sv)
        {
            String sql = "INSERT INTO MocHoc(IDMonHoc,TenMonHoc,SoTinChi,TheLoai,HinhThucThi,IDNganh) VALUES (@IDMonHoc,@TenMonHoc,@SoTinChi,@TheLoai,@HinhThucThi,@IDNganh)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDMonHoc", SqlDbType.NVarChar).Value = sv.IDMonHoc;
                cmd.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar).Value = sv.TenMonHoc;
                cmd.Parameters.Add("@SoTinChi", SqlDbType.Int).Value = sv.SoTinChi;
                cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar).Value = sv.TheLoai;
                cmd.Parameters.Add("@HinhThucThi", SqlDbType.NVarChar).Value = sv.HinhThucThi;
                cmd.Parameters.Add("@IDNganh", SqlDbType.NVarChar).Value = sv.IDNganh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool UpdateSinhVien(MonHoc sv)
        {
            String sql = "UPDATE MocHoc SET TenMonHoc=@TenMonHoc,SoTinChi=@SoTinChi,TheLoai=@TheLoai,HinhThucThi=@HinhThucThi,IDNganh=@IDNganh WHERE IDMonHoc=@IDMonHoc";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@IDMonHoc", SqlDbType.NVarChar).Value = sv.IDMonHoc;
                cmd.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar).Value = sv.TenMonHoc;
                cmd.Parameters.Add("@SoTinChi", SqlDbType.Int).Value = sv.SoTinChi;
                cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar).Value = sv.TheLoai;
                cmd.Parameters.Add("@HinhThucThi", SqlDbType.NVarChar).Value = sv.HinhThucThi;
                cmd.Parameters.Add("@IDNganh", SqlDbType.NVarChar).Value = sv.IDNganh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DeleteSinhVien(MonHoc sv)
        {
            String sql = "DELETE MocHoc WHERE IDMonHoc=@IDMonHoc";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDMonHoc", SqlDbType.NVarChar).Value = sv.IDMonHoc;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}
