using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Walmart
{
    [Table("walmartfeeditem", Schema = "mp")]
    public class WalmartFeedItem
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("feedid")]
        public string FeedId { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("wpid")]
        public string WpId { get; set; }
        [Column("ingestionstatus")]
        public string IngestionStatus { get; set; }
        [Column("errortype")]
        public string ErrorType { get; set; }
        [Column("errorcode")]
        public string ErrorCode { get; set; }
        [Column("errorfield")]
        public string ErrorField { get; set; }
        [Column("errordescription")]
        public string ErrorDescription { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
