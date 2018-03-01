using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("inboundshipment", Schema = "public")]
    public class InboundShipment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("shipmentid")]
        public string ShipmentId { get; set; }
        [Column("shipmentname")]
        public string ShipmentName { get; set; }
        [Column("shipmentstatus")]
        public string ShipmentStatus { get; set; }
        [Column("labelpreptype")]
        public string LabelPrepType { get; set; }
        [Column("destinationfulfillmentcenterid")]
        public string DestinationFulfillmentCenterId { get; set; }
        [Column("boxcontentssource")]
        public string BoxContentsSource { get; set; }
        [Column("estimatedboxtotalunits")]
        public int? EstimatedBoxTotalUnits { get; set; }
        [Column("estimatedboxcontentsfee")]
        public decimal? EstimatedBoxContentsFee { get; set; }
        [Column("postalcode")]
        public string PostalCode { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("countrycode")]
        public string CountryCode { get; set; }
        [Column("stateorprovincecode")]
        public string StateOrProvincecode { get; set; }
        [Column("addressline1")]
        public string AddressLine1 { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("itemcount")]
        public int ItemCount { get; set; }
        [Column("successeditemcount")]
        public int SuccessedItemCount { get; set; }
        [Column("transportstatus")]
        public string TransportStatus { get; set; }
        [Column("freightreadydate")]
        public DateTime? FreightReadyDate { get; set; }
        [Column("previewpickupdate")]
        public DateTime? PreviewPickupDate { get; set; }
        [Column("previewdeliverydate")]
        public DateTime? PreviewDeliveryDate { get; set; }
        [Column("partneredestimateamount")]
        public decimal? PartneredEstimateAmount { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}