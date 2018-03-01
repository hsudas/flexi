using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Walmart
{
    [Table("walmartorderitem", Schema = "rpr")]
    public class WalmartOrderItem
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("orderid")]
        public string OrderId { get; set; }
        [Column("mp")]
        public string Mp { get; set; }
        [Column("orderdate")]
        public DateTime? OrderDate { get; set; }
        [Column("customeremailid")]
        public string CustomerEmailId { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("estimateddeliverydate")]
        public DateTime? EstimatedDeliveryDate { get; set; }
        [Column("estimateddhipdate")]
        public DateTime? EstimatedShipDate { get; set; }
        [Column("shippingmethodcode")]
        public string ShippingMethodCode { get; set; }
        [Column("receivername")]
        public string ReceiverName { get; set; }
        [Column("address1")]
        public string Address1 { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("postalCode")]
        public string PostalCode { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("addressType")]
        public string AddressType { get; set; }
        [Column("linenumber")]
        public int? Linenumber { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("price")]
        public decimal? Price { get; set; }
        [Column("othercharge")]
        public decimal? OtherCharge { get; set; }
        [Column("tax")]
        public decimal? Tax { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("statusdate")]
        public DateTime? StatusDate { get; set; }
        [Column("orderlinestatus")]
        public string OrderLineStatus { get; set; }
        [Column("statusquantity")]
        public int? StatusQuantity { get; set; }
        [Column("shipping_charge")]
        public decimal? Shipping_Charge { get; set; }
        [Column("tax_charge")]
        public decimal? Tax_Charge { get; set; }
        [Column("commission")]
        public decimal? Commission { get; set; }
        [Column("cancellationreason")]
        public string CancellationReason { get; set; }
        [Column("trackingnumber")]
        public string TrackingNumber { get; set; }
        [Column("carrier")]
        public string Carrier { get; set; }
        [Column("shipdatetime")]
        public DateTime? ShipDatetime { get; set; }
        [Column("refund")]
        public decimal Refund { get; set; }
        [Column("fulfillmentshipmethod")]
        public string FulfillmentShipmethod { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}