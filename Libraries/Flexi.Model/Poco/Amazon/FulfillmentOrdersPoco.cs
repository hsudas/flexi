using System;

namespace Flexi.Model.Poco.Amazon
{
    public class FulfillmentOrdersPoco
    {
        public string ShippingSpeedCategory { get; set; }
        public DateTime StatusUpdatedDateTime { get; set; }
        public string NotificationEmail { get; set; }
        public string SellerFulfillmentOrderId { get; set; }
        public DestinationAddressPoco DestinationAddress { get; set; }
        public DateTime DisplayableOrderDateTime { get; set; }
        public string FulfillmentPolicy { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public string DisplayableOrderId { get; set; }
        public string DisplayableOrderComment { get; set; }
        public string FulfillmentOrderStatus { get; set; }
    }

    public class DestinationAddressPoco
    {
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string StateOrProvinceCode { get; set; }
        public string City { get; set; }
    }
}
