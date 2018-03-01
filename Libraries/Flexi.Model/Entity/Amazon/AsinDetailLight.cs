using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("asindetaillight")]
    public class AsinDetailLight
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("lowestprice")]
        public decimal LowestPrice { get; set; }
        [Column("ranking")]
        public long Ranking { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
