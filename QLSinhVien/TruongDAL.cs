using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class TruongDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public TruongDAL(int i) { dc = new DataConnection(i); }
        public DataTable getAllSinhVien()
        {
            String sql = "SELECT * FROM Truong";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool AddSinhVien(Truong sv)
        {
            String sql = "INSERT INTO Truong(IDTruong,TenTruong,DiaChi) VALUES (@IDTruong,@TenTruong,@DiaChi)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.Parameters.Add("@TenTruong", SqlDbType.NVarChar).Value = sv.TenTruong;

                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool UpdateSinhVien(Truong sv)
        {
            String sql = "UPDATE Truong SET DiaChi=@DiaChi,TenTruong=@TenTruong WHERE IDTruong=@IDTruong";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.Parameters.Add("@TenTruong", SqlDbType.NVarChar).Value = sv.TenTruong;

                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DeleteSinhVien(Truong sv)
        {
            String sql = "DELETE Truong WHERE IDTruong=@IDTruong";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}
