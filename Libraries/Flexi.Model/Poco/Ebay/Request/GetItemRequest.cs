using System.Xml.Serialization;

namespace Royal.Model.Poco.Ebay.Request
{
    [XmlRoot(ElementName = "GetItemRequest", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetItemRequest
    {
        [XmlElement(ElementName = "RequesterCredentials", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public RequesterCredentials RequesterCredentials { get; set; }
        [XmlElement(ElementName = "ErrorLanguage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ErrorLanguage { get; set; }
        [XmlElement(ElementName = "WarningLevel", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarningLevel { get; set; }
        [XmlElement(ElementName = "ItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    //[XmlRoot(ElementName = "RequesterCredentials", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //public class RequesterCredentials
    //{
    //    [XmlElement(ElementName = "eBayAuthToken", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public string EBayAuthToken { get; set; }
    //}
}
