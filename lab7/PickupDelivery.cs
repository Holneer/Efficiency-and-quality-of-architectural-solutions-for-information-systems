using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public class PickupDelivery : IDeliveryStrategy
    {
        public decimal CalculateDeliveryCost(decimal orderAmount)
        {
            Console.WriteLine("[PickupDelivery] Самовивіз: Вартість доставки становить 0.");
            return 0;
        }
    }
}