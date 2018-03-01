namespace Flexi.Model.Poco.CampaignManager.Response
{
    public class AdGroupExtended
    {
        public ulong adGroupId { get; set; }
        public string name { get; set; }
        public ulong campaignId { get; set; }
        public double defaultBid { get; set; }
        public string state { get; set; }
        public long creationDate { get; set; }
        public long lastUpdatedDate { get; set; }
        public string servingStatus { get; set; }
    }
}
