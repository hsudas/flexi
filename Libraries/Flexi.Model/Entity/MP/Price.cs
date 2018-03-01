using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("price", Schema = "mp")]
    public class Price
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("mp")]
        public string MP { get; set; }
        [Column("myprice")]
        public decimal? MyPrice { get; set; }
        [Column("mpprice")]
        public decimal? MPPrice { get; set; }
        [Column("lastmypricedate")]
        public DateTime? LastMyPriceDate { get; set; }
        [Column("lastmppricedate")]
        public DateTime? LastMPPriceDate { get; set; }
        [Column("salesrank")]
        public int? SalesRank { get; set; }
        [Column("lastsalesrankdate")]
        public DateTime? LastSalesRankDate { get; set; }
        [Column("monthlysalesunit")]
        public int? MonthlySalesUnit { get; set; }
        [Column("lastmonthlysalesunitdate")]
        public DateTime? LastMonthlySalesUnitDate { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}