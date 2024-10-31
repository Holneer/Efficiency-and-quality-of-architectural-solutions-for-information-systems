using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public class ProductUpdater : BaseEntityUpdater
    {
        protected override object GetEntity()
        {
            Console.WriteLine("[ProductUpdater] Отримання об'єкта Товар.");
            return new { Id = 1, Name = "Товар", Price = 100 };
        }

        protected override bool Validate(object entity)
        {
            Console.WriteLine("[ProductUpdater] Валідація Товару.");
            return false;
        }

        protected override object CreateSaveRequest(object entity)
        {
            Console.WriteLine("[ProductUpdater] Формування запиту на збереження Товару.");
            return new { Entity = entity };
        }

        protected override object SendSaveRequest(object saveRequest)
        {
            Console.WriteLine("[ProductUpdater] Відправлення запиту на збереження Товару.");
            return new { Status = "Success", Code = 200 };
        }

        protected override void OnValidationFailed()
        {
            Console.WriteLine("[ProductUpdater] Валідація провалена. Сповіщення адміністратору у мессенджер.");
        }
    }
}