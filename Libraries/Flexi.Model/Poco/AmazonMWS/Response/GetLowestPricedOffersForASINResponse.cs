using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{

    [XmlRoot(ElementName = "GetLowestPricedOffersForASINResponse", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class GetLowestPricedOffersForASINResponse
    {
        [XmlElement(ElementName = "GetLowestPricedOffersForASINResult", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public GetLowestPricedOffersForASINResult GetLowestPricedOffersForASINResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "GetLowestPricedOffersForASINResult", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class GetLowestPricedOffersForASINResult
    {
        [XmlElement(ElementName = "Identifier", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Identifier Identifier { get; set; }
        [XmlElement(ElementName = "Summary", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Summary Summary { get; set; }
        [XmlElement(ElementName = "Offers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Offers Offers { get; set; }
        [XmlAttribute(AttributeName = "MarketplaceID")]
        public string MarketplaceID { get; set; }
        [XmlAttribute(AttributeName = "ItemCondition")]
        public string ItemCondition { get; set; }
        [XmlAttribute(AttributeName = "ASIN")]
        public string ASIN { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
    }

    [XmlRoot(ElementName = "Identifier", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Identifier
    {
        [XmlElement(ElementName = "MarketplaceId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string MarketplaceId { get; set; }
        [XmlElement(ElementName = "ASIN", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string ASIN { get; set; }
        [XmlElement(ElementName = "ItemCondition", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string ItemCondition { get; set; }
        [XmlElement(ElementName = "TimeOfOfferChange", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public DateTime? TimeOfOfferChange { get; set; }
    }

    [XmlRoot(ElementName = "OfferCount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class OfferCount
    {
        [XmlAttribute(AttributeName = "condition")]
        public string Condition { get; set; }
        [XmlAttribute(AttributeName = "fulfillmentChannel")]
        public string FulfillmentChannel { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NumberOfOffers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class NumberOfOffers
    {
        [XmlElement(ElementName = "OfferCount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public List<OfferCount> OfferCount { get; set; }
    }

    [XmlRoot(ElementName = "LandedPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class LandedPrice
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public decimal? Amount { get; set; }
    }

    //[XmlRoot(ElementName = "ListingPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //public class ListingPrice
    //{
    //    [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string CurrencyCode { get; set; }
    //    [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string Amount { get; set; }
    //}

    [XmlRoot(ElementName = "Shipping", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Shipping
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public decimal? Amount { get; set; }
    }

    [XmlRoot(ElementName = "LowestPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class LowestPrice
    {
        [XmlElement(ElementName = "LandedPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public LandedPrice LandedPrice { get; set; }
        [XmlElement(ElementName = "ListingPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ListingPrice ListingPrice { get; set; }
        [XmlElement(ElementName = "Shipping", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Shipping Shipping { get; set; }
        [XmlAttribute(AttributeName = "condition")]
        public string Condition { get; set; }
        [XmlAttribute(AttributeName = "fulfillmentChannel")]
        public string FulfillmentChannel { get; set; }
    }

    [XmlRoot(ElementName = "LowestPrices", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class LowestPrices
    {
        [XmlElement(ElementName = "LowestPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public List<LowestPrice> LowestPrice { get; set; }
    }

    [XmlRoot(ElementName = "BuyBoxPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class BuyBoxPrice
    {
        [XmlElement(ElementName = "LandedPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public LandedPrice LandedPrice { get; set; }
        [XmlElement(ElementName = "ListingPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ListingPrice ListingPrice { get; set; }
        [XmlElement(ElementName = "Shipping", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Shipping Shipping { get; set; }
        [XmlAttribute(AttributeName = "condition")]
        public string Condition { get; set; }
    }

    [XmlRoot(ElementName = "BuyBoxPrices", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class BuyBoxPrices
    {
        [XmlElement(ElementName = "BuyBoxPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public BuyBoxPrice BuyBoxPrice { get; set; }
    }

    [XmlRoot(ElementName = "BuyBoxEligibleOffers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class BuyBoxEligibleOffers
    {
        [XmlElement(ElementName = "OfferCount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public List<OfferCount> OfferCount { get; set; }
    }

    [XmlRoot(ElementName = "Summary", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Summary
    {
        [XmlElement(ElementName = "TotalOfferCount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public int TotalOfferCount { get; set; }
        [XmlElement(ElementName = "NumberOfOffers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public NumberOfOffers NumberOfOffers { get; set; }
        [XmlElement(ElementName = "LowestPrices", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public LowestPrices LowestPrices { get; set; }
        [XmlElement(ElementName = "BuyBoxPrices", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public BuyBoxPrices BuyBoxPrices { get; set; }
        [XmlElement(ElementName = "BuyBoxEligibleOffers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public BuyBoxEligibleOffers BuyBoxEligibleOffers { get; set; }
    }

    [XmlRoot(ElementName = "SellerFeedbackRating", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class SellerFeedbackRating
    {
        [XmlElement(ElementName = "SellerPositiveFeedbackRating", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string SellerPositiveFeedbackRating { get; set; }
        [XmlElement(ElementName = "FeedbackCount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public int FeedbackCount { get; set; }
    }

    [XmlRoot(ElementName = "ShippingTime", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class ShippingTime
    {
        [XmlAttribute(AttributeName = "minimumHours")]
        public string MinimumHours { get; set; }
        [XmlAttribute(AttributeName = "maximumHours")]
        public string MaximumHours { get; set; }
        [XmlAttribute(AttributeName = "availabilityType")]
        public string AvailabilityType { get; set; }
    }

    [XmlRoot(ElementName = "Offer", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Offer
    {
        [XmlElement(ElementName = "SubCondition", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string SubCondition { get; set; }
        [XmlElement(ElementName = "SellerFeedbackRating", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public SellerFeedbackRating SellerFeedbackRating { get; set; }
        [XmlElement(ElementName = "ShippingTime", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ShippingTime ShippingTime { get; set; }
        [XmlElement(ElementName = "ListingPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ListingPrice ListingPrice { get; set; }
        [XmlElement(ElementName = "Shipping", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Shipping Shipping { get; set; }
        public bool IsFulfilledByAmazon { get; set; }
        public bool IsBuyBoxWinner { get; set; }
        public bool IsFeaturedMerchant { get; set; }
        [XmlElement(ElementName = "ShipsFrom", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ShipsFrom ShipsFrom { get; set; }
    }

    [XmlRoot(ElementName = "ShipsFrom", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class ShipsFrom
    {
        [XmlElement(ElementName = "State", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string State { get; set; }
        [XmlElement(ElementName = "Country", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string Country { get; set; }
    }

    [XmlRoot(ElementName = "Offers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Offers
    {
        [XmlElement(ElementName = "Offer", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public List<Offer> Offer { get; set; }
    }

    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string RequestId { get; set; }
    //}


}
