using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("notificationfulfillmentshipmentpackage")]
    public class NotificationFulfillmentShipmentPackage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("fulfillmentorderid")]
        public string FulfillmentOrderId { get; set; }
        [Column("packagenumber")]
        public int PackageNumber { get; set; }
        [Column("carriercode")]
        public string CarrierCode { get; set; }
        [Column("trackingnumber")]
        public string TrackingNumber { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}
