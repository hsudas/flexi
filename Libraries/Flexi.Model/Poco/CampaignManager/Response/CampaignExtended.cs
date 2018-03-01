namespace Flexi.Model.Poco.CampaignManager.Response
{
    public class CampaignExtended
    {
        public ulong campaignId { get; set; }
        public string name { get; set; }
        public string campaignType { get; set; }
        public string targetingType { get; set; }
        public string state { get; set; }
        public decimal dailyBudget { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public bool premiumBidAdjustment { get; set; }
        public long creationDate { get; set; }
        public long lastUpdatedDate { get; set; }
        public string servingStatus { get; set; }
    }
}
