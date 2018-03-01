namespace Flexi.Model.Poco.CampaignManager.Request
{
    public class UpdateCampaign
    {
        public ulong campaignId { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public decimal dailyBudget { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public bool premiumBidAdjustment { get; set; }
    }
}
