using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity
{
    [Table("parameter")]
    public class Parameter
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("parametertype")]
        public int ParameterType { get; set; }
        [Column("parametername")]
        public string ParameterName { get; set; }
        [Column("parametervalue")]
        public string ParameterValue { get; set; }
    }
}
