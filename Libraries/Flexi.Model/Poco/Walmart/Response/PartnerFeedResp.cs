using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.Walmart.Response
{
    [XmlRoot(ElementName = "PartnerFeedResponse", Namespace = "http://walmart.com/")]
    public class PartnerFeedResponse
    {
        [XmlElement(ElementName = "feedId", Namespace = "http://walmart.com/")]
        public string FeedId { get; set; }
        [XmlElement(ElementName = "feedStatus", Namespace = "http://walmart.com/")]
        public string FeedStatus { get; set; }
        [XmlElement(ElementName = "ingestionErrors", Namespace = "http://walmart.com/")]
        public string IngestionErrors { get; set; }
        [XmlElement(ElementName = "itemsReceived", Namespace = "http://walmart.com/")]
        public string ItemsReceived { get; set; }
        [XmlElement(ElementName = "itemsSucceeded", Namespace = "http://walmart.com/")]
        public string ItemsSucceeded { get; set; }
        [XmlElement(ElementName = "itemsFailed", Namespace = "http://walmart.com/")]
        public string ItemsFailed { get; set; }
        [XmlElement(ElementName = "itemsProcessing", Namespace = "http://walmart.com/")]
        public string ItemsProcessing { get; set; }
        [XmlElement(ElementName = "offset", Namespace = "http://walmart.com/")]
        public string Offset { get; set; }
        [XmlElement(ElementName = "limit", Namespace = "http://walmart.com/")]
        public string Limit { get; set; }
        [XmlElement(ElementName = "itemDetails", Namespace = "http://walmart.com/")]
        public ItemDetails ItemDetails { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }
    }

    [XmlRoot(ElementName = "itemIngestionStatus", Namespace = "http://walmart.com/")]
    public class ItemIngestionStatus
    {
        [XmlElement(ElementName = "martId", Namespace = "http://walmart.com/")]
        public string MartId { get; set; }
        [XmlElement(ElementName = "sku", Namespace = "http://walmart.com/")]
        public string Sku { get; set; }
        [XmlElement(ElementName = "index", Namespace = "http://walmart.com/")]
        public string Index { get; set; }
        [XmlElement(ElementName = "ingestionStatus", Namespace = "http://walmart.com/")]
        public string IngestionStatus { get; set; }
        [XmlElement(ElementName = "ingestionErrors", Namespace = "http://walmart.com/")]
        public string IngestionErrors { get; set; }
    }

    [XmlRoot(ElementName = "itemDetails", Namespace = "http://walmart.com/")]
    public class ItemDetails
    {
        [XmlElement(ElementName = "itemIngestionStatus", Namespace = "http://walmart.com/")]
        public List<ItemIngestionStatus> ItemIngestionStatus { get; set; }
    }


}
