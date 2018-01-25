namespace HackDayBot.Repository.Sql
{
    public class ExamRepository : DapperRepository
    {
        private const string TableName = "Exams";

        public string GetExamName(int id)
        {
            var query = $"SELECT Name FROM {TableName} WHERE Id = '{id}'";

            return ExecuteQuery(query);
        }
    }
}