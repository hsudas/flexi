using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Pricing
{
    [Table("skutemplate", Schema = "public")]
    public class SkuTemplate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("templateid")]
        public int TemplateId { get; set; }
        [Column("insertdate")]
        public DateTime InsertDate { get; set; }
        [Column("insertuser")]
        public string InsertUser { get; set; }
        [Column("status")]
        public int Status { get; set; }
    }

    [Table("pricetemplatedefinition", Schema = "public")]
    public class PriceTemplateDefination
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("templatename")]
        public string TemplateName { get; set; }
        [Column("formula")]
        public string Formula { get; set; }
        [Column("status")]
        public int Status { get; set; }
    }
}
