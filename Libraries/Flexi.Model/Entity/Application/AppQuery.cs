using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Application
{
    public class AppQuery
    {
        public int QueryId { get; set; }

        public string QueryName { get; set; }

        public string QueryText { get; set; }

        public int? QueryType { get; set; }

        public int Status { get; set; }

    }
     [Table("AppQueryLog")]
    public class AppQueryLog
    {
         [Key]
        public long LogId { get; set; }

        public string QueryName { get; set; }

        public int? Duration { get; set; }

        public DateTime? ExecutionTime { get; set; }

        public string ErrorMessage { get; set; }

        public string Parameters { get; set; }

        public string QueryText { get; set; }

    }


}
