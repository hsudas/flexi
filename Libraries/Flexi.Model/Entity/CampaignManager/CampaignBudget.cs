using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.CampaignManager
{
    [Table("campaignbudget", Schema = "cmp")]
    public class CampaignBudget //: MongoRepository.Entity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("dailybudget")]
        public decimal DailyBudget { get; set; }
        [Column("additionaldailybudget")]
        public decimal AdditionalDailyBudget { get; set; }
        [Column("dailybudgetmax")]
        public decimal DailyBudgetMax { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
