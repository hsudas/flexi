using System.Xml.Serialization;

namespace Flexi.Model.Poco.Walmart.Response3
{

    [XmlRoot(ElementName = "FeedAcknowledgement", Namespace = "http://walmart.com/")]
    public class FeedAcknowledgement2
    {
        [XmlElement(ElementName = "feedId", Namespace = "http://walmart.com/")]
        public string FeedId { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }
    }
}
