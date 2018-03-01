using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    public class ListingLog : MongoRepository.Entity
    {
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
    }

    //public class ListingLog : ListingLogTmp
    //{
    //}

    //public class ListingLogTmp : MongoRepository.Entity
    //{
    //}
}
