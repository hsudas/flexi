using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.Amazon
{
    [Serializable, XmlRoot("Notification")]
    public class NotificationFulfillmentResp
    {
        public NotificationMetaData NotificationMetaData { get; set; }
        public NotificationPayload NotificationPayload { get; set; }
    }

    public class NotificationPayload
    {
        public FulfillmentOrderStatusNotification FulfillmentOrderStatusNotification { get; set; }
    }

    public class FulfillmentOrderStatusNotification
    {
        public string EventType { get; set; }
        public string StatusUpdatedDateTime { get; set; }
        public string SellerFulfillmentOrderId { get; set; }
        public string FulfillmentOrderStatus { get; set; }
        public FulfillmentShipment FulfillmentShipment { get; set; }
    }

    public class NotificationMetaData
    {
        public string FulfillmentShipmentStatus { get; set; }
        public string AmazonShipmentId { get; set; }
        public string EstimatedArrivalDateTime { get; set; }
        public string NotificationType { get; set; }
        public string PayloadVersion { get; set; }
        public string UniqueId { get; set; }
        public string PublishTime { get; set; }
        public string SellerId { get; set; }
        public string MarketplaceId { get; set; }
    }

    public class FulfillmentShipment
    {
        public string FulfillmentShipmentStatus { get; set; }
        public string AmazonShipmentId { get; set; }
        public DateTime EstimatedArrivalDateTime { get; set; }
        public FulfillmentShipmentPackageList FulfillmentShipmentPackageList { get; set; }
    }

    //[XmlRoot(ElementName = "FulfillmentShipmentPackageList")]
    public class FulfillmentShipmentPackageList
    {
        [XmlElement(ElementName = "FulfillmentShipmentPackage")]
        public List<FulfillmentShipmentPackage> FulfillmentShipmentPackage { get; set; }
        //public FulfillmentShipmentPackage FulfillmentShipmentPackage { get; set; }
    }

    public class FulfillmentShipmentPackage
    {
        public int PackageNumber { get; set; }
        public string CarrierCode { get; set; }
        public string TrackingNumber { get; set; }
    }
}
