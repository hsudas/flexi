using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Purchase
{
    [Table("psource", Schema = "public")]
    public class PSource : BaseEntity
    {
        [Key]
        [Column("psourceid")]
        public int PSourceId { get; set; }
        [Column("vendor")]
        public string Vendor { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("itemno")]
        public int? ItemNo { get; set; }
        [Column("unitpercase")]
        public int UnitPerCase { get; set; }
        [Column("unitprice")]
        public decimal? UnitPrice { get; set; }
        [Column("caseprice")]
        public decimal? CasePrice { get; set; }
    }
}
