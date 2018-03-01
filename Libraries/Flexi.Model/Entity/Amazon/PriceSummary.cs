using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Flexi.Model.Entity.Amazon
{
    [Table("pricesummary")]
    [DebuggerDisplay("Asin:{Asin}, MessageId:{MessageId}, LowestLandedPriceAmazon: {LowestLandedPriceAmazon}")]
    public class PriceSummary
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("messageid")]
        public string MessageId { get; set; }
        [Column("timeofofferchange")]
        public DateTime? TimeOfOfferChange { get; set; }
        [Column("offercount")]
        public int OfferCount { get; set; }
        [Column("lowestlandedpricemerchant")]
        public decimal LowestLandedPriceMerchant { get; set; }
        [Column("lowestlandedpricecurrencymerchant")]
        public string LowestLandedPriceCurrencyMerchant { get; set; }
        [Column("lowestlistingpricemerchant")]
        public decimal LowestListingPriceMerchant { get; set; }
        [Column("lowestlistingpricecurrencymerchant")]
        public string LowestListingPriceCurrencyMerchant { get; set; }
        [Column("lowestpriceshippingmerchant")]
        public decimal LowestPriceShippingMerchant { get; set; }
        [Column("lowestpriceshippingcurrencymerchant")]
        public string LowestPriceShippingCurrencyMerchant { get; set; }
        [Column("lowestlandedpriceamazon")]
        public decimal LowestLandedPriceAmazon { get; set; }
        [Column("lowestlandedpricecurrencyamazon")]
        public string LowestLandedPriceCurrencyAmazon { get; set; }
        [Column("lowestlistingpriceamazon")]
        public decimal LowestListingPriceAmazon { get; set; }
        [Column("lowestlistingpricecurrencyamazon")]
        public string LowestListingPriceCurrencyAmazon { get; set; }
        [Column("lowestpriceshippingamazon")]
        public decimal LowestPriceShippingAmazon { get; set; }
        [Column("lowestpriceshippingcurrencyamazon")]
        public string LowestPriceShippingCurrencyAmazon { get; set; }
        [Column("buyboxlandedprice")]
        public decimal? BuyBoxLandedPrice { get; set; }
        [Column("buyboxlandedpricecurrency")]
        public string BuyBoxLandedPriceCurrency { get; set; }
        [Column("buyboxlistingprice")]
        public decimal? BuyBoxListingPrice { get; set; }
        [Column("buyboxlistingpricecurrency")]
        public string BuyBoxListingPriceCurrency { get; set; }
        [Column("buyboxpriceshipping")]
        public decimal? BuyBoxPriceShipping { get; set; }
        [Column("buyboxpriceshippingcurrency")]
        public string BuyBoxPriceShippingCurrency { get; set; }
        [Column("productcategory")]
        public string ProductCategory { get; set; }
        [Column("ranking")]
        public int Ranking { get; set; }
        [Column("buyboxeligiblefbaoffercount")]
        public int BuyboxEligibleFbaOfferCount { get; set; }
        [Column("buyboxeligiblemrcoffercount")]
        public int BuyboxEligibleMrcOfferCount { get; set; }
        [Column("pricingstatus")]
        public string PricingStatus { get; set; }
        [Column("createapi")]
        public string CreateApi { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [NotMapped]
        public List<PriceOffer> PriceOfferList { get; set; }

    }
}
