using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Flexi.Model.Entity
{
    [Table("removal")]
    public class Removal
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("shipmentid")]
        public string ShipmentId { get; set; }
        [Column("category")]
        public string Category { get; set; }
        [Column("note")]
        public string Note { get; set; }
        [Column("insertdate")]
        public DateTime? InsertDate { get; set; }
        [Column("sku")]
        public string sku { get; set; }
        [Column("insertuser")]
        public string InsertUser { get; set; }
        [Column("updatedate")]
        public DateTime? UpdateDate { get; set; }
        [Column("updateuser")]
        public string UpdateUser { get; set; }
        [Column("status")]
        public int Status { get; set; }

    }
}
