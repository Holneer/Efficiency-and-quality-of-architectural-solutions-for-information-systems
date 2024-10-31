using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public class UserUpdater : BaseEntityUpdater
    {
        protected override object GetEntity()
        {
            Console.WriteLine("[UserUpdater] Отримання об'єкта Користувач.");
            return new { Id = 1, Name = "Користувач", Email = "user@example.com" };
        }

        protected override bool Validate(object entity)
        {
            Console.WriteLine("[UserUpdater] Валідація Користувача (заборона зміни email).");
            return true;
        }

        protected override object CreateSaveRequest(object entity)
        {
            Console.WriteLine("[UserUpdater] Формування запиту на збереження Користувача (без email).");
            return new { Id = 1, Name = "Користувач" };
        }

        protected override object SendSaveRequest(object saveRequest)
        {
            Console.WriteLine("[UserUpdater] Відправлення запиту на збереження Користувача.");
            return new { Status = "Success", Code = 200 };
        }
    }
}