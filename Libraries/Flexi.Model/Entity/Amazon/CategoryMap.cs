using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("categorymap")]
    public class CategoryMap
    {
        [Key]
        [Column("categorymapid")]
        public int CategoryMapId { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("mp")]
        public string Mp { get; set; }
        [Column("productgroup")]
        public string ProductGroup { get; set; }
        [Column("binding")]
        public string Binding { get; set; }
        [Column("mpcategory")]
        public string MPCategory { get; set; }
    }
}
