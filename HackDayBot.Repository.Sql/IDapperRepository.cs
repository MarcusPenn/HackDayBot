using System.Threading.Tasks;

namespace HackDayBot.Repository.Sql
{
    public interface IDapperRepository
    {
        Task Retrieve(string key);
    }
}