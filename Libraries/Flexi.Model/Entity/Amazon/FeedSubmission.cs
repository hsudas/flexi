using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("feedsubmission")]
    public class FeedSubmission
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("isprocessed")]
        public bool IsProcessed { get; set; }
        [Column("feedsubmissionid")]
        public long FeedSubmissionID { get; set; }
        [Column("statuscode")]
        public string StatusCode { get; set; }
        [Column("messagesprocessed")]
        public int MessagesProcessed { get; set; }
        [Column("messagessuccessful")]
        public int MessagesSuccessful { get; set; }
        [Column("messageswitherror")]
        public int MessagesWithError { get; set; }
        [Column("messageswithwarning")]
        public int MessagesWithWarning { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("processingdate")]
        public DateTime? ProcessingDate { get; set; }
        [Column("submitteddate")]
        public DateTime? SubmittedDate { get; set; }
        [Column("completeddate")]
        public DateTime? CompletedDate { get; set; }
        [Column("requestxml")]
        public string RequestXml { get; set; }
        [Column("responsexml")]
        public string ResponseXml { get; set; }
    }
}
