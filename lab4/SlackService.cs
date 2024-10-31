using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class SlackService
    {
        private string _login;
        private string _apiKey;

        public SlackService(string login, string apiKey)
        {
            _login = login;
            _apiKey = apiKey;
        }

        public void SendMessage(string chatId, string message)
        {
            Console.WriteLine($"[SlackService] Відправлено повідомлення у Slack-чат {chatId} з повідомленням '{message}'.");
        }
    }
}