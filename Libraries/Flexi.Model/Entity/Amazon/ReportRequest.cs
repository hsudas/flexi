using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("reportrequest", Schema = "rpr")]
    public class ReportRequest
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("reporttype")]
        public string ReportType { get; set; }
        [Column("reportrequestid")]
        public string ReportRequestId { get; set; }
        [Column("generatedreportid")]
        public Int64 GeneratedReportId { get; set; }
        [Column("startdate")]
        public DateTime? StartDate { get; set; }
        [Column("enddate")]
        public DateTime? EndDate { get; set; }
        [Column("submitdate")]
        public DateTime? SubmitDate { get; set; }
        [Column("reportstatus")]
        public string ReportStatus { get; set; }
        [Column("scheduleid")]
        public int ScheduleId { get; set; }
        [Column("downloaded")]
        public bool Downloaded { get; set; }
        [Column("totalrowcount")]
        public int TotalRowCount { get; set; }
        [Column("successrowcount")]
        public int SuccessRowCount { get; set; }
        [Column("isprocessed")]
        public bool IsProcessed { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("lastupdatedate")]
        public DateTime? LastUpdateDate { get; set; }
    }
}
