using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dashboard.Models
{
    public class TableDashboard
    {
        public List<string> ColumnNames { get; set; }
        public List<TableRow> Rows { get; set; }

    }
    public class TableRow   
    {
        public string[] Data { get; set; }
    }
    [Table("tabledashboardflow")]
    public class TableDashboardFlow
    {
        [Key]
        public int Id { get; set; }
        public string QueryName { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }

    }
}
