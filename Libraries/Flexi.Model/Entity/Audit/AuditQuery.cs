
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Audit
{
    [Table("AuditQuery")]
    public class AuditQuery
    {
        [Key]
        public int AuditQueryId { get; set; }

        public string Query { get; set; }

        public long? LastResult { get; set; }

        public int? Period { get; set; }

        public long? AlertLimit { get; set; }

        public int? AlertType { get; set; }

        public DateTime? LastExecutionDate { get; set; }

        public bool? Status { get; set; }

        public bool? ShowOnWallboard { get; set; }

        public string AlertEmails { get; set; }

        public string AlertPhones { get; set; }

        public string Description { get; set; }

        public int? AlertPeriod { get; set; }

        public DateTime? LastAlertDate { get; set; }

        public int? MailTemplateId { get; set; }


    }
}
