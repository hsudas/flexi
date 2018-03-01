using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "GetFeedSubmissionListByNextTokenResponse", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    public class GetFeedSubmissionListByNextTokenResponse
    {
        public GetFeedSubmissionListByNextTokenResult GetFeedSubmissionListByNextTokenResult { get; set; }
        public ResponseMetadata ResponseMetadata { get; set; }
    }

    public class GetFeedSubmissionListByNextTokenResult
    {
        public string NextToken { get; set; }
        public bool HasNext { get; set; }
        [XmlElement(ElementName = "FeedSubmissionInfo")]
        public List<FeedSubmissionInfo> FeedSubmissionInfo { get; set; }
    }
}
