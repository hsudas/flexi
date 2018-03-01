using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.ThirdParty
{
    [Table("benasseinventory", Schema = "intg")]
    public class BenasseInventory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("warehouseid")]
        public int WarehouseId { get; set; }
        [Column("cost")]
        public double Cost { get; set; }
        [Column("weight")]
        public double Weight { get; set; }
        [Column("length")]
        public double Length { get; set; }
        [Column("width")]
        public double Width { get; set; }
        [Column("height")]
        public double Height { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
