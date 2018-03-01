namespace Flexi.Model.Poco.Amazon
{
    public class FulfillmentPreviewRequestPoco
    {
        public string SellerSKU { get; set; }
        public decimal Quantity { get; set; }
        public string SellerFulfillmentOrderItemId { get; set; }
    }
}
