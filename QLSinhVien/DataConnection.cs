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
        public DataConnection(){
            conn = "Data Source=VANLIEU; Initial Catalog=QL_SinhVien;UID=sa;PWD=123456;";
}
        public SqlConnection getConnect()
        {
            return new SqlConnection(conn);
        }
        
    }
}
