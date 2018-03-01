using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity
{
    [Table("mailtemplate")]
    public class MailTemplate
    {
        [Key]
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string TemplateText { get; set; }
        public string Query { get; set; }
        public int? Status { get; set; }
        public string Variables { get; set; }
        public string QueryType { get; set; }
    }
}
