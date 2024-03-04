using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace quan_ly_cua_hang_sach
{
    internal class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-7ABSJC3";
            string database = "QUANLYBANSACH";
            string username = "sa";
            string password = "2004";
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
