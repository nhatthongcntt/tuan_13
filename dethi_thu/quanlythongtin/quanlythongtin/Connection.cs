using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace quanlythongtin
{
    class Connection
    {
        public static string conSTR = @"Data Source=A209PC43\CSSQL08;Initial Catalog=QLHN;Integrated Security=True";
        public static SqlConnection getSqlConnect()
        {
            return new SqlConnection(conSTR);
        }
    }
}
