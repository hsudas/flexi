using Flexi.Model.Enum.Purchase;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Purchase
{
    [Table("porderitem")]
    public class POrderItem : BaseEntity
    {
        [Key]
        [Column("porderitemid")]
        public int POrderItemId { get; set; }
        [Column("porderid")]
        public int POrderId { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("itemno")]
        public int? ItemNo { get; set; }
        [Column("unitpercase")]
        public int UnitPerCase { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("unitprice")]
        public decimal? UnitPrice { get; set; }
        [Column("caseprice")]
        public decimal? CasePrice { get; set; }
        [NotMapped]
        public decimal? TotalPrice { get; set; } // UnitPrice * CasePrice
        [Column("vendor")]
        public string Vendor { get; set; }
        [Column("vendororderno")]
        public int VendorOrderNo { get; set; }
        [DefaultValue(POrderItemStatus.Recomended)]
        [Column("orderitemstatus")]
        public POrderItemStatus OrderItemStatus { get; set; }
        [Column("productionreq")]
        public bool? ProductionReq { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("asinpack")]
        public int AsinPack { get; set; }
        [Column("asincount")]
        public int AsinCount { get; set; }
        [Column("asincost")]
        public decimal? AsinCost { get; set; }
        [MaxLength(500)]
        [Column("note")]
        public string Note { get; set; }
    }


}
