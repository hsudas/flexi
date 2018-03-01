using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Flexi.Model.Enum.Amazon
{
    [Table("asinshipping")]
    [DebuggerDisplay("Asin:{Asin}, ShippingCost:{ShippingCost}, Weight:{Weight}")]
    public class AsinShipping
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("shippingcost")]
        public decimal ShippingCost { get; set; }
        [Column("weight")]
        public decimal Weight { get; set; }
        [Column("checkdate")]
        public DateTime? CheckDate { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }

    }
}
