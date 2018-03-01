using Dapper;
using System;


namespace Flexi.Model.Entity.Amazon
{
    [Table("feed")]
    public class Feed
    {
        [Key]
        [Column("feedid")]
        public int FeedID { get; set; }
        [Column("isprocessed")]
        public bool IsProcessed { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("feedtype")]
        public string FeedType { get; set; }
        [Column("feedstatus")]
        public string FeedStatus { get; set; }
        [Column("itemattributes")]
        public string ItemAttributes { get; set; }
        [Column("customattributes")]
        public string CustomAttributes { get; set; }
        [Column("responsetype")]
        public string ResponseType { get; set; }
        [Column("responsecode")]
        public int ResponseCode { get; set; }
        [Column("responsedesc")]
        public string ResponseDesc { get; set; }
        [Column("feedsubmissionid")]
        public long FeedSubmissionID { get; set; }
        [Column("messageid")]
        public long MessageID { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("processingdate")]
        public DateTime? ProcessingDate { get; set; }
        [Column("submitteddate")]
        public DateTime? SubmittedDate { get; set; }
        [Column("completeddate")]
        public DateTime? CompletedDate { get; set; }
        [Column("lowestfbaprice")]
        public decimal? LowestFBAPrice { get; set; }
        [Column("lowestmerchantprice")]
        public decimal? LowestMerchantPrice { get; set; }
        [Column("storeprice")]
        public decimal? StorePrice { get; set; }
        [Column("myprice")]
        public decimal? MyPrice { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("systemdate")]
        public DateTime? SystemDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
        [Column("latency")]
        public int Latency { get; set; }
    }
}
