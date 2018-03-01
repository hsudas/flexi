using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.CampaignManager
{
    [Table("campaignschedule", Schema = "cmp")]
    public class CampaignSchedule  //: MongoRepository.Entity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("startdate")]
        public DateTime StartDate { get; set; }
        [Column("enddate")]
        public DateTime EndDate { get; set; }
        //public string CampaignType { get; set; }
        [Column("targetingtype")]
        public string TargetingType { get; set; }
        [Column("premiumbidadjustment")]
        public bool PremiumBidAdjustment { get; set; }
        [Column("keywordbid")]
        public decimal KeywordBid { get; set; }
        [Column("adddailybudget")]
        public decimal AddDailyBudget { get; set; }
        [Column("schedulemaxbudget")]
        public decimal ScheduleMaxBudget { get; set; }
        [Column("ismonday")]
        public bool IsMonday { get; set; }
        [Column("istuesday")]
        public bool IsTuesday { get; set; }
        [Column("iswednesday")]
        public bool IsWednesday { get; set; }
        [Column("isthursday")]
        public bool IsThursday { get; set; }
        [Column("isfriday")]
        public bool IsFriday { get; set; }
        [Column("issaturday")]
        public bool IsSaturday { get; set; }
        [Column("issunday")]
        public bool IsSunday { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime CreateDate { get; set; }
        [Column("lastupdateddate")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
