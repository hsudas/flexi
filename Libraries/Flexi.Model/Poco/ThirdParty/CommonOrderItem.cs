using System;

namespace Flexi.Model.Poco.ThirdParty
{
    public class CommonOrderItem
    {
        public string Asin { get; set; }
        public string Sku { get; set; }
        public string OrderId { get; set; }
        public string Title { get; set; }
        public string MP { get; set; }
        public int Unit { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal Price { get; set; }
        public string TrackingId { get; set; }
        public string Carrier { get; set; }
        public string ServiceType { get; set; }
        public int ShippedQuantity { get; set; }
        public decimal ShippingCharge { get; set; }
        public string LabelSource { get; set; }
        public string LabelFormat { get; set; }
        public string PackingSlip { get; set; }
        public string Note { get; set; }
        public DateTime? LabelDate { get; set; }
    }
}
