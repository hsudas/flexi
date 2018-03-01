using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.AmazonReport
{
    [Table("reportschedule", Schema = "rpr")]
    public class ReportSchedule
    {
        [Key]
        [Column("id")]
        public int? Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("report_type")]
        public string Report_Type { get; set; }
        [Column("start_date_period_type")]
        public string Start_Date_Period_Type { get; set; }
        [Column("start_date_period")]
        public int Start_Date_Period { get; set; }
        [Column("end_date_period_type")]
        public string End_Date_Period_Type { get; set; }
        [Column("end_date_period")]
        public int End_Date_Period { get; set; }
        [Column("last_report_date")]
        public DateTime? Last_Report_Date { get; set; }
        [Column("last_end_date")]
        public DateTime? Last_End_Date { get; set; }
        [Column("uuid")]
        public string Uuid { get; set; }
        [Column("script")]
        public string Script { get; set; }
        [Column("check_request")]
        public bool Check_Request { get; set; }
        [Column("noparameter")]
        public bool Noparameter { get; set; }
        [Column("lastcanceldate")]
        public DateTime? LastCancelDate { get; set; }
    }
}