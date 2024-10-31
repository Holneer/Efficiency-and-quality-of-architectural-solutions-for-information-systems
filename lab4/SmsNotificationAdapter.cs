using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class SmsNotificationAdapter : INotification
    {
        private SmsService _smsService;
        private string _phone;
        private string _sender;

        public SmsNotificationAdapter(SmsService smsService, string phone, string sender)
        {
            _smsService = smsService;
            _phone = phone;
            _sender = sender;
        }

        public void Send(string title, string message)
        {
            string fullMessage = $"{title}: {message}";
            _smsService.SendSms(_phone, _sender, fullMessage);
            Console.WriteLine($"[SmsNotificationAdapter] Відправлено SMS з темою '{title}' і повідомленням '{message}'.");
        }
    }
}