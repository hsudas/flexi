using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Application
{
    [Table("ScheduleItem")]
    public class ScheduleItem
    {
        [Key]
        public int Id { get; set; }
        public int? ScheduleType { get; set; }
        public string Command { get; set; }
        public int? RunPeriod { get; set; }
        public DateTime? LastExecutedTime { get; set; }
        public int? Status { get; set; }
        public int? MailResult { get; set; }
        public string ScheduleMode { get; set; }
        public DateTime? ScheduleTime { get; set; }
       
    }

    [Table("ScheduleLog")]
    public class ScheduleLog
    {
        [Key]
        public long Id { get; set; }
        public int? ScheduleItemId { get; set; }
        public DateTime? ExecutedTime { get; set; }
        public int? Success { get; set; }
        public string Message { get; set; }
        
    }
}
