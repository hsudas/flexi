using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("asinfeedetaillog")]
    public class AsinFeeDetailLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("referralfee")]
        public decimal? ReferralFee { get; set; }
        [Column("variableclosingfee")]
        public decimal VariableClosingFee { get; set; }
        [Column("peritemfee")]
        public decimal PerItemFee { get; set; }
        [Column("fbaweighthandling")]
        public decimal FBAWeightHandling { get; set; }
        [Column("fbapickandpack")]
        public decimal? FBAPickAndPack { get; set; }
        [Column("fbaorderhandling")]
        public decimal FBAOrderHandling { get; set; }
        [Column("fbafees")]
        public decimal? FBAFees { get; set; }
        [Column("estimatedlistingprice")]
        public decimal? EstimatedListingPrice { get; set; }
        [Column("note")]
        public string Note { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
