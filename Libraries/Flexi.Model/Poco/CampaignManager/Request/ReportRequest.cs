namespace Flexi.Model.Poco.CampaignManager.Request
{
    public class ReportRequest
    {
        public string campaignType { get; set; }
        public string segment { get; set; }
        public string reportDate { get; set; }
        public string metrics { get; set; }
    }
}
