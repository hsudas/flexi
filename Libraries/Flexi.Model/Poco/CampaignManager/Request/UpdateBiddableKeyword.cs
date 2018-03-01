namespace Flexi.Model.Poco.CampaignManager.Request
{
    public class UpdateBiddableKeyword
    {
        public ulong keywordId { get; set; }
        public string state { get; set; }
        public string bid { get; set; }
    }
}
