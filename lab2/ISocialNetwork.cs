using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public interface ISocialNetwork
    {
        void Login(string username, string password);
        void PostMessage(string message);
    }
}