using System.Collections.Generic;

namespace Flexi.Model.Poco.Walmart.Response3
{
    public class WalmartOrder : IRawOrder
    {
        public Order Order { get; set; }
    }

    public class Order
    {
        public string PurchaseOrderId { get; set; }
        public string CustomerOrderId { get; set; }
        public string CustomerEmailId { get; set; }
        public long OrderDate { get; set; }
        public ShippingInfo ShippingInfo { get; set; }
        public OrderLines OrderLines { get; set; }
    }

    public class PostalAddress
    {
        public string name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string addressType { get; set; }
    }

    public class ShippingInfo
    {
        public string phone { get; set; }
        public long estimatedDeliveryDate { get; set; }
        public long estimatedShipDate { get; set; }
        public string methodCode { get; set; }
        public PostalAddress postalAddress { get; set; }
    }

    public class Item
    {
        public string productName { get; set; }
        public string sku { get; set; }
    }

    public class ChargeAmount
    {
        public string currency { get; set; }
        public decimal? amount { get; set; }
    }

    public class Charge
    {
        public string chargeType { get; set; }
        public string chargeName { get; set; }
        public ChargeAmount chargeAmount { get; set; }
        public Tax tax { get; set; }//public string tax { get; set; }
    }

    public class Charges
    {
        public List<Charge> charge { get; set; }
    }

    public class OrderLineQuantity
    {
        public string unitOfMeasurement { get; set; }
        public decimal amount { get; set; }
    }

    public class StatusQuantity
    {
        public string unitOfMeasurement { get; set; }
        public string amount { get; set; }
    }

    public class OrderLineStatu
    {
        public string status { get; set; }
        public StatusQuantity statusQuantity { get; set; }
        public string cancellationReason { get; set; }
        public TrackingInfo trackingInfo { get; set; }
    }

    //public class TrackingInfo
    //{
    //    public long shipDateTime { get; set; }
    //    public CarrierName carrierName { get; set; }
    //    public string methodCode { get; set; }
    //    public string trackingNumber { get; set; }
    //    public string trackingURL { get; set; }
    //}

    public class OrderLineStatuses
    {
        public List<OrderLineStatu> orderLineStatus { get; set; }
    }

    public class OrderLine
    {
        public int lineNumber { get; set; }
        public Item item { get; set; }
        public Charges charges { get; set; }
        public OrderLineQuantity orderLineQuantity { get; set; }
        public long statusDate { get; set; }
        public OrderLineStatuses orderLineStatuses { get; set; }
        public Refund refund { get; set; }
    }

    public class OrderLines
    {
        public List<OrderLine> orderLine { get; set; }
    }


}
