using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8
{
    public abstract class BaseEntityUpdater
    {
        public void UpdateEntity()
        {
            var entity = GetEntity();
            if (!Validate(entity))
            {
                OnValidationFailed();
                Console.WriteLine("[BaseEntityUpdater] Валідація не пройдена.");
                return;
            }

            var saveRequest = CreateSaveRequest(entity);
            var response = SendSaveRequest(saveRequest);
            Console.WriteLine("[BaseEntityUpdater] Відповідь на запит збереження:");
            Console.WriteLine(FormatResponse(response));
        }

        protected abstract object GetEntity();
        protected abstract bool Validate(object entity);
        protected abstract object CreateSaveRequest(object entity);
        protected abstract object SendSaveRequest(object saveRequest);
        protected virtual string FormatResponse(object response)
        {
            return $"Код: 200, Статус: Успіх";
        }

        protected virtual void OnValidationFailed()
        {
            Console.WriteLine("[BaseEntityUpdater] Валідація провалена. Дія за замовчуванням.");
        }
    }

}