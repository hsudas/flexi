namespace Flexi.Model.Poco.CampaignManager.Request
{
    public class CreateCampaign
    {
        public string name { get; set; }
        public string campaignType { get; set; }
        public string targetingType { get; set; }
        public string state { get; set; }
        public double dailyBudget { get; set; }
        public string startDate { get; set; }
    }
}
