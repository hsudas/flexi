using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("notificationfulfillment")]
    public class NotificationFulfillment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("uniqueid")]
        public string UniqueId { get; set; }
        [Column("eventtype")]
        public string EventType { get; set; }
        [Column("fulfillmentorderid")]
        public string FulfillmentOrderId { get; set; }
        [Column("fulfillmentorderstatus")]
        public string FulfillmentOrderStatus { get; set; }
        [Column("fulfillmentshipmentstatus")]
        public string FulfillmentShipmentStatus { get; set; }
        [Column("amazonshipmentid")]
        public string AmazonShipmentId { get; set; }
        [Column("estimatedarrivaldatetime")]
        public DateTime EstimatedArrivalDateTime { get; set; }
        [Column("publishdate")]
        public DateTime PublishDate { get; set; }
        [Column("statusupdateddate")]
        public DateTime StatusUpdatedDate { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }

        [NotMapped]
        public List<NotificationFulfillmentShipmentPackage> notificationFulfillmentShipmentPackageList { get; set; }
    }
}
