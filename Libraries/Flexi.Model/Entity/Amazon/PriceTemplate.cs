using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("pricetemplate")]
    public class PriceTemplate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("priceprofile")]
        public string PriceProfile { get; set; }
        [Column("fulfillmentchannel")]
        public string FulfillmentChannel { get; set; }
        [Column("addedamount")]
        public decimal AddedAmount { get; set; }
        [Column("beginvalue")]
        public decimal BeginValue { get; set; }
        [Column("endvalue")]
        public decimal EndValue { get; set; }
        [Column("note")]
        public string Note { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateuser")]
        public string LastUpdateUser { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }


    }
}
