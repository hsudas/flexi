using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "SubmitFeedResponse", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    public class SubmitFeedResponse
    {
        public SubmitFeedResult SubmitFeedResult { get; set; }
        public ResponseMetadata ResponseMetadata { get; set; }
    }

    public class SubmitFeedResult
    {
        [XmlElement(ElementName = "FeedSubmissionInfo")]
        public List<FeedSubmissionInfo> FeedSubmissionInfo { get; set; }
    }
}
