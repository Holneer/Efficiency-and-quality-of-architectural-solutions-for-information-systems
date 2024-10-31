using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public class ExternalDelivery : IDeliveryStrategy
    {
        public decimal CalculateDeliveryCost(decimal orderAmount)
        {
            Console.WriteLine("[ExternalDelivery] Доставка зовнішньою службою: Вартість доставки залежить від замовлення.");
            return orderAmount * 0.5m;
        }
    }
}