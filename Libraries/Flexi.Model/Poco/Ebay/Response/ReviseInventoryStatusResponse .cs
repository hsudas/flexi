using System.Collections.Generic;
using System.Xml.Serialization;

namespace Royal.Model.Poco.Ebay.Response
{

    [XmlRoot(ElementName = "ReviseInventoryStatusResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ReviseInventoryStatusResponse
    {
        [XmlElement(ElementName = "Timestamp", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Timestamp { get; set; }
        [XmlElement(ElementName = "Ack", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public List<string> Ack { get; set; }
        [XmlElement(ElementName = "Errors", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public List<Errors> Errors { get; set; }
        [XmlElement(ElementName = "Version", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Version { get; set; }
        [XmlElement(ElementName = "Build", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Build { get; set; }
        [XmlElement(ElementName = "InventoryStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public List<InventoryStatus> InventoryStatus { get; set; }
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
        public List<ErrorParameters> ErrorParameters { get; set; }
        [XmlElement(ElementName = "ErrorClassification", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ErrorClassification { get; set; }
    }

    [XmlRoot(ElementName = "InventoryStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class InventoryStatus
    {
        [XmlElement(ElementName = "SKU", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SKU { get; set; }
        [XmlElement(ElementName = "ItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemID { get; set; }
        [XmlElement(ElementName = "StartPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public decimal StartPrice { get; set; }
        [XmlElement(ElementName = "Quantity", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public int Quantity { get; set; }
    }
}
