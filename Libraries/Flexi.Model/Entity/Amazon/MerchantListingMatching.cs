using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("merchantlistingmatching")]
    public class MerchantListingMatching
    {
        [Key]
        [Column("id")]
        public int? Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("vendor")]
        public string Vendor { get; set; }
        [Column("upc")]
        public string Upc { get; set; }
        [Column("mp")]
        public string MP { get; set; }
        [Column("identifier")]
        public string Identifier { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("pack")]
        public int? Pack { get; set; }
        [Column("minprice")]
        public decimal? MinPrice { get; set; }
        [Column("unitperasin")]
        public decimal? UnitPerAsin { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("minquantity"), DefaultValue(5)]
        public int MinQuantity { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateuser")]
        public string LastUpdateUser { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }

        public override string ToString()
        {
            return $"Upc: {Upc}, Vendor: {Vendor}, MP: {MP}, Identifier: {Identifier}";
        }
    }
}