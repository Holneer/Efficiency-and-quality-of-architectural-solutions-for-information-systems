using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class FacebookCreator : SocialNetworkCreator
    {
        public override ISocialNetwork CreateSocialNetwork(string login, string password)
        {
            Console.WriteLine("[FacebookCreator] Створення об'єкта Facebook");
            return new Facebook(login, password);
        }
    }
}