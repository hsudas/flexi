using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("orderitems")]
    public class OrderItems
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("codfee")]
        public decimal? CodFee { get; set; }
        [Column("codfeediscount")]
        public decimal? CodFeediscount { get; set; }
        [Column("giftwrapprice")]
        public decimal? GiftWrapPrice { get; set; }
        [Column("giftwraptax")]
        public decimal? GiftWrapTax { get; set; }
        [Column("itemprice")]
        public decimal? ItemPrice { get; set; }
        [Column("itemtax")]
        public decimal? ItemTax { get; set; }
        [Column("promotiondiscount")]
        public decimal? PromotionDiscount { get; set; }
        [Column("shippingdiscount")]
        public decimal? ShippingDiscount { get; set; }
        [Column("shippingprice")]
        public decimal? ShippingPrice { get; set; }
        [Column("shippingtax")]
        public decimal? ShippingTax { get; set; }
        [Column("conditionid")]
        public string ConditionId { get; set; }
        [Column("conditionnote")]
        public string ConditionNote { get; set; }
        [Column("conditionsubtypeid")]
        public string ConditionSubtypeId { get; set; }
        [Column("giftmessagetext")]
        public string GiftMessagetext { get; set; }
        [Column("giftwraplevel")]
        public string GiftWraplevel { get; set; }
        [Column("orderitemid")]
        public string OrderItemId { get; set; }
        [Column("pricedesignation")]
        public string PriceDesignation { get; set; }
        [Column("scheduleddeliveryenddate")]
        public string ScheduledDeliveryEndDate { get; set; }
        [Column("scheduleddeliverystartdate")]
        public string ScheduledDeliveryStartDate { get; set; }
        [Column("sellersku")]
        public string Sellersku { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("quantityordered")]
        public int? QuantityOrdered { get; set; }
        [Column("quantityshipped")]
        public int? QuantityShipped { get; set; }
        [Column("orderid")]
        public long OrderId { get; set; }
        [Column("insertdate")]
        public DateTime? Insertdate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
        [Column("amazonorderid")]
        public string AmazonOrderId { get; set; }
        [Column("ismailed")]
        public int? IsMailed { get; set; }
        [Column("ismailedpricedrop")]
        public int? IsmailedPriceDrop { get; set; }
        [Column("source")]
        public string Source { get; set; }
        [Column("shippingfromnj")]
        public decimal? ShippingFromNj { get; set; }
        [Column("shippingfromca")]
        public decimal? ShippingFromCa { get; set; }
        [Column("shippingerror")]
        public string ShippingError { get; set; }
        [Column("shippingfromnjsmart")]
        public decimal? ShippingFromNjsmart { get; set; }
        [Column("shippingfromcasmart")]
        public decimal? ShippingFromCaSmart { get; set; }
        [Column("packweight")]
        public decimal? PackWeight { get; set; }
        [Column("shippingtemplate")]
        public string ShippingTemplate { get; set; }
    }
}