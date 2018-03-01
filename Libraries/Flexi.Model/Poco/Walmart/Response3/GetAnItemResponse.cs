using System.Collections.Generic;

namespace Flexi.Model.Poco.Walmart.Response3
{
    public class GetAnItemResponse
    {
        public List<ItemResponse> ItemResponse { get; set; }
    }

    public class Price
    {
        public string currency { get; set; }
        public decimal amount { get; set; }
    }

    public class ItemResponse
    {
        public string mart { get; set; }
        public string sku { get; set; }
        public string wpid { get; set; }
        public string upc { get; set; }
        public string gtin { get; set; }
        public string productName { get; set; }
        public string productType { get; set; }
        public Price price { get; set; }
        public string publishedStatus { get; set; }
    }
}
