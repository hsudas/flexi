namespace Flexi.Model.Poco.Walmart.Response3
{

    public class OrderShipmentResponse
    {
        public string PurchaseOrderId { get; set; }
        public string CustomerOrderId { get; set; }
        public string CustomerEmailId { get; set; }
        public long OrderDate { get; set; }
        public ShippingInfo ShippingInfo { get; set; }
        public OrderLines OrderLines { get; set; }
    }

    public class RootObject
    {
        public Order Order { get; set; }
    }


    public class TaxAmount
    {
        public string Currency { get; set; }
        public double Amount { get; set; }
    }

    public class Tax
    {
        public string TaxName { get; set; }
        public TaxAmount TaxAmount { get; set; }
    }

    public class CarrierName
    {
        public object OtherCarrier { get; set; }
        public string Carrier { get; set; }
    }

    public class TrackingInfo
    {
        public long ShipDateTime { get; set; }
        public CarrierName CarrierName { get; set; }
        public string MethodCode { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingURL { get; set; }
    }


}
