using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRiskManager.Database
{
    public class DatabaseHelper
    {
        private static string connectionString =
    "Server=(localdb)\\MSSQLLocalDB;Database=YOUR_DB;Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
