using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("mrcinventory")]
    public class MrcInventory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("pack")]
        public int? Pack { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("quantitynj")]
        public int? QuantityNJ { get; set; }
        [Column("quantityca")]
        public int? QuantityCA { get; set; }
        [Column("insertdate")]
        public DateTime? CreateDate { get; set; }
        [Column("insertuser")]
        public string InsertUser { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("updatedate")]
        public DateTime? LastUpdatedDate { get; set; }
        [Column("updateuser")]
        public string UpdateUser { get; set; }
    }
}