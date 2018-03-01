using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{

    [Table("carriermap")]
    public class CarrierMap
    {
        [Key]
        [Column("carriermapid")]
        public int CarrierMapId { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("mp")]
        public string Mp { get; set; }
        [Column("amazoncarrier")]
        public string AmazonCarrier { get; set; }
        [Column("mpcarrier")]
        public string MPCarrier { get; set; }
    }
}
