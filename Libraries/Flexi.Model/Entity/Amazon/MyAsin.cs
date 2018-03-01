using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("myasins")]
    public class MyAsins
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("asin")]
        public string ASIN { get; set; }
        [Column("amazoninventory")]
        public int AmazonInventory { get; set; }
        [Column("perunitvolume")]
        public decimal PerUnitVolume { get; set; }
        [Column("yourprice")]
        public decimal YourPrice { get; set; }
        [Column("asinname")]
        public string AsinName { get; set; }
        [Column("pack"), DefaultValue(1)]
        public int Pack { get; set; }
        [Column("asinreq1")]
        public int AsinReq1 { get; set; }
        [Column("asinreq2")]
        public int AsinReq2 { get; set; }
        [Column("asinreq3")]
        public int AsinReq3 { get; set; }
        [Column("asinreq4")]
        public int AsinReq4 { get; set; }
        [Column("asinreq5")]
        public int AsinReq5 { get; set; }
        [Column("asinreq6")]
        public int AsinReq6 { get; set; }
        [Column("asinreq7")]
        public int AsinReq7 { get; set; }
        [Column("asinreq8")]
        public int AsinReq8 { get; set; }
        [Column("asinreq9")]
        public int AsinReq9 { get; set; }
        [Column("asinreq10")]
        public int AsinReq10 { get; set; }
        [Column("asinreq11")]
        public int AsinReq11 { get; set; }
        [Column("asinreq12")]
        public int AsinReq12 { get; set; }
        [Column("asinreq13")]
        public int AsinReq13 { get; set; }
        [Column("memo")]
        public string Memo { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("isexpdatelabel")]
        public bool IsExpDateLabel { get; set; }
        [Column("ispolybagging")]
        public bool IsPolyBagging { get; set; }
        [Column("isbubblewrapping")]
        public bool IsBubbleWrapping { get; set; }
        [Column("isbarcodecovering")]
        public bool IsBarcodeCovering { get; set; }
        [Column("isbulk")]
        public bool IsBulk { get; set; }
        [Column("isnutritionfact")]
        public bool IsNutritionFact { get; set; }
        [Column("isrestrictedfba")]
        public bool IsRestrictedFba { get; set; }
        [Column("ishazmat")]
        public bool IsHazmat { get; set; }
        [Column("isrestrictedall")]
        public bool IsRestrictedAll { get; set; }
        [Column("isbundling")]
        public bool IsBundling { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
        [Column("sellerid")]
        public string SellerId { get; set; }
        [Column("preptimesecond")]
        public int prepTimeSecond { get; set; }
    }
}
