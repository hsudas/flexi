using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Walmart
{
    [Table("walmartitem")]
    public class WalmartItemOld
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("fba")]
        public int Fba { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("itemstatus")]
        public string ItemStatus { get; set; }
        [Column("itemid")]
        public int ItemId { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("price")]
        public decimal? Price { get; set; }
        [Column("checkdate")]
        public DateTime? CheckDate { get; set; }
        [Column("insertdate")]
        public DateTime? InsertDate { get; set; }
        [Column("autoquantity")]
        public int Autoquantity { get; set; }
        [Column("currentqty")]
        public int? CurrentQty { get; set; }
        [Column("currentqtydate")]
        public DateTime? currentQtyDate { get; set; }
        [Column("gtin")]
        public string Gtin { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("wpid")]
        public string WpId { get; set; }
        [Column("producttype")]
        public string ProductType { get; set; }
        [Column("currentprice")]
        public decimal CurrentPrice { get; set; }

    }
}
