using System.Xml.Serialization;

namespace Royal.Model.Poco.Ebay.Request
{
    [XmlRoot(ElementName = "ReviseItemRequest", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ReviseItemRequest
    {
        [XmlElement(ElementName = "RequesterCredentials", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public RequesterCredentials RequesterCredentials { get; set; }
        [XmlElement(ElementName = "ErrorLanguage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ErrorLanguage { get; set; }
        [XmlElement(ElementName = "WarningLevel", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarningLevel { get; set; }
        [XmlElement(ElementName = "Item", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Item Item { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    //[XmlRoot(ElementName = "RequesterCredentials", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //public class RequesterCredentials
    //{
    //    [XmlElement(ElementName = "eBayAuthToken", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public string EBayAuthToken { get; set; }
    //}

    [XmlRoot(ElementName = "Item", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Item
    {
        [XmlElement(ElementName = "ItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemID { get; set; }
        [XmlElement(ElementName = "Title", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Title { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Description { get; set; }
    }


}
