using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class SkuSalesData
    {
        public SalesRank sales_rank { get; set; }
        public UnitsSold units_sold { get; set; }
        public List<MyBestOffer> my_best_offer { get; set; }
        public List<BestMarketplaceOffer> best_marketplace_offer { get; set; }
    }

    public class SalesRank
    {
        public int level_0 { get; set; }
        public string last_update { get; set; }
    }

    public class UnitsSold
    {
        public int last_30_days { get; set; }
        public string last_update { get; set; }
    }

    public class MyBestOffer
    {
        public object shipping_method { get; set; }
        public decimal item_price { get; set; }
        public decimal shipping_price { get; set; }
        public string last_update { get; set; }
    }

    public class BestMarketplaceOffer
    {
        public object shipping_method { get; set; }
        public decimal item_price { get; set; }
        public decimal shipping_price { get; set; }
        public string last_update { get; set; }
    }

}
