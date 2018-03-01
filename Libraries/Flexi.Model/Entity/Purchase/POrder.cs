using Flexi.Model.Enum.Purchase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Purchase
{
    [Table("porder")]
    public class POrder : BaseEntity
    {
        [Key]
        [Column("porderid")]
        public int POrderId { get; set; }
        [Column("vendor")]
        public string Vendor { get; set; }
        [Column("vendororderno")]
        public int VendorOrderNo { get; set; }
        [Column("porderstatus")]
        public POrderStatus POrderStatus { get; set; }
    }
}
