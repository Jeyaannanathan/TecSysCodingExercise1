
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CodingExercise
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string connectionName = "WingTipToysConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString()))
            {
                return conn.Query<T>(sql).ToList();
            }
        }

        public static int AddToDb<T>(string sql, T data)
        {
            using(IDbConnection conn =  new SqlConnection(GetConnectionString())) 
            {
                return conn.Execute(sql, data);
            }
        }
    }
}
