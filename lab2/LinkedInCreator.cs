using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class LinkedInCreator : SocialNetworkCreator
    {
        public override ISocialNetwork CreateSocialNetwork(string email, string password)
        {
            Console.WriteLine("[LinkedInCreator] Створення об'єкта LinkedIn");
            return new LinkedIn(email, password);
        }
    }
}