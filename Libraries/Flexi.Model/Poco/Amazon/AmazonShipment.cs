using System;
using System.Collections.Generic;

namespace Flexi.Model.Poco.Amazon
{
    public class AmazonShipment
    {
        public string FulfillmentCenterId { get; set; }
        public string FulfillmentShipmentStatus { get; set; }
        public string FulfillmentOrderStatus { get; set; }
        public DateTime ShippingDateTime { get; set; }
        public List<FulFillmentShipmentPackage> FulFillmentShipmentPackage { get; set; }
    }

    public class FulFillmentShipmentPackage
    {
        public string AmazonShipmentId { get; set; }
        public string FulfillmentShipmentStatus { get; set; }
        public string CarrierCode { get; set; }
        public DateTime EstimatedArrivalDate { get; set; }
        public int PackageNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string FulfillmentOrderItemId { get; set; }
    }
}
