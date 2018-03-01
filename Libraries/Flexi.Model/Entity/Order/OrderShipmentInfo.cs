using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Flexi.Model.Entity.OrderShipmentInfo
{
    [Table("ordershipmentinfo")]
    public class OrderShipmentInfo
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("orderid")]
        public string Orderid { get; set; }
        [Column("orderitemid")]
        public string Orderitemid { get; set; }
        [Column("trackingid")]
        public string Trackingid { get; set; }
        [Column("carrier")]
        public string Carrier { get; set; }
        [Column("servicetype")]
        public string Servicetype { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("charge")]
        public decimal? Charge { get; set; }
        [Column("insertdate")]
        public DateTime? Insertdate { get; set; }
        [Column("feedsubmissionid")]
        public string FeedSubmissionId { get; set; }
        [Column("feedresponse")]
        public string FeedResponse { get; set; }
        [Column("labelsource")]
        public string LabelSource { get; set; }
        [Column("labelformat")]
        public string LabelFormat { get; set; }
        [Column("packingslip")]
        public string PackingSlip { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("labeleduser")]
        public string Labeleduser { get; set; }
        [Column("note")]
        public string Note { get; set; }
        [Column("warehouse")]
        public string Warehouse { get; set; }



    }
}