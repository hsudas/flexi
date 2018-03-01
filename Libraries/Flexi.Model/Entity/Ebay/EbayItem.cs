using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Ebay
{
    [Table("ebayitem", Schema = "mp")]
    public class EbayItem
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("itemid")]
        public string ItemId { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("quantityavailable")]
        public int QuantityAvailable { get; set; }
        [Column("currentprice")]
        public decimal CurrentPrice { get; set; }
        [Column("createdate")]
        public DateTime CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
