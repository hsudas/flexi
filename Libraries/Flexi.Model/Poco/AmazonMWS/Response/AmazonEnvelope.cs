using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "AmazonEnvelope")]
    public class AmazonEnvelope
    {
        public Header Header { get; set; }
        public string MessageType { get; set; }
        public Message Message { get; set; }
    }

    public class Header
    {
        public string DocumentVersion { get; set; }
        public string MerchantIdentifier { get; set; }
    }

    public class Message
    {
        public string MessageID { get; set; }
        public ProcessingReport ProcessingReport { get; set; }
    }

    public class ProcessingReport
    {
        public string DocumentTransactionID { get; set; }
        public string StatusCode { get; set; }
        public ProcessingSummary ProcessingSummary { get; set; }
        [XmlElement(ElementName = "Result")]
        public List<Result> Result { get; set; }
    }

    public class ProcessingSummary
    {
        [XmlAttribute(AttributeName = "MarketplaceName")]
        public string MarketplaceName { get; set; }
        public string MessagesProcessed { get; set; }
        public string MessagesSuccessful { get; set; }
        public string MessagesWithError { get; set; }
        public string MessagesWithWarning { get; set; }
    }

    public class Result
    {
        public string MessageID { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessageCode { get; set; }
        public string ResultDescription { get; set; }
        public AdditionalInfo AdditionalInfo { get; set; }
    }

    public class AdditionalInfo
    {
        public string SKU { get; set; }
    }
}
