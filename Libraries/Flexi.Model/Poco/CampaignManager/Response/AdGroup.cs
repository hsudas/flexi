﻿namespace Flexi.Model.Poco.CampaignManager.Response
{
    public class AdGroup
    {
        public ulong adGroupId { get; set; }
        public string name { get; set; }
        public ulong campaignId { get; set; }
        public double defaultBid { get; set; }
        public string state { get; set; }
    }
}