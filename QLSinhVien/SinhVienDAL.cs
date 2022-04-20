using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class SinhVienDAL
    {
        
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SinhVienDAL(int i) { dc = new DataConnection(i); }
        public DataTable getAllSinhVien(){
            String sql = "SELECT * FROM SV";
            SqlConnection con = dc.getConnect();
            da=new SqlDataAdapter(sql,con);
            con.Open();
            DataTable dt=new DataTable();
            da.Fill(dt);    
            con.Close();
            return dt;
            
        }
        public bool AddSinhVien(SinhVien sv)
        {
            String sql = "INSERT INTO SV(IDSinhVien,Ten,Email,Tuoi,GioiTinh,DiaChi,SDT,IDTruong) VALUES (@IDSinhVien,@Ten,@Email,@Tuoi,@GioiTinh,@DiaChi,@SDT,@IDTruong)";
            SqlConnection con=dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDSinhVien", SqlDbType.NVarChar).Value = sv.IDSinhVien;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = sv.Ten;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = sv.Email;
                cmd.Parameters.Add("@Tuoi", SqlDbType.Int).Value = sv.Tuoi;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = sv.SDT;
                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool UpdateSinhVien(SinhVien sv)
        {
            String sql = "UPDATE SV SET Ten=@Ten,Email=@Email,Tuoi=@Tuoi,GioiTinh=@GioiTinh,DiaChi=@DiaChi,SDT=@SDT,IDTruong=@IDTruong WHERE IDSinhVien=@IDSinhVien";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open(); 
                
                cmd.Parameters.Add("@IDSinhVien", SqlDbType.NVarChar).Value = sv.IDSinhVien;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = sv.Ten;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = sv.Email;
                cmd.Parameters.Add("@Tuoi", SqlDbType.Int).Value = sv.Tuoi;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = sv.SDT;
                cmd.Parameters.Add("@IDTruong", SqlDbType.NVarChar).Value = sv.IDTruong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DeleteSinhVien(SinhVien sv)
        {
            String sql = "DELETE SV WHERE IDSinhVien=@IDSinhVien";
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
