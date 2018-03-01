using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Flexi.Model.Entity.Walmart
{
    [Table("Worder")]
    public class Worder
    {
        [Key]
        [Column("id")]
        public Int64 Id { get; set; }
        [Column("purchaseorderid")]
        public string Purchaseorderid { get; set; }
        [Column("customerorderid")]
        public string Customerorderid { get; set; }
        [Column("customeremailid")]
        public string Customeremailid { get; set; }
        [Column("orderdate")]
        public DateTime? Orderdate { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("shipmentmethodcode")]
        public string Shipmentmethodcode { get; set; }
        [Column("addressname")]
        public string Addressname { get; set; }
        [Column("address1")]
        public string Address1 { get; set; }
        [Column("address2")]
        public string Address2 { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("postalcode")]
        public string Postalcode { get; set; }
        [Column("addresstype")]
        public string Addresstype { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("insertdate")]
        public DateTime? Insertdate { get; set; }
        [Column("updatedate")]
        public DateTime? Updatedate { get; set; }
        [Column("checkdate")]
        public DateTime? Checkdate { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("forderid")]
        public string Forderid { get; set; }
        [Column("response")]
        public string Response { get; set; }
        [Column("acknowledged")]
        public int? Acknowledged { get; set; }
        [Column("shippingupdated")]
        public int? Shippingupdated { get; set; }
        [Column("shipped")]
        public int? Shipped { get; set; }
    }
}