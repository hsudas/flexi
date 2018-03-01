using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.ThirdParty
{
    [Table("labellog", Schema = "public")]
    public class LabelLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("orderid")]
        public string OrderId { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("unit")]
        public int Unit { get; set; }
        [Column("trackingid")]
        public string TrackingId { get; set; }
        [Column("carrier")]
        public string Carrier { get; set; }
        [Column("servicetype")]
        public string ServiceType { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }

}
