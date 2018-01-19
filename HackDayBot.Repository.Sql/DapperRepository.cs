using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace HackDayBot.Repository.Sql
{
    public class DapperRepository
    {
        public string ExecuteQuery(string query)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                return db.ExecuteScalar<string>(query);
            }
        }
    }
}