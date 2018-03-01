using Flexi.Model.Enum.AmazonMWS;
using System;
using System.Collections.Generic;

namespace Flexi.Model.Poco.AmazonMWS.Request
{
    public class SubmitFeedRequest
    {
        public string AWSAccessKeyId { get; set; }
        public string SellerId { get; set; }
        public string SecretKey { get; set; }
        public string FeedContent { get; set; }
        public FeedType FeedType { get; set; }
        public List<string> MarketplaceIdList { get; set; }
        //public bool? PurgeAndReplace { get; set; }

        public Dictionary<string, string> GetRequestParameters(string awsAccessKeyId, string sellerId, string contentMD5Value)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("AWSAccessKeyId", awsAccessKeyId);
            parameters.Add("Action", "SubmitFeed");
            parameters.Add("ContentMD5Value", contentMD5Value);
            parameters.Add("FeedType", FeedType.ToString());
            if (MarketplaceIdList != null && MarketplaceIdList.Count > 0)
            {
                for (int i = 0; i < MarketplaceIdList.Count; i++)
                {
                    parameters.Add("MarketplaceIdList.Id" + (i + 1).ToString(), MarketplaceIdList[i].ToString());
                }
            }
            parameters.Add("Merchant", sellerId);
            //if (PurgeAndReplace != null)
            //{
            //    parameters.Add("PurgeAndReplace", PurgeAndReplace.Value.ToString());
            //}
            parameters.Add("SignatureMethod", "HmacSHA256");
            parameters.Add("SignatureVersion", "2");
            parameters.Add("Timestamp", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            parameters.Add("Version", "2009-01-01");
            return parameters;
        }
    }
}
