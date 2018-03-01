using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Flexi.Model.Entity.Amazon
{
    [Table("asindetailtrigger")]
    public class AsinDetailTrigger
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
    }
}
