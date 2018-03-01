namespace Flexi.Model.Poco.AmazonMWS.Request
{
    public class GetLowestPricedOffersForASINRequest
    {
        public string MarketplaceId { get; set; }
        public string ASIN { get; set; }
        public string ItemCondition { get; set; }
    }
}
