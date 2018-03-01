using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("asinmatching")]
    public class AsinMatching
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("skudestination")]
        public string SkuDestination { get; set; }
        [Column("asindestination")]
        public string AsinDestination { get; set; }
        [Column("asinsource")]
        public string AsinSource { get; set; }
        [Column("skusource")]
        public string SkuSource { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("minquantity")]
        public int? MinQuantity { get; set; }
        [Column("merchantquantity")]
        public int? MerchantQuantity { get; set; }
        [Column("insertdate")]
        public DateTime? InsertDate { get; set; }
        [Column("updatedate")]
        public DateTime? UpdateDate { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("updateuser")]
        public string UpdateUser { get; set; }
        [Column("insertuser")]
        public string InsertUser { get; set; }
        [Column("minprice")]
        public decimal? MinPrice { get; set; }
        [Column("vendor")]
        public string Vendor { get; set; }
    }
}
