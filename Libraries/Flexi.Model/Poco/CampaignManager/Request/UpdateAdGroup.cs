namespace Flexi.Model.Poco.CampaignManager.Request
{
    public class UpdateAdGroup
    {
        public ulong adGroupId { get; set; }
        public string name { get; set; }
        public decimal defaultBid { get; set; }
        public string state { get; set; }
    }
}
