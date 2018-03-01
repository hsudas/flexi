using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("asinranking")]
    public class AsinRanking
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("salesrank")]
        public string SalesRank { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}
