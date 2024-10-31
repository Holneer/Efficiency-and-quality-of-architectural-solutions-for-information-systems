using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class SlackNotificationAdapter : INotification
    {
        private SlackService _slackService;
        private string _chatId;

        public SlackNotificationAdapter(SlackService slackService, string chatId)
        {
            _slackService = slackService;
            _chatId = chatId;
        }

        public void Send(string title, string message)
        {
            string fullMessage = $"{title}: {message}";
            _slackService.SendMessage(_chatId, fullMessage);
            Console.WriteLine($"[SlackNotificationAdapter] Відправлено повідомлення у Slack з темою '{title}' і повідомленням '{message}'.");
        }
    }
}