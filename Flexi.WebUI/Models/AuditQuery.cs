using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.WebUI.Models
{
    [Table("AuditQuery")]
    public class AuditQuery
    {
        [Key]
        public int AuditQueryId { get; set; }

        public long LastResult { get; set; }

        
        public long AlertLimit { get; set; }

        public string Description { get; set; }
        public long ShowWarningLimit { get; set; }
        public string Alertit
        {
            get
            {
                return (ShowWarningLimit < LastResult)?"red":"";
            }
        }
        public int DetailQueryId{get;set;}
    }
}
