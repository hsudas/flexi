using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Audit
{
    [Table("AuditQueryLog")]
    public class AuditQueryLog
    {
        [Key]
        public long AuditQueryLogId { get; set; }

        public long AuditQueryId { get; set; }

        public long? Result { get; set; }

        public int? ElapsedTime { get; set; }

        public string ErrorMessage { get; set; }

        public DateTime? ExecutionDate { get; set; }

        public bool? Alerted { get; set; }

        public string AlertResult { get; set; }

    }

}
