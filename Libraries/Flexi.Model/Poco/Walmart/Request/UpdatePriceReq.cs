using Flexi.Model.Enum.Walmart;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.Walmart.Request
{

    [XmlRoot(ElementName = "PriceFeed")]
    public class PriceFeed
    {
        [XmlElement(ElementName = "PriceHeader")]
        public PriceHeader PriceHeader { get; set; }
        [XmlElement(ElementName = "Price")]
        public List<Price> Price { get; set; }
        [XmlAttribute(AttributeName = "gmp", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gmp { get; set; }
    }

    [XmlRoot(ElementName = "Price")]
    public class Price
    {
        [XmlElement(ElementName = "itemIdentifier")]
        public ItemIdentifier ItemIdentifier { get; set; }
        [XmlElement(ElementName = "pricingList")]
        public PricingList PricingList { get; set; }
    }

    [XmlRoot(ElementName = "PriceHeader")]
    public class PriceHeader
    {
        [XmlElement(ElementName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "itemIdentifier")]
    public class ItemIdentifier
    {
        [XmlElement(ElementName = "sku")]
        public string Sku { get; set; }
    }

    [XmlRoot(ElementName = "value")]
    public class Value
    {
        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }
        [XmlAttribute(AttributeName = "amount")]
        public decimal Amount { get; set; }
    }

    [XmlRoot(ElementName = "currentPrice")]
    public class CurrentPrice
    {
        [XmlElement(ElementName = "value")]
        public Value Value { get; set; }
    }

    [XmlRoot(ElementName = "comparisonPrice")]
    public class ComparisonPrice
    {
        [XmlElement(ElementName = "value")]
        public Value Value { get; set; }
    }

    [XmlRoot(ElementName = "priceDisplayCode")]
    public class PriceDisplayCode
    {
        [XmlAttribute(AttributeName = "submapType")]
        public SubmapType SubmapType { get; set; }
    }

    [XmlRoot(ElementName = "pricing")]
    public class Pricing
    {
        [XmlElement(ElementName = "currentPrice")]
        public CurrentPrice CurrentPrice { get; set; }
        [XmlElement(ElementName = "currentPriceType")]
        public PriceType CurrentPriceType { get; set; }
        [XmlElement(ElementName = "comparisonPrice")]
        public ComparisonPrice ComparisonPrice { get; set; }
        [XmlElement(ElementName = "priceDisplayCode")]
        public PriceDisplayCode PriceDisplayCode { get; set; }
    }

    [XmlRoot(ElementName = "pricingList")]
    public class PricingList
    {
        [XmlElement(ElementName = "pricing")]
        public Pricing Pricing { get; set; }
    }


}
