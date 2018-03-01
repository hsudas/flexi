using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Flexi.Model.Entity.MP
{
    [Table("refund", Schema = "mp")]
    public class Refund
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("orderid")]
        public string OrderId { get; set; }
        [Column("orderitemid")]
        public string OrderItemId { get; set; }
        [Column("linenumber")]
        public int? LineNumber { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("totalamount")]
        public decimal TotalAmount { get; set; }
        [Column("reason")]
        public string Reason { get; set; }
        [Column("refundauthorizationid")]
        public string RefundAuthorizationId { get; set; }
        [Column("refundstatus")]
        public string RefundStatus { get; set; }
        [Column("response")]
        public string Response { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}