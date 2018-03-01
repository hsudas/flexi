using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("feedprice")]
    public class FeedPrice
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("messageid")]
        public int MessageId { get; set; }
        [Column("minsellerallowedprice")]
        public decimal? MinSellerAllowedPrice { get; set; }
        [Column("minsellerallowedpricecurrency")]
        public string MinSellerallowedPriceCurrency { get; set; }
        [Column("maxsellerallowedprice")]
        public decimal? MaxSellerAllowedPrice { get; set; }
        [Column("maxsellerallowedpricecurrency")]
        public string MaxSellerAllowedPriceCurrency { get; set; }
        [Column("standardprice")]
        public decimal? StandardPrice { get; set; }
        [Column("standardpricecurrency")]
        public string StandardPriceCurrency { get; set; }
        [Column("feedsubmissionid")]
        public long FeedSubmissionId { get; set; }
        [Column("isprocessed")]
        public bool IsProcessed { get; set; }
        [Column("submitteddate")]
        public DateTime? SubmittedDate { get; set; }
        [Column("feedprocessingstatus")]
        public string FeedProcessingStatus { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}