using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("priceofferlog")]
    public class PriceOfferLog
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("sellerid")]
        public string SellerId { get; set; }
        [Column("subcondition")]
        public string SubCondition { get; set; }
        [Column("sellerfeedbackcount")]
        public int SellerFeedbackCount { get; set; }
        [Column("sellerpositivefeedback")]
        public int SellerPositiveFeedback { get; set; }
        [Column("shippingminhour")]
        public int ShippingMinHour { get; set; }
        [Column("shippingmaxhour")]
        public int ShippingMaxHour { get; set; }
        [Column("shippingavailabilitytype")]
        public string ShippingAvailabilityType { get; set; }
        [Column("shippingavailabledate")]
        public DateTime? ShippingAvailableDate { get; set; }
        [Column("listingprice")]
        public decimal ListingPrice { get; set; }
        [Column("listingpricecurrency")]
        public string ListingPriceCurrency { get; set; }
        [Column("shippingamount")]
        public decimal ShippingAmount { get; set; }
        [Column("shippingamountcurrency")]
        public string ShippingAmountCurrency { get; set; }
        [Column("shipsfromstate")]
        public string ShipsFromState { get; set; }
        [Column("shipsfromcountry")]
        public string ShipsFromCountry { get; set; }
        [Column("isfulfilledbyamazon")]
        public bool IsFulfilledByAmazon { get; set; }
        [Column("isbuyboxwinner")]
        public bool IsBuyBoxWinner { get; set; }
        [Column("isfeaturedmerchant")]
        public bool IsFeaturedMerchant { get; set; }
        [Column("shipsdomestically")]
        public bool ShipsDomestically { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }

    }
}
