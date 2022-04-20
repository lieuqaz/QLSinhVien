using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class GiangVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public GiangVienDAL() { dc = new DataConnection(); }
        public DataTable getAllSinhVien()
        {
            String sql = "SELECT * FROM GiangVien";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool AddSinhVien(GiangVien sv)
        {
            String sql = "INSERT INTO GiangVien(IDGiangVien,TenGiangVien,IDTruong) VALUES (@IDGiangVien,@TenGiangVien,@IDTruong)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDGiangVien", SqlDbType.NVarChar).Value = sv.IDGiangVien;
                cmd.Parameters.Add("@TenGiangVien", SqlDbType.NVarChar).Value = sv.TenGiangVien;
             
                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool UpdateSinhVien(GiangVien sv)
        {
            String sql = "UPDATE GiangVien SET TenGiangVien=@TenGiangVien,IDTruong=@IDTruong WHERE IDGiangVien=@IDGiangVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@IDGiangVien", SqlDbType.NVarChar).Value = sv.IDGiangVien;
                cmd.Parameters.Add("@TenGiangVien", SqlDbType.NVarChar).Value = sv.TenGiangVien;

                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DeleteSinhVien(GiangVien sv)
        {
            String sql = "DELETE GiangVien WHERE IDGiangVien=@IDGiangVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDGiangVien", SqlDbType.NVarChar).Value = sv.IDGiangVien;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}
