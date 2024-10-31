using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public class DeliveryContext
    {
        private IDeliveryStrategy _deliveryStrategy;

        public DeliveryContext(IDeliveryStrategy deliveryStrategy)
        {
            _deliveryStrategy = deliveryStrategy;
        }

        public void SetDeliveryStrategy(IDeliveryStrategy deliveryStrategy)
        {
            _deliveryStrategy = deliveryStrategy;
        }

        public decimal ExecuteStrategy(decimal orderAmount)
        {
            Console.WriteLine("[DeliveryContext] Розрахунок вартості доставки:");
            return _deliveryStrategy.CalculateDeliveryCost(orderAmount);
        }
    }
}