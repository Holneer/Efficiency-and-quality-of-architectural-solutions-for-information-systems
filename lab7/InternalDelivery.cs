using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public class InternalDelivery : IDeliveryStrategy
    {
        public decimal CalculateDeliveryCost(decimal orderAmount)
        {
            Console.WriteLine("[InternalDelivery] Доставка власною службою: Вартість доставки залежить від замовлення.");
            return orderAmount * 0.3m;
        }
    }
}