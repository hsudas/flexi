using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model
{
    public class FileMapping
    {
        [Key]
        public int ID { get; set; }
        public string FileColumnName { get; set; }
        public string DbColumnName { get; set; }
        public string TableName { get; set; }
        public string DataType { get; set; }
    }
}
