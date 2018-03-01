﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.Amazon.SQS.Pricing
{
    [XmlRoot(ElementName = "Notification")]
    public class Notification
    {
        [XmlElement(ElementName = "NotificationMetaData")]
        public NotificationMetaData NotificationMetaData { get; set; }
        [XmlElement(ElementName = "NotificationPayload")]
        public NotificationPayload NotificationPayload { get; set; }
    }

    [XmlRoot(ElementName = "NotificationPayload")]
    public class NotificationPayload
    {
        [XmlElement(ElementName = "AnyOfferChangedNotification")]
        public AnyOfferChangedNotification AnyOfferChangedNotification { get; set; }
    }

    [XmlRoot(ElementName = "AnyOfferChangedNotification")]
    public class AnyOfferChangedNotification
    {
        [XmlElement(ElementName = "OfferChangeTrigger")]
        public OfferChangeTrigger OfferChangeTrigger { get; set; }
        [XmlElement(ElementName = "Summary")]
        public Summary Summary { get; set; }
        [XmlElement(ElementName = "Offers")]
        public Offers Offers { get; set; }
    }

    [XmlRoot(ElementName = "OfferChangeTrigger")]
    public class OfferChangeTrigger
    {
        [XmlElement(ElementName = "MarketplaceId")]
        public string MarketplaceId { get; set; }
        [XmlElement(ElementName = "ASIN")]
        public string ASIN { get; set; }
        [XmlElement(ElementName = "ItemCondition")]
        public string ItemCondition { get; set; }
        [XmlElement(ElementName = "TimeOfOfferChange")]
        public string TimeOfOfferChange { get; set; }//DateTime?
    }

    [XmlRoot(ElementName = "OfferCount")]
    public class OfferCount
    {
        [XmlAttribute(AttributeName = "condition")]
        public string Condition { get; set; }
        [XmlAttribute(AttributeName = "fulfillmentChannel")]
        public string FulfillmentChannel { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NumberOfOffers")]
    public class NumberOfOffers
    {
        [XmlElement(ElementName = "OfferCount")]
        public List<OfferCount> OfferCount { get; set; }
    }

    [XmlRoot(ElementName = "LandedPrice")]
    public class LandedPrice
    {
        [XmlElement(ElementName = "Amount")]
        public decimal Amount { get; set; }
        [XmlElement(ElementName = "CurrencyCode")]
        public string CurrencyCode { get; set; }
    }

    [XmlRoot(ElementName = "ListingPrice")]
    public class ListingPrice
    {
        [XmlElement(ElementName = "Amount")]
        public decimal Amount { get; set; }
        [XmlElement(ElementName = "CurrencyCode")]
        public string CurrencyCode { get; set; }
    }

    [XmlRoot(ElementName = "Shipping")]
    public class Shipping
    {
        [XmlElement(ElementName = "Amount")]
        public decimal Amount { get; set; }
        [XmlElement(ElementName = "CurrencyCode")]
        public string CurrencyCode { get; set; }
    }

    [XmlRoot(ElementName = "LowestPrice")]
    public class LowestPrice
    {
        [XmlElement(ElementName = "LandedPrice")]
        public LandedPrice LandedPrice { get; set; }
        [XmlElement(ElementName = "ListingPrice")]
        public ListingPrice ListingPrice { get; set; }
        [XmlElement(ElementName = "Shipping")]
        public Shipping Shipping { get; set; }
        [XmlAttribute(AttributeName = "condition")]
        public string Condition { get; set; }
        [XmlAttribute(AttributeName = "fulfillmentChannel")]
        public string FulfillmentChannel { get; set; }
    }

    [XmlRoot(ElementName = "LowestPrices")]
    public class LowestPrices
    {
        [XmlElement(ElementName = "LowestPrice")]
        public List<LowestPrice> LowestPrice { get; set; }
    }

    [XmlRoot(ElementName = "BuyBoxPrice")]
    public class BuyBoxPrice
    {
        [XmlElement(ElementName = "LandedPrice")]
        public LandedPrice LandedPrice { get; set; }
        [XmlElement(ElementName = "ListingPrice")]
        public ListingPrice ListingPrice { get; set; }
        [XmlElement(ElementName = "Shipping")]
        public Shipping Shipping { get; set; }
        [XmlAttribute(AttributeName = "condition")]
        public string Condition { get; set; }
    }

    [XmlRoot(ElementName = "BuyBoxPrices")]
    public class BuyBoxPrices
    {
        [XmlElement(ElementName = "BuyBoxPrice")]
        public List<BuyBoxPrice> BuyBoxPrice { get; set; }
    }

    [XmlRoot(ElementName = "SalesRank")]
    public class SalesRank
    {
        [XmlElement(ElementName = "ProductCategoryId")]
        public string ProductCategoryId { get; set; }
        [XmlElement(ElementName = "Rank")]
        public string Rank { get; set; }
    }

    [XmlRoot(ElementName = "SalesRankings")]
    public class SalesRankings
    {
        [XmlElement(ElementName = "SalesRank")]
        public List<SalesRank> SalesRank { get; set; }
    }

    [XmlRoot(ElementName = "BuyBoxEligibleOffers")]
    public class BuyBoxEligibleOffers
    {
        [XmlElement(ElementName = "OfferCount")]
        public List<OfferCount> OfferCount { get; set; }
    }

    [XmlRoot(ElementName = "Summary")]
    public class Summary
    {
        [XmlElement(ElementName = "NumberOfOffers")]
        public NumberOfOffers NumberOfOffers { get; set; }
        [XmlElement(ElementName = "LowestPrices")]
        public LowestPrices LowestPrices { get; set; }
        [XmlElement(ElementName = "BuyBoxPrices")]
        public BuyBoxPrices BuyBoxPrices { get; set; }
        [XmlElement(ElementName = "SalesRankings")]
        public SalesRankings SalesRankings { get; set; }
        [XmlElement(ElementName = "BuyBoxEligibleOffers")]
        public BuyBoxEligibleOffers BuyBoxEligibleOffers { get; set; }
    }

    [XmlRoot(ElementName = "SellerFeedbackRating")]
    public class SellerFeedbackRating
    {
        [XmlElement(ElementName = "SellerPositiveFeedbackRating")]
        public int SellerPositiveFeedbackRating { get; set; }
        [XmlElement(ElementName = "FeedbackCount")]
        public int FeedbackCount { get; set; }
    }

    [XmlRoot(ElementName = "ShippingTime")]
    public class ShippingTime
    {
        [XmlAttribute(AttributeName = "minimumHours")]
        public int MinimumHours { get; set; }
        [XmlAttribute(AttributeName = "maximumHours")]
        public int MaximumHours { get; set; }
        [XmlAttribute(AttributeName = "availabilityType")]
        public string AvailabilityType { get; set; }
        [XmlAttribute(AttributeName = "availableDate")]
        public string AvailableDate { get; set; }
    }

    [XmlRoot(ElementName = "Offer")]
    public class Offer
    {
        [XmlElement(ElementName = "SellerId")]
        public string SellerId { get; set; }
        [XmlElement(ElementName = "SubCondition")]
        public string SubCondition { get; set; }
        [XmlElement(ElementName = "SellerFeedbackRating")]
        public SellerFeedbackRating SellerFeedbackRating { get; set; }
        [XmlElement(ElementName = "ShippingTime")]
        public ShippingTime ShippingTime { get; set; }
        [XmlElement(ElementName = "ListingPrice")]
        public ListingPrice ListingPrice { get; set; }
        [XmlElement(ElementName = "Shipping")]
        public Shipping Shipping { get; set; }
        [XmlElement(ElementName = "IsFulfilledByAmazon")]
        public bool IsFulfilledByAmazon { get; set; }
        [XmlElement(ElementName = "IsBuyBoxWinner")]
        public bool IsBuyBoxWinner { get; set; }
        [XmlElement(ElementName = "IsFeaturedMerchant")]
        public bool IsFeaturedMerchant { get; set; }
        [XmlElement(ElementName = "ShipsDomestically")]
        public bool ShipsDomestically { get; set; }
        [XmlElement(ElementName = "ShipsFrom")]
        public ShipsFrom ShipsFrom { get; set; }
    }

    [XmlRoot(ElementName = "ShipsFrom")]
    public class ShipsFrom
    {
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "State")]
        public string State { get; set; }
    }

    [XmlRoot(ElementName = "Offers")]
    public class Offers
    {
        [XmlElement(ElementName = "Offer")]
        public List<Offer> Offer { get; set; }
    }

    public enum FulfillmentChannelType
    {
        Amazon,
        Merchant,
    }

    public enum AvailabilityType
    {
        NOW,
        FUTURE_WITHOUT_DATE,
        FUTURE_WITH_DATE,
    }

}
