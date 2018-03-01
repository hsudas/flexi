namespace Flexi.Model.Poco.CampaignManager.Response
{
    public class Profile //: MongoRepository.Entity
    {
        public ulong profileId { get; set; }
        public string countryCode { get; set; }
        public string currencyCode { get; set; }
        public double dailyBudget { get; set; }
        public string timezone { get; set; }
        public AccountInfo accountInfo { get; set; }
    }

    public class AccountInfo
    {
        public string marketplaceStringId { get; set; }
        public string sellerStringId { get; set; }
    }
}
