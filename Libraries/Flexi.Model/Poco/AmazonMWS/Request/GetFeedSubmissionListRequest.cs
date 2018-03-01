using Flexi.Model.Enum.AmazonMWS;
using System;
using System.Collections.Generic;

namespace Flexi.Model.Poco.AmazonMWS.Request
{
    public class GetFeedSubmissionListRequest
    {
        public List<string> FeedSubmissionIdList { get; set; }
        public int? MaxCount { get; set; }
        public List<FeedType> FeedTypeList { get; set; }
        public List<FeedProcessingStatus> FeedProcessingStatusList { get; set; }
        public DateTime? SubmittedFromDate { get; set; }
        public DateTime? SubmittedToDate { get; set; }

        public Dictionary<string, string> GetRequestParameters(string awsAccessKeyId, string sellerId)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("AWSAccessKeyId", awsAccessKeyId);
            parameters.Add("Action", "GetFeedSubmissionList");
            if (FeedProcessingStatusList != null && FeedProcessingStatusList.Count > 0)
            {
                for (int i = 0; i < FeedProcessingStatusList.Count; i++)
                {
                    parameters.Add("FeedProcessingStatusList.Status." + (i + 1).ToString(), FeedProcessingStatusList[i].ToString());
                }
            }
            if (FeedSubmissionIdList != null && FeedSubmissionIdList.Count > 0)
            {
                for (int i = 0; i < FeedSubmissionIdList.Count; i++)
                {
                    parameters.Add("FeedSubmissionIdList.Id." + (i + 1).ToString(), FeedSubmissionIdList[i]);
                }
            }
            if (FeedTypeList != null && FeedTypeList.Count > 0)
            {
                for (int i = 0; i < FeedTypeList.Count; i++)
                {
                    parameters.Add("FeedTypeList.Type." + (i + 1).ToString(), FeedTypeList[i].ToString());
                }
            }
            if (MaxCount != null)
            {
                parameters.Add("MaxCount", MaxCount.ToString());
            }
            parameters.Add("Merchant", sellerId);
            parameters.Add("SignatureMethod", "HmacSHA256");
            parameters.Add("SignatureVersion", "2");
            if (SubmittedFromDate != null)
            {
                parameters.Add("SubmittedFromDate", SubmittedFromDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            }
            if (SubmittedToDate != null)
            {
                parameters.Add("SubmittedToDate", SubmittedToDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            }
            parameters.Add("Timestamp", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            parameters.Add("Version", "2009-01-01");
            return parameters;
        }
    }
}
