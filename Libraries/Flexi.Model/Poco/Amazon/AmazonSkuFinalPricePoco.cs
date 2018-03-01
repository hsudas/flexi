using Dapper;
using System;

namespace Flexi.Model.Poco.Amazon
{
    public class AmazonSkuFinalPricePoco
    {

        public long Id { get; set; }
        public string Vendor { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public long Ranking { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Asin { get; set; }
        public string ProductTypeName { get; set; }
        public string MrcAdditionalAmount { get; set; }
        public int Oversize { get; set; }
        public decimal? Cost { get; set; }
        public decimal? FbaFees { get; set; }
        public decimal? TotalFee { get; set; }
        public decimal PlacementFee { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal? BuyBoxPrice { get; set; }
        public decimal? LowestFba { get; set; }
        public decimal? LowestMrc { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? PriceUpdatedDate { get; set; }
        public DateTime? MyPriceUpdate { get; set; }
        public int? MyOfferPlacement { get; set; }
        public int? MyIsBuyBoxWinner { get; set; }
        public decimal? MyListingPrice { get; set; }
        public string BbSellerId { get; set; }
        public string PriceProfile { get; set; }
        public decimal StaticPrice { get; set; }
        public bool AutoPricing { get; set; }
        public decimal MinPriceMultiplier { get; set; }
        public decimal MaxRate { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPriceTolerancerate { get; set; }
        public decimal LowestPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? Cubic { get; set; }




    }
}

