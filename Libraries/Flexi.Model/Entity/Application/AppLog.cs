
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Application
{
    [Table("AppLog")]
    public class AppLog
    {
        [Key]
        public long LogId { get; set; }

        public string Description { get; set; }

        public string UserName { get; set; }

        public short? LogType { get; set; }


        public string Action { get; set; }

        public string ClassName { get; set; }

    }

}
