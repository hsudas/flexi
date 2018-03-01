namespace Flexi.Model.Poco.CampaignManager.Response
{
    public class CampaignNegativeKeyword
    {
        public ulong keywordId { get; set; }
        public ulong campaignId { get; set; }
        public string state { get; set; }
        public string keywordText { get; set; }
        public string matchType { get; set; }
    }
}
