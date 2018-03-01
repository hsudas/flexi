using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Flexi.Model.Entity.MP
{
    [Table("listing", Schema = "mp")]
    [DebuggerDisplay("{DebugMessage}")]
    public class Listing
    {
        [Key]
        [Column("listingid")]
        public int ListingId { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("itemid")]
        public string ItemId { get; set; }
        [Column("listingstatus")]
        public string ListingStatus { get; set; }
        [Column("mp")]
        public string MP { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("longdescription")]
        public string LongDescription { get; set; }
        [Column("shelfdescription")]
        public string ShelfDescription { get; set; }
        [Column("brand")]
        public string Brand { get; set; }
        [Column("price")]
        public decimal? Price { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("isautoprice")]
        public bool IsAutoPrice { get; set; }
        [Column("isautoquantity")]
        public bool IsAutoQuantity { get; set; }
        [Column("fulfillmentby")]
        public string FulfillmentBy { get; set; }
        [Column("mainimageurl")]
        public string MainImageUrl { get; set; }
        [Column("imageurllist")]
        public string ImageUrlList { get; set; }
        [Column("featurelist")]
        public string FeatureList { get; set; }
        [Column("packweight")]
        public decimal? PackWeight { get; set; }
        [Column("packlength")]
        public decimal? PackLength { get; set; }
        [Column("packwidth")]
        public decimal? PackWidth { get; set; }
        [Column("packheight")]
        public decimal? PackHeight { get; set; }
        [Column("itemweight")]
        public decimal? ItemWeight { get; set; }
        [Column("itemlength")]
        public decimal? ItemLength { get; set; }
        [Column("itemwidth")]
        public decimal? ItemWidth { get; set; }
        [Column("itemheight")]
        public decimal? ItemHeight { get; set; }
        [Column("packof")]
        public int PackOf { get; set; }
        [Column("browsenodeid")]
        public int? BrowseNodeId { get; set; }
        [Column("note")]
        public string Note { get; set; }
        [Column("statusmp")]
        public string StatusMp { get; set; }
        [Column("cost")]
        public decimal? Cost { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateduser")]
        public string LastUpdatedUser { get; set; }
        [Column("lastupdatedate")]
        public DateTime? LastUpdateDate { get; set; }
        //public Listing OrderBy { get; set; }

        private string DebugMessage
        {
            get
            {
                return $"MP:{MP}, Sku:{Sku}, Upc: {Upc}, Title: {Title}";
            }
        }
    }
}
