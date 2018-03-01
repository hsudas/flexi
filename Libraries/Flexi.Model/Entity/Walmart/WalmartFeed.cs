using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Walmart
{
    [Table("walmartfeed", Schema = "mp")]
    public class WalmartFeed
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("feedid")]
        public string FeedId { get; set; }
        [Column("feedstatus")]
        public string FeedStatus { get; set; }
        [Column("feedtype")]
        public string FeedType { get; set; }
        [Column("itemsreceived")]
        public int? ItemsReceived { get; set; }
        [Column("itemssucceeded")]
        public int? ItemsSucceeded { get; set; }
        [Column("itemsfailed")]
        public int? ItemsFailed { get; set; }
        [Column("itemsprocessing")]
        public int? ItemsProcessing { get; set; }
        [Column("xmlrequest")]
        public string XmlRequest { get; set; }
        [Column("xmlresponse")]
        public string XmlResponse { get; set; }
        [Column("isprocessed")]
        public int? IsProcessed { get; set; }
        [Column("updatedate")]
        public DateTime? CreateDate { get; set; }

    }
}
