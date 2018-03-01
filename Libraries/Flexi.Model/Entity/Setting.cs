using System;
using System.ComponentModel.DataAnnotations;

namespace Flexi.Model.Entity
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }
        public int Status { get; set; }
        public string Institution { get; set; }
        public string JetTokenUser { get; set; }
        public string JetTokenPassword { get; set; }
        public string JetFullfillmentNodeId { get; set; }
        public string WalmartApiKey { get; set; }
        public string WalmartConsumerId { get; set; }
        public string WalmartPrivateKey { get; set; }
        //public string AmazonTokenName { get; set; }
        //public string AmazonTokenPass { get; set; }
        //public string AwsAccessKey { get; set; }
        //public string AwsSecretKey { get; set; }
        //public string AwsSqsAccessKeyId { get; set; }
        //public string AwsSqsSecretAccessKey { get; set; }
        //public string MwsAccessKey { get; set; }
        //public string MwsSecretKey { get; set; }
        //public string MwsMerchantId { get; set; }
        //public string AmazonSellerId { get; set; }
        //public string MarketPlaceId { get; set; }
        public string AmazonAdvertisingClientId { get; set; }
        public string AmazonAdvertisingClientSecret { get; set; }
        public string AmazonAdvertisingRedirectUrl { get; set; }
        public string AmazonAdvertisingProfileId { get; set; }
        public string AmazonAccountUserName { get; set; }
        public string AmazonAccountPassword { get; set; }
        public string ApiLogPath { get; set; }
        public string EBayAuthToken { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
