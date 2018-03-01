using System;

namespace Flexi.Model.Entity.CampaignManager
{
    public class Profile : MongoRepository.Entity
    {
        //[BsonId]
        public ulong profileId { get; set; }
        public int status { get; set; }
        public string countryCode { get; set; }
        public string currencyCode { get; set; }
        public double dailyBudget { get; set; }
        public string timezone { get; set; }
        public AccountInfo accountInfo { get; set; }
        public DateTime createDate { get; set; }
        public DateTime? lastUpdatedDate { get; set; }
    }

    public class AccountInfo
    {
        public string marketplaceStringId { get; set; }
        public string sellerStringId { get; set; }
    }
}
