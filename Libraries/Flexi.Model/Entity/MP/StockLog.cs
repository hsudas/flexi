using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("stocklog")]
    public class StockLog
    {
        [Key]
        [Column("stockid")]
        public long StockId { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("vendor")]
        public string Vendor { get; set; }
        [Column("vendoritemno")]
        public string VendorItemNo { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("itemcondition")]
        public string ItemCondition { get; set; }
        [Column("itemsourcechannel")]
        public string ItemSourceChannel { get; set; }
        [Column("itemdestination")]
        public string ItemDestination { get; set; }
        [Column("stockstatus")]
        public string StockStatus { get; set; }
        [Column("unitquantity")]
        public int UnitQuantity { get; set; }
        [Column("parentid")]
        public int? ParentId { get; set; }
        [Column("locationcolumn")]
        public string LocationColumn { get; set; }
        [Column("locationrow")]
        public string LocationRow { get; set; }
        [Column("locationaisle")]
        public string LocationAisle { get; set; }
        [Column("sourcerefid")]
        public int? SourceRefId { get; set; }
        [Column("unitpercase")]
        public int? UnitPerCase { get; set; }
        [Column("unitprice")]
        public decimal? UnitPrice { get; set; }
        [Column("caseprice")]
        public decimal? CasePrice { get; set; }
        [Column("warehouse")]
        public string Warehouse { get; set; }
        [Column("entrydate")]
        public DateTime EntryDate { get; set; }
        [Column("expdate")]
        public DateTime? ExpDate { get; set; }
        [Column("note")]
        public string Note { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateuser")]
        public string LastUpdateUser { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
        //only for stocklog
        [Column("effectororderid")]
        public string EffectorOrderId { get; set; }
    }
}
