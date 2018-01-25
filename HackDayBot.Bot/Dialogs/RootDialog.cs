using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Web.Configuration;
using Newtonsoft.Json.Linq;
using HackDayBot.Repository.Sql;

namespace HackDayBot.Bot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public static ClientRepository _clientRepo = new ClientRepository();
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            var searchString = activity.Text;

            var link = "Sorry, could not find :(";

            if(searchString != null)
            {
                link = await QueryLUIS(activity.Text);

                if(link == null)
                {
                    link = "Sorry, could not find :(";
                }
            }

            await context.PostAsync(link);
           
            context.Wait(MessageReceivedAsync);
        }

        private static async Task<String> QueryLUIS(string Query)
        {
            var link = String.Empty;
            var LUISQuery = Uri.EscapeDataString(Query);
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                // Get key values from the web.config
                string LUIS_Url = WebConfigurationManager.AppSettings["LUIS_Url"];
                string LUIS_Subscription_Key = WebConfigurationManager.AppSettings["LUIS_Subscription_Key"];
                string RequestURI = String.Format("{0}?subscription-key={1}&q={2}",
                    LUIS_Url, LUIS_Subscription_Key, LUISQuery);
                System.Net.Http.HttpResponseMessage msg = await client.GetAsync(RequestURI);

                if (msg.IsSuccessStatusCode)
                {
                    var JsonDataResponse = await msg.Content.ReadAsStringAsync();
                    var data = JObject.Parse(JsonDataResponse);

                    var intent = data["topScoringIntent"]["intent"].ToString();
                    var clientName = data["entities"][0]["entity"].ToString();

                    switch (intent)
                    {
                     case "client documentation":
                            _clientRepo.GetClientNotebookUrl(clientName);
                            break;
                     case "Client sites":
                            //link = repositorycall(client)
                            break;
                     case "Phone numbers":
                            //link = repositorycall(client)
                            break;
                     case "RFCs/ Change Control":
                            //link = repositorycall(client)
                            break;
                    }
                }
            }
            return link;
        }

        //next steps: link to repository layer. 
        //have links for necessary tables.
        //link to teams.
    }
}