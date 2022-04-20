using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class NganhDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NganhDAL() { dc = new DataConnection(); }
        public DataTable getAllSinhVien()
        {
            String sql = "SELECT * FROM Nganh";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool AddSinhVien(Nganh sv)
        {
            String sql = "INSERT INTO Nganh(IDNganh,TenNganh,IDTruong) VALUES (@IDNganh,@TenNganh,@IDTruong)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDNganh", SqlDbType.NVarChar).Value = sv.IDNganh;
                cmd.Parameters.Add("@TenNganh", SqlDbType.NVarChar).Value = sv.TenNganh;

                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool UpdateSinhVien(Nganh sv)
        {
            String sql = "UPDATE Nganh SET TenNganh=@TenNganh,IDTruong=@IDTruong WHERE IDNganh=@IDNganh";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@IDNganh", SqlDbType.NVarChar).Value = sv.IDNganh;
                cmd.Parameters.Add("@TenNganh", SqlDbType.NVarChar).Value = sv.TenNganh;

                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DeleteSinhVien(Nganh sv)
        {
            String sql = "DELETE Nganh WHERE IDNganh=@IDNganh";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDNganh", SqlDbType.NVarChar).Value = sv.IDNganh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}
