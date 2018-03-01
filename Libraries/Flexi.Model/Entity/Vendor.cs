using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity
{
    [Table("vendor")]
    public class Vendor //: BaseEntity
    {
        [Key]
        [Column("vendorid")]
        public int VendorId { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("parentcode")]
        public string ParentCode { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("isautolisting")]
        public bool IsAutoListing { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}
