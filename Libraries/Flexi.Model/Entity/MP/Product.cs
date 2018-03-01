using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("productid")]
        public long ProductId { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("category")]
        public string Category { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }


        public virtual ICollection<Stock> StockList { get; set; }

        public override string ToString()
        {
            return $"upc : {this.Upc}, itemtitle : {this.Title}";
        }
    }
}
