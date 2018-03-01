namespace Flexi.Model.Poco.MP
{
    public class ReviserPoco
    {
        public string ItemId { get; set; }
        public string Asin { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public double? FulfillmentLagTime { get; set; } // only for walmart
    }
}
