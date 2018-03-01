using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Flexi.Model.Entity.Amazon
{
    [Table("asindetail")]
    [DebuggerDisplay("Asin:{Asin}, Upc:{Upc}, Title:{Title}")]
    public class AsinDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("ean")]
        public string Ean { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("descriptionhtml")]
        public string DescriptionHtml { get; set; }
        [Column("packweight")]
        public decimal PackWeight { get; set; }
        [Column("packlength")]
        public decimal PackLength { get; set; }
        [Column("packwidth")]
        public decimal PackWidth { get; set; }
        [Column("packheight")]
        public decimal PackHeight { get; set; }
        [Column("itemweight")]
        public decimal ItemWeight { get; set; }
        [Column("itemlength")]
        public decimal ItemLength { get; set; }
        [Column("itemwidth")]
        public decimal ItemWidth { get; set; }
        [Column("itemheight")]
        public decimal ItemHeight { get; set; }
        [Column("subupc")]
        public string SubUpc { get; set; }
        [Column("pack")]
        public int? Pack { get; set; }
        [Column("manufacturer")]
        public string Manufacturer { get; set; }
        [Column("brand")]
        public string Brand { get; set; }
        [Column("featurelist")]
        public string FeautureList { get; set; }
        [Column("imagelist")]
        public string ImageList { get; set; }
        [Column("lowestnewprice")]
        public decimal LowestNewPrice { get; set; }
        [Column("salesrank")]
        public string SalesRank { get; set; }
        [Column("errormessage")]
        public string ErrorMessage { get; set; }
        [Column("parentasin")]
        public string ParentAsin { get; set; }
        [Column("rankingcategory")]
        public string RankingCategory { get; set; }
        [Column("ranking")]
        public Int64 Ranking { get; set; }
        [Column("category")]
        public string Category { get; set; }
        [Column("productgroup")]
        public string ProductGroup { get; set; }
        [Column("producttypename")]
        public string ProductTypeName { get; set; }
        [Column("binding")]
        public string Binding { get; set; }
        [Column("publisher")]
        public string Publisher { get; set; }
        [Column("listprice")]
        public decimal? ListPrice { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
