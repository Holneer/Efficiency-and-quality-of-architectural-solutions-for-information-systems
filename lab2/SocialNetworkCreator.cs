using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class SocialNetworkCreator
    {
        public abstract ISocialNetwork CreateSocialNetwork(string usernameOrEmail, string password);

        public void PublishMessage(string usernameOrEmail, string password, string message)
        {
            ISocialNetwork socialNetwork = CreateSocialNetwork(usernameOrEmail, password);
            socialNetwork.Login(usernameOrEmail, password);
            socialNetwork.PostMessage(message);
        }
    }
}