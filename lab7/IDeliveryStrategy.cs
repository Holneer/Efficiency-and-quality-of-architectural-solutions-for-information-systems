using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7
{
    public interface IDeliveryStrategy
    {
        decimal CalculateDeliveryCost(decimal orderAmount);
    }
}