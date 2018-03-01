using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Flexi.Model.Entity.MP
{
    [Table("orderitem", Schema = "mp")]
    [DebuggerDisplay("MP:{MP}, OrderItemId:{OrderItemId}, LineNumber: {LineNumber}")]
    public class OrderItem
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("orderitemid")]
        public string OrderItemId { get; set; }
        [Column("linenumber")]
        public int LineNumber { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("skusource")]
        public string SkuSource { get; set; }
        [Column("quantitysource")]
        public int QuantitySource { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("mp")]
        public string MP { get; set; } //MP
        [Column("fulfillmentby")]
        public string FulfillmentBy { get; set; }
        [Column("orderitemstatus")]
        public string OrderItemStatus { get; set; } //OrderItemStatus
        [Column("orderitemsubstatus")]
        public string OrderItemSubStatus { get; set; }
        [Column("orderid")]
        public string OrderId { get; set; }
        [Column("orderno")]
        public string OrderNo { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("tax")]
        public decimal Tax { get; set; }
        [Column("commission")]
        public decimal Commission { get; set; }
        [Column("trycount")]
        public int TryCount { get; set; }
        [Column("statusmessage")]
        public string StatusMessage { get; set; }
        [Column("statusdate")]
        public DateTime StatusDate { get; set; }
        [Column("fbasku")]
        public string FbaSku { get; set; }
        [Column("itemcost")]
        public decimal ItemCost { get; set; }
        [Column("shippingfromnj")]
        public decimal ShippingFromNj { get; set; }
        [Column("shippingfromca")]
        public decimal ShippingFromCa { get; set; }
        [Column("createdate")]
        public DateTime CreateDate { get; set; }
        [Column("lastupdateuser")]
        public string LastUpdateUser { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }

        //[NotMapped]
        //public string FullfillmentOrderId => string.Concat(MP, "-", OrderId);
        //[NotMapped]
        //public string FulfillmentOrderItemId => string.Concat(MP.ToLower(), "-", OrderItemId, "-", LineNumber);

        public string GetFulfillmentOrderId()
        {
            return string.Concat(MP.ToLower(), "-", OrderId);
        }

        public string GetFulfillmentOrderItemId()
        {
            return string.Concat(MP.ToLower(), "-", OrderItemId, "-", LineNumber);
        }

    }
}