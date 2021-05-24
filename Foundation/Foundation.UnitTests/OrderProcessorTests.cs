using Foundation.Basic_Topics.Constructor;
using Foundation.Basic_Topics.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Foundation.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION
       [TestMethod]
       [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new ShipmentOrder
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }
    }

    [TestMethod]
    public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new ShipmentOrder();

        orderProcessor.Process(order);

        Assert.IsTrue(order.IsShipped);
        Assert.AreEqual(1, order.Shipment.Cost);
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(ShipmentOrder order)
        {
            return 1;
        }
    }
}
