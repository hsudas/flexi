using System;

namespace Flexi.Model.Entity
{
    //[Table("schedulequery")]
    public class ScheduleQuery
    {
        //[Key]
        //[Column("id")]
        public long Id { get; set; }
        //[Column("status")]
        public int? Status { get; set; }
        //[Column("name")]
        public string Name { get; set; }
        //[Column("name")]
        public string SqlQuery { get; set; }
        //[Column("intervalminute")]
        public int IntervalMinute { get; set; }
        //[Column("lastexecutiondate")]
        public DateTime? LastExecutionDate { get; set; }
        //[Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}
