namespace HackDayBot.Repository.Sql
{
    public class ClientRepository : DapperRepository
    {
        private const string TableName = "Clients";

        public string GetClientNotebookUrl(string clientName)
        {
            var query = $"SELECT NotebookUrl FROM {TableName} WHERE Name = '{clientName}'";

            return ExecuteQuery(query);
        }

        public string GetClientChangeControlUrl(string clientName)
        {
            var query = $"SELECT ChangeControlUrl FROM {TableName} WHERE Name = '{clientName}'";

            return ExecuteQuery(query);
        }
    }
}