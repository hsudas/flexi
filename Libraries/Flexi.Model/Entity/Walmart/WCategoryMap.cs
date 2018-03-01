using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Walmart
{
    [Table("wcategorymap")]
    public class WCategoryMap
    {
        [Key]
        [Column("wcategorymapid")]
        public int wcategorymapid { get; set; }
        [Column("amazoncategory")]
        public string amazoncategory { get; set; }
        [Column("walmartcategory")]
        public string walmartcategory { get; set; }
    }
}
