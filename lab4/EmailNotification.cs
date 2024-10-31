using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class EmailNotification : INotification
    {
        private string _adminEmail;

        public EmailNotification(string adminEmail)
        {
            _adminEmail = adminEmail;
        }

        public void Send(string title, string message)
        {
            Console.WriteLine($"[EmailNotification] Відправлено email з темою '{title}' на '{_adminEmail}' з повідомленням '{message}'.");
        }
    }
}