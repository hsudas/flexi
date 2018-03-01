using System.Collections.Generic;

namespace Flexi.Model.Poco.Walmart.Request3
{
    public class OrderShipmentRequest
    {
        public OrderShipment orderShipment { get; set; }
    }

    public class OrderShipment
    {
        public OrderLines orderLines { get; set; }
    }

    public class StatusQuantity
    {
        public string unitOfMeasurement { get; set; }
        public string amount { get; set; }
    }

    public class CarrierName
    {
        public object otherCarrier { get; set; }
        public string carrier { get; set; }
    }

    public class TrackingInfo
    {
        public long shipDateTime { get; set; }
        public CarrierName carrierName { get; set; }
        public string methodCode { get; set; }
        public string trackingNumber { get; set; }
        public string trackingURL { get; set; }
    }

    public class OrderLineStatu
    {
        public string status { get; set; }
        public StatusQuantity statusQuantity { get; set; }
        public TrackingInfo trackingInfo { get; set; }
        public string cancellationReason { get; set; } // only for cancel order lines
    }

    public class OrderLineStatuses
    {
        public List<OrderLineStatu> orderLineStatus { get; set; }
    }

    public class OrderLine
    {
        public string lineNumber { get; set; }
        public OrderLineStatuses orderLineStatuses { get; set; }
        public Refunds refunds { get; set; } // only for refund order lines
    }

    public class OrderLines
    {
        public List<OrderLine> orderLine { get; set; }
    }
}
