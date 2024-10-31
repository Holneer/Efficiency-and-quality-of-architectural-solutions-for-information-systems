using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public class OrderUpdater : BaseEntityUpdater
    {
        protected override object GetEntity()
        {
            Console.WriteLine("[OrderUpdater] Отримання об'єкта Замовлення.");
            return new { Id = 1, ProductName = "Товар", Quantity = 3 };
        }

        protected override bool Validate(object entity)
        {
            Console.WriteLine("[OrderUpdater] Валідація Замовлення.");
            return true;
        }

        protected override object CreateSaveRequest(object entity)
        {
            Console.WriteLine("[OrderUpdater] Формування запиту на збереження Замовлення.");
            return new { Entity = entity };
        }

        protected override object SendSaveRequest(object saveRequest)
        {
            Console.WriteLine("[OrderUpdater] Відправлення запиту на збереження Замовлення.");
            return new { Status = "Success", Code = 200, Entity = saveRequest };
        }

        protected override string FormatResponse(object response)
        {
            Console.WriteLine("[OrderUpdater] Формування відповіді у форматі JSON для Замовлення.");
            return $"{{ \"Code\": 200, \"Status\": \"Success\", \"Entity\": {response} }}";
        }
    }
}