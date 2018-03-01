using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("inventory")]
    public class Inventory
    {
        [Key]
        [Column("inventoryid")]
        public int InventoryId { get; set; }
        [Column("sku")]
        public string SKU { get; set; }
        [Column("shipmentid")]
        public string ShipmentId { get; set; }
        [Column("quantity")]
        public string Quantity { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("orderid")]
        public int? OrderId { get; set; }
        [Column("invstatusid")]
        public int? InvStatusId { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("shipmentname")]
        public string ShipmentName { get; set; }
        [Column("mac")]
        public string mac { get; set; }
        [Column("expdate")]
        public string ExpDate { get; set; }
        [Column("scanuser")]
        public string ScanUser { get; set; }
        [Column("scandate")]
        public DateTime? ScanDate { get; set; }
        [Column("packeddate")]
        public DateTime? PackedDate { get; set; }
        [Column("invoiceno")]
        public string InvoiceNo { get; set; }
        [Column("sellerid")]
        public string SellerId { get; set; }

    }
}
