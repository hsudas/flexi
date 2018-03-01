namespace Flexi.Model.Poco.Walmart
{
    public class PriceQuantityPoco
    {
        public string Asin { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public int? FulfillmentLagTime { get; set; }
    }
}
