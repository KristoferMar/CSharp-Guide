using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(ShipmentOrder order)
        {
            if (order.IsShipped)
            {
                throw InvalidOperationException("This order is already processed");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DataTime.Today.AddDays(1);
            }
        }
    }
}
