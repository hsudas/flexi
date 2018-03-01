using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("mppriceinventorychange", Schema = "mp")]
    public class MPPriceInventoryChange
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("mp")]
        public string Mp { get; set; }
        [Column("price")]
        public decimal? Price { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("result")]
        public string Result { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}