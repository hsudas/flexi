using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity
{
    [Table("keyvalue", Schema = "public")]
    public class KeyValue
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("key")]
        public string Key { get; set; }
        [Column("value")]
        public string Value { get; set; }
    }
}
