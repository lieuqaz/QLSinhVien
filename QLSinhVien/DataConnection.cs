using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class DataConnection
    {
        String conn;
        int i;
      
        public DataConnection(){
            if (i == 0) { conn = "Data Source=VANLIEU; Initial Catalog=QL_SinhVien;UID=sa;PWD=123456;"; }
            if(i == 1) { conn = "Data Source=VANLIEU\\MSSQLSERVER01; Initial Catalog=QL_T1;UID=sa;PWD=123456;"; }
            if (i == 2) { conn = "Data Source=VANLIEU\\MSSQLSERVER02; Initial Catalog=QL_T2;UID=sa;PWD=123456;"; }
            if (i == 3) { conn = "Data Source=VANLIEU\\MSSQLSERVER03; Initial Catalog=QL_T3;UID=sa;PWD=123456;"; }
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conn);
        }
        
    }
}
