using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("inboundshipmentitem", Schema = "public")]
    public class InboundShipmentItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("shipmentid")]
        public string ShipmentId { get; set; }
        [Column("quantityshipped")]
        public int? QuantitysShipped { get; set; }
        [Column("quantityreceived")]
        public int? QuantityReceived { get; set; }
        [Column("quantityincase")]
        public int? QuantityInCase { get; set; }
        [Column("fulfillmentnetworksku")]
        public string FulfillmentNetworkSku { get; set; }
        [Column("sellersku")]
        public string SellerSku { get; set; }
        [Column("releasedate")]
        public DateTime? ReleaseDate { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}