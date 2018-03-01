using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Flexi.Model.Entity
{
    [Table("jobschedulerlog")]
    public class JobSchedulerLog
    {
        [Key]
        [Column("jobschedulerlogid")]
        public long JobSchedulerLogId { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("startdate")]
        public DateTime? StartDate { get; set; }
        [Column("enddate")]
        public DateTime? EndDate { get; set; }
        [Column("exceptiondate")]
        public DateTime? ExceptionDate { get; set; }

        public JobSchedulerLog()
        {
            Status = 1;
            StartDate = DateTime.Now;
            Name = new StackTrace().GetFrame(1).GetMethod().ReflectedType.Name;
        }
    }
}