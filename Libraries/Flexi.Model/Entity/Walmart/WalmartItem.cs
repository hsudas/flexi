using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.walmartitem
{
    [Table("walmartitem", Schema = "mp")]
    public class WalmartItem
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("itemid")]
        public string ItemId { get; set; }
        [Column("parentitemid")]
        public string ParentItemId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("brandname")]
        public string BrandName { get; set; }
        [Column("saleprice")]
        public decimal SalePrice { get; set; }
        [Column("msrp")]
        public decimal Msrp { get; set; }
        [Column("longdescription")]
        public string LongDescription { get; set; }
        [Column("rollback")]
        public bool RollBack { get; set; }
        [Column("specialbuy")]
        public string SpecialBuy { get; set; }
        [Column("customerrating")]
        public decimal CustomerRating { get; set; }
        [Column("producttrackingurl")]
        public string ProductTrackingUrl { get; set; }
        [Column("producturl")]
        public string ProductUrl { get; set; }
        [Column("sellerinfo")]
        public string sellerInfo { get; set; }
        [Column("numreviews")]
        public string numReviews { get; set; }
    }
}