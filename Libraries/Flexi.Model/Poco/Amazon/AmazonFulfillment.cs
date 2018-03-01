using System;
using System.Collections.Generic;

namespace Flexi.Model.Poco.Amazon
{
    public class FulfillmentOrderItem
    {
        /// <A>
        /// The Seller SKU of the item.
        /// </summary>
        public string SellerSKU { get; set; }
        /// <summary>
        /// The fulfillment order item identifier that you created and submitted with the CreateFulfillmentOrder operation.
        /// </summary>
        public string SellerFulfillmentOrderItemId { get; set; }

        public int Quantity { get; set; }

        public int? WalmartLineNumber { get; set; }

        public string ForderId { get; set; }

    }
    public class FulfillmentOrder
    {
        /// <summary>
        /// optional
        /// The marketplace the order is placed against.
        /// </summary>
        public string MarketplaceId { get; set; }
        /// <summary>
        /// required
        /// A fulfillment order identifier that you create to track your fulfillment order. The SellerFulfillmentOrderId must be unique for each fulfillment order that you create. If your system already creates unique order identifiers, then these might be good values to use for your SellerFulfillmentOrderId values.
        /// Maximum: 40 characters
        /// </summary>
        public string SellerFulfillmentOrderId { get; set; }
        /// <summary>
        /// optional
        /// Specifies whether the fulfillment order should ship now or have an order hold put on it.
        /// -----------------
        /// FulfillmentAction values:
        /// Ship - The fulfillment order ships now.
        /// Hold - An order hold is put on the fulfillment order.
        /// Default: Ship
        /// </summary>
        public string FulfillmentAction { get; set; }
        /// <summary>
        /// required
        /// A fulfillment order identifier that you create. This value displays as the order identifier in recipient-facing materials such as the outbound shipment packing slip. The value of DisplayableOrderId should match the order identifier that you provide to your customer. You can use the SellerFulfillmentOrderId for this value or you can specify an alternate value if you want your customer to reference an alternate order identifier.
        /// ---------------
        /// An alpha-numeric or ISO 8859-1 compliant string from one to 40 characters in length. Cannot contain two spaces in a row. Leading and trailing white space is removed.
        /// </summary>
        public string DisplayableOrderId { get; set; }
        /// <summary>
        /// requirement
        /// The date of your fulfillment order. Displays as the order date in customer-facing materials such as the outbound shipment packing slip.	
        /// -------------------
        /// In ISO 8601 date time format .
        /// </summary>
        public DateTime DisplayableOrderDateTime { get; set; }
        /// <summary>
        /// required
        /// Order-specific text that appears in customer-facing materials such as the outbound shipment packing slip.	
        /// ------------------
        /// Maximum: 1000 characters
        /// </summary>
        public string DisplayableOrderComment { get; set; }

        /// <summary>
        /// required
        /// The shipping method for your fulfillment order.
        /// --------------
        /// ShippingSpeedCategory values:
        /// Standard - Standard shipping method.
        /// Expedited - Expedited shipping method.
        /// Priority - Priority shipping method.
        /// ScheduledDelivery - Scheduled Delivery shipping method. Scheduled Delivery is available only in Japan (JP). For more information, see Scheduled Delivery.
        /// Note: Shipping method service level agreements vary by marketplace. See the Amazon Seller Central website in your marketplace for shipping method service level agreements and fulfillment fees.
        /// </summary>
        public string ShippingSpeedCategory { get; set; }
        /// <summary>
        /// required
        /// Recipient's name.
        /// --------------
        /// Maximum: 50 characters
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// required
        /// Recipient's street address information
        /// ------------------
        /// Maximum: 60 characters
        /// </summary>
        public string AddressLine1 { get; set; }
        /// <summary>
        /// optional
        /// Additional street address information, if required.
        /// --------------
        /// Maximum: 60 characters
        /// </summary>
        public string AddressLine2 { get; set; }
        /// <summary>
        /// optional
        /// Additional street address information, if required.
        /// --------------
        /// Maximum: 60 characters
        /// </summary>
        public string AddressLine3 { get; set; }
        /// <summary>
        /// optional
        /// Recipient's district or county.
        /// ----------------------
        /// Maximum: 150 characters
        /// </summary>
        public string DistrictOrCounty { get; set; }

        /// <summary>
        /// required
        /// Recipient's city.
        /// -------------------
        /// Maximum: 50 characters
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// required
        /// Recipient's state or province code.
        /// ----------------------
        /// Maximum: 150 characters
        /// </summary>
        public string StateOrProvinceCode { get; set; }
        /// <summary>
        /// required
        /// Recipient's two-digit country code.
        /// ------------------
        /// In ISO 3166-1 alpha-2 format country code.
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// required
        /// The postal code (required for shipments to the U.S.).
        /// -----------------
        /// Maximum: 20 characters
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// optional
        /// Recipient's phone number.
        /// ------------------
        /// Maximum: 20 characters
        /// </summary>
        public string PhoneNumber { get; set; }

        public List<FulfillmentOrderItem> Items { get; set; }

        public string FulfillmentOrderStatus { get; set; }

        public DateTime? StatusUpdatedDateTime { get; set; }

        public List<FulfillmentOrderShipments> Shipments { get; set; }

        public DateTime? CheckDate { get; set; }

        public string ForderId { get; set; }

        public string EbayOrderId { get; set; }
        public string WOrderId { get; set; }

    }

    public class FulfillmentOrderShipments
    {
        /// <summary>
        /// max 40 character
        /// </summary>
        public string FOrderId { get; set; }
        /// <summary>
        /// max 20 character
        /// </summary>
        public string AmazonShipmentId { get; set; }

        public string FulfillmentCenterId { get; set; }

        public string FulfillmentShipmentStatus { get; set; }
        public string ShippingSpeedCategory { get; set; }

        public DateTime? ShippingDateTime { get; set; }

        public int PackageNumber { get; set; }

        public string CarrierCode { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime? EstimatedArrivalDateTime { get; set; }
        public string orderitem { get; set; }
    }
}
