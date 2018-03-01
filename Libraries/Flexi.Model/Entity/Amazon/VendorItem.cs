using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("vendoritem")]
    public class VendorItem
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("vendor")]
        public string Vendor { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
