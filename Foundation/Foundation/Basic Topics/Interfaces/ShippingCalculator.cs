using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Interfaces
{
    public interface IShippingCalculator
    {
        float CalculateShipping(ShipmentOrder order);
    }
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(ShipmentOrder order)
        {
            if(order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            return 0;
        }

    }
}
