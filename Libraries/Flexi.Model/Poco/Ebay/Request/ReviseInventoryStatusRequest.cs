using System.Collections.Generic;
using System.Xml.Serialization;

namespace Royal.Model.Poco.Ebay.Request
{
    [XmlRoot(ElementName = "ReviseInventoryStatusRequest", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ReviseInventoryStatusRequest
    {
        [XmlElement(ElementName = "RequesterCredentials", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public RequesterCredentials RequesterCredentials { get; set; }
        [XmlElement(ElementName = "ErrorLanguage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ErrorLanguage { get; set; }
        [XmlElement(ElementName = "WarningLevel", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarningLevel { get; set; }
        [XmlElement(ElementName = "InventoryStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public List<InventoryStatus> InventoryStatus { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "RequesterCredentials", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class RequesterCredentials
    {
        [XmlElement(ElementName = "eBayAuthToken", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EBayAuthToken { get; set; }
    }

    [XmlRoot(ElementName = "InventoryStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class InventoryStatus
    {
        [XmlElement(ElementName = "ItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemID { get; set; }
        [XmlElement(ElementName = "Quantity", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public int? Quantity { get; set; }
        [XmlElement(ElementName = "StartPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public decimal? StartPrice { get; set; }
    }
}
