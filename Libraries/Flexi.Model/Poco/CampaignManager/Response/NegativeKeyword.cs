namespace Flexi.Model.Poco.CampaignManager.Response
{
    public class NegativeKeyword
    {
        public ulong keywordId { get; set; }
        public ulong campaignId { get; set; }
        public ulong adGroupId { get; set; }
        public string state { get; set; }
        public string keywordText { get; set; }
        public string matchType { get; set; }
    }
}
