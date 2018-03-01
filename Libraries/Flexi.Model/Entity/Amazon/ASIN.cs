using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("asin")]
    public class ASiN
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
        [Column("lastchangeddate")]
        public DateTime? LastChangedDate { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }

    }
}
