using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity
{
    [Table("validip")]
    public class ValidIp
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("ip")]
        public string Ip { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("code")]
        public string Code { get; set; }
    }
}
