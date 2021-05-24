using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Interfaces
{
    public class ShipmentOrder
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null;  }
        }
    }
}
