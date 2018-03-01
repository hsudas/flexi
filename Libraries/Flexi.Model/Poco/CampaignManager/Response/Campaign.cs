﻿namespace Flexi.Model.Poco.CampaignManager.Response
{
    public class Campaign
    {
        public ulong campaignId { get; set; }
        public string name { get; set; }
        public string campaignType { get; set; }
        public string targetingType { get; set; }
        public bool premiumBidAdjustment { get; set; }
        public decimal dailyBudget { get; set; }
        public string startDate { get; set; }
        public string state { get; set; }
        public string endDate { get; set; }
    }
}
