using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("order", Schema = "mp")]
    public class Order
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("orderid")]
        public string OrderId { get; set; }
        [Column("orderno")]
        public string OrderNo { get; set; }
        [Column("orderdate")]
        public DateTime? OrderDate { get; set; }
        //[Column("orderstatus")]
        //public OrderItemStatus OrderStatus { get; set; }
        //[Column("ordersubstatus")]
        //public string OrderSubStatus { get; set; }
        [Column("orderstatusmp")]
        public string OrderStatusMP { get; set; }
        [Column("mp")]
        public string MP { get; set; } //MP
        [Column("totalprice")]
        public decimal TotalPrice { get; set; }
        [Column("buyername")]
        public string BuyerName { get; set; }
        [Column("receipentname")]
        public string ReceipentName { get; set; }
        [Column("userid")]
        public string UserId { get; set; }
        [Column("addresstitle")]
        public string AddressTitle { get; set; }
        [Column("addresstype")]
        public string AddressType { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("line1")]
        public string Line1 { get; set; }
        [Column("line2")]
        public string Line2 { get; set; }
        [Column("line3")]
        public string Line3 { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("postalcode")]
        public string PostalCode { get; set; }
        [Column("requestedshipmentmethod")]
        public string RequestedShipmentMethod { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateuser")]
        public string LastUpdateUser { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }


        [NotMapped]
        public string FulfillmentOrderId => string.Concat(MP.ToLower(), "-", OrderId);

        [NotMapped]
        public List<OrderItem> OrderItemList { get; set; }
    }
}