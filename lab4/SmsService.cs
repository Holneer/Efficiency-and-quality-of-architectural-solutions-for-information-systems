using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    public class SmsService
    {
        public void SendSms(string phone, string sender, string message)
        {
            Console.WriteLine($"[SmsService] Відправлено SMS на номер '{phone}' від '{sender}' з повідомленням '{message}'.");
        }
    }
}