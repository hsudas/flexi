using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("ordershipment", Schema = "mp")]
    public class OrderShipment
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("mp")]
        public string MP { get; set; }
        [Column("orderid")]
        public string OrderId { get; set; }
        [Column("orderitemid")]
        public string OrderItemId { get; set; }
        [Column("linenumber")]
        public int LineNumber { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("requestedshipmentmethod")]
        public string RequestedShipmentMethod { get; set; }
        [Column("fulfillmentorderid")]
        public string FulfillmentOrderId { get; set; }
        [Column("fulfillmentorderitemid")]
        public string FulfillmentOrderItemId { get; set; }
        [Column("trackingno")]
        public string TrackingNo { get; set; }
        [Column("fulfillmentcenterid")]
        public string FulfillmentCenterId { get; set; }
        [Column("shippingdate")]
        public DateTime ShippingDate { get; set; }
        [Column("carriercode")]
        public string CarrierCode { get; set; }
        [Column("amazonshipmentid")]
        public string AmazonShipmentId { get; set; }
        [Column("packagenumber")]
        public int? PackageNumber { get; set; }
        [Column("estimatedarrivaldate")]
        public DateTime EstimatedArrivalDate { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateuser")]
        public string LastUpdateUser { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}