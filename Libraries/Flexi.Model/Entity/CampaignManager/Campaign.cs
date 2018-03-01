using System;

namespace Flexi.Model.Entity.CampaignManager
{
    public class Campaign : MongoRepository.Entity
    {
        //[BsonId]
        //public ulong CampaignId { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public string CampaignType { get; set; }
        public string TargetingType { get; set; }
        public bool PremiumBidAdjustment { get; set; }
        public decimal DailyBudget { get; set; }
        public string StartDate { get; set; }
        public string State { get; set; }
        public string EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
