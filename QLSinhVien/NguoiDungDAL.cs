using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class NguoiDungDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NguoiDungDAL(int i) { dc = new DataConnection(i); }
        public DataTable getAllSinhVien()
        {
            String sql = "SELECT * FROM NguoiDung";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool AddSinhVien(NguoiDung sv)
        {
            String sql = "INSERT INTO NguoiDung(TenNguoiDung,MatKhau,TheLoai,IDSinhVien,IDTruong) VALUES (@TenNguoiDung,@MatKhau,@TheLoai,@IDSinhVien,@IDTruong)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = sv.TenNguoiDung;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = sv.MatKhau;
                cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar).Value = sv.TheLoai;
                cmd.Parameters.Add("@IDSinhVien", SqlDbType.NVarChar).Value = sv.IDSinhVien;
                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool UpdateSinhVien(NguoiDung sv)
        {
            String sql = "UPDATE NguoiDung SET TenNguoiDung=@TenNguoiDung,MatKhau=@MatKhau,TheLoai=@TheLoai,IDTruong=@IDTruong WHERE IDSinhVien=@IDSinhVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = sv.TenNguoiDung;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = sv.MatKhau;

                cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar).Value = sv.TheLoai;
                cmd.Parameters.Add("@IDSinhVien", SqlDbType.NVarChar).Value = sv.IDSinhVien;
                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DeleteSinhVien(NguoiDung sv)
        {
            String sql = "DELETE NguoiDung WHERE IDSinhVien=@IDSinhVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDSinhVien", SqlDbType.NVarChar).Value = sv.IDSinhVien;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}
