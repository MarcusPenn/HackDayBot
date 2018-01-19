using HackDayBot.Repository.Sql;

namespace HackDayBot.UI.Console
{
    using System;

    public class Program
    {
        private static readonly ClientRepository ClientRepository = new ClientRepository();

        public static void Main(string[] args)
        {
            Console.WriteLine("Client Name: ");
            var clientName = Console.ReadLine();

            var notebookUrl = ClientRepository.GetClientNotebookUrl(clientName);
            var changeControlUrl = ClientRepository.GetClientChangeControlUrl(clientName);

            Console.WriteLine($"Notebook Url: {notebookUrl}");
            Console.WriteLine($"Change Control Url: {changeControlUrl}");

            Console.ReadLine();
        }
    }
}
