using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("productbundle")]
    public class ProductBundle
    {
        [Key]
        [Column("productbundleid")]
        public long ProductBundleId { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("bundlename")]
        public string BundleName { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("itemnumber")]
        public int ItemNumber { get; set; }
        [Column("subproductsourceitemupc")]
        public string SubProductSourceItemUpc { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("createdate")]
        public DateTime Createdate { get; set; }
        [Column("lastupdateddate")]
        public DateTime LastUpdatedDate { get; set; }
    }
}
