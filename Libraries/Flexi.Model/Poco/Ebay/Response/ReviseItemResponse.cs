using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.Ebay.Response
{
    [XmlRoot(ElementName = "ReviseItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ReviseItemResponse
    {
        [XmlElement(ElementName = "Timestamp", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Timestamp { get; set; }
        [XmlElement(ElementName = "Ack", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Ack { get; set; }
        [XmlElement(ElementName = "Errors", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Errors Errors { get; set; }
        [XmlElement(ElementName = "Version", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Version { get; set; }
        [XmlElement(ElementName = "Build", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Build { get; set; }
        [XmlElement(ElementName = "ItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemID { get; set; }
        [XmlElement(ElementName = "StartTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StartTime { get; set; }
        [XmlElement(ElementName = "EndTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EndTime { get; set; }
        [XmlElement(ElementName = "Fees", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Fees Fees { get; set; }
        [XmlElement(ElementName = "DiscountReason", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DiscountReason { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "ErrorParameters", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ErrorParameters
    {
        [XmlElement(ElementName = "Value", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "ParamID")]
        public string ParamID { get; set; }
    }

    [XmlRoot(ElementName = "Errors", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Errors
    {
        [XmlElement(ElementName = "ShortMessage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShortMessage { get; set; }
        [XmlElement(ElementName = "LongMessage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LongMessage { get; set; }
        [XmlElement(ElementName = "ErrorCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ErrorCode { get; set; }
        [XmlElement(ElementName = "SeverityCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SeverityCode { get; set; }
        [XmlElement(ElementName = "ErrorParameters", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ErrorParameters ErrorParameters { get; set; }
        [XmlElement(ElementName = "ErrorClassification", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ErrorClassification { get; set; }
    }

    [XmlRoot(ElementName = "Fee", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Fee
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Name { get; set; }
        //[XmlElement(ElementName = "Fee", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        //public Fee Fee { get; set; }
    }

    [XmlRoot(ElementName = "Fees", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Fees
    {
        [XmlElement(ElementName = "Fee", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public List<Fee> Fee { get; set; }
    }
}

