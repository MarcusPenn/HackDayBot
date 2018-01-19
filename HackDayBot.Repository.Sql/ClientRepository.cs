using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace HackDayBot.Repository.Sql
{
    public class ClientRepository
    {
        public string Retrieve(string tableName, string clientName, string item)
        {
            var query = $"SELECT {item} FROM {tableName} WHERE Name='{clientName}'";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                return db.ExecuteScalar<string>(query);
            }
        }
    }
}