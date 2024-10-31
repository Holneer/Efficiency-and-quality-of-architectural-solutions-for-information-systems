using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class Facebook : ISocialNetwork
    {
        private string _login;
        private string _password;

        public Facebook(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public void Login(string username, string password)
        {
            Console.WriteLine($"[Facebook] Логін з логіном: {username}");
        }

        public void PostMessage(string message)
        {
            Console.WriteLine($"[Facebook] Публікація повідомлення: {message}");
        }
    }
}