using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Dashboard
{
    [Table("application")]
    public class Application
    {
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }

    }

    [Table("appenum")]
    public class AppEnum
    {
        [Key]
        public int Id { get; set; }
        public string EnumGroup { get; set; }
        public string EnumType { get; set; }
        public string EnumKey { get; set; }
        public string EnumValue { get; set; }

    }
}
