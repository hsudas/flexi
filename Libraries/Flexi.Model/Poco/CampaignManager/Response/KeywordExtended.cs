namespace Flexi.Model.Poco.CampaignManager.Response
{
    public class KeywordExtended
    {
        public ulong keywordId { get; set; }
        public ulong campaignId { get; set; }
        public ulong adGroupId { get; set; }
        public string state { get; set; }
        public string keywordText { get; set; }
        public string matchType { get; set; }
        public double bid { get; set; }
        public long creationDate { get; set; }
        public long lastUpdatedDate { get; set; }
        public string servingStatus { get; set; }
    }
}
