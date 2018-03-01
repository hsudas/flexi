using System;
using System.Collections.Generic;

namespace Flexi.Model.Poco.AmazonMWS.Request
{
    public class GetFeedSubmissionResultRequest
    {
        public string FeedSubmissionId { get; set; }

        public Dictionary<string, string> GetRequestParameters(string awsAccessKeyId, string sellerId)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("AWSAccessKeyId", awsAccessKeyId);
            parameters.Add("Action", "GetFeedSubmissionResult");
            parameters.Add("FeedSubmissionId", FeedSubmissionId);
            parameters.Add("Merchant", sellerId);
            parameters.Add("SignatureMethod", "HmacSHA256");
            parameters.Add("SignatureVersion", "2");
            parameters.Add("Timestamp", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            parameters.Add("Version", "2009-01-01");
            return parameters;
        }
    }
}
