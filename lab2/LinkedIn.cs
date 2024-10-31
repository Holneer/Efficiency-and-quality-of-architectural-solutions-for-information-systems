using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class LinkedIn : ISocialNetwork
    {
        private string _email;
        private string _password;

        public LinkedIn(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void Login(string email, string password)
        {
            Console.WriteLine($"[LinkedIn] Логін з email: {email}");
        }

        public void PostMessage(string message)
        {
            Console.WriteLine($"[LinkedIn] Публікація повідомлення: {message}");
        }
    }
}