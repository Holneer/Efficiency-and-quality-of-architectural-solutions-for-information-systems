using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public class UserStorageManager
    {
        private static UserStorageManager _instance;

        public IStorage UserStorage { get; private set; }

        private UserStorageManager(IStorage storage)
        {
            UserStorage = storage;
            Console.WriteLine("[UserStorageManager] Ініціалізація сховища користувача");
        }

        public static UserStorageManager GetInstance(IStorage storage)
        {
            if (_instance == null)
            {
                _instance = new UserStorageManager(storage);
            }
            return _instance;
        }

        public void ChangeStorage(IStorage newStorage)
        {
            Console.WriteLine("[UserStorageManager] Зміна сховища");
            UserStorage = newStorage;
        }
    }

}