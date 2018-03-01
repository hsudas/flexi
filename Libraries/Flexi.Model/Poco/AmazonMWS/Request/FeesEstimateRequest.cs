namespace Flexi.Model.Poco.AmazonMWS.Request
{
    public class FeesEstimateRequest
    {
        public string MarketPlaceId { get; set; }
        public string IdType { get; set; }
        public string IdValue { get; set; }
        public PriceToEstimateFees PriceToEstimateFees { get; set; }
        public string Identifier { get; set; }
        public bool IsAmazonFulfilled { get; set; }
    }

    public class PriceToEstimateFees
    {
        public MoneyType ListingPrice { get; set; }
        public MoneyType Shipping { get; set; }
        public Points Points { get; set; }
    }


}
