namespace Flexi.Model.Poco.CampaignManager.Request
{
    public class CreateAdGroup
    {
        public ulong campaignId { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public double defaultBid { get; set; }
    }
}
