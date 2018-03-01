using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("productsourceitem")]
    public class ProductSourceItem
    {
        [Key]
        [Column("productsourceid")]
        public long ProductSourceId { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("productname")]
        public string ProductName { get; set; }
        [Column("brandname")]
        public string BrandName { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("itemnumber")]
        public Int32 ItemNumber { get; set; }
        [Column("storename")]
        public string StoreName { get; set; }
        [Column("unitprice")]
        public decimal UnitPrice { get; set; }
        [Column("boxprice")]
        public decimal BoxPrice { get; set; }
        [Column("unitcountinbox")]
        public int UnitCountInBox { get; set; }
        [Column("oz")]
        public string Oz { get; set; }
        [Column("sample")]
        public bool Sample { get; set; }
        [Column("normalpicturepath")]
        public string NormalPicturePath { get; set; }
        [Column("thumbnailpicturepath")]
        public string ThumbnailPicturePath { get; set; }
        [Column("createdate")]
        public DateTime Createdate { get; set; }
        [Column("lastupdateddate")]
        public DateTime LastUpdatedDate { get; set; }
    }
}
