using HackDayBot.Repository.Sql;

namespace HackDayBot.UI.Console
{
    using System;

    public class Program
    {
        private static readonly ClientRepository ClientRepository = new ClientRepository();

        public static void Main(string[] args)
        {
            Console.WriteLine("Get notebook for client.\nClient Name: ");
            var clientName = Console.ReadLine();

            var notebook = ClientRepository.Retrieve("Clients", clientName, "NotebookUrl");
            Console.WriteLine(notebook);

            Console.ReadLine();
        }
    }
}
