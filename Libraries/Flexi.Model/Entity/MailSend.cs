using Dapper.Contrib.Extensions;
using System;

namespace Flexi.Model
{
    [Table("MailSend")]
    public class MailSend
    {
        [Key]
        public long Id { get; set; }

        public string Module { get; set; }

        public string Description { get; set; }

        public string Sender { get; set; }

        public string ToAddress { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime? SendDate { get; set; }

        public DateTime InsertDate { get; set; }

        public short? MailStatus { get; set; }

        public string FilePath { get; set; }

        public short? MailType { get; set; }
        public string CC { get; set; }

    }
    [Table("MailProfile")]
    public class MailProfile
    {
        [Key]
        public int ProfileId { get; set; }

        public string Sender { get; set; }

        public string Password { get; set; }

        public string Server { get; set; }

        public int? Port { get; set; }

        public int? Status { get; set; }

        public bool AmazonServerExist { get; set; }

        public int? SendMethod { get; set; }
        public string DisplayName { get; set; }

    }
    [Table("MailSendArchive")]
    public class MailSendArchive
    {
        [Key]
        public long Id { get; set; }

        public string Module { get; set; }

        public string Description { get; set; }

        public string Sender { get; set; }

        public string ToAddress { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime? SendDate { get; set; }

        public DateTime InsertDate { get; set; }

        public short? MailStatus { get; set; }

        public string FilePath { get; set; }

        public short? MailType { get; set; }

        public string ErrDescription { get; set; }
        public string CC { get; set; }

    }






}
