
using Flexi.Model.DM;
using System.Collections.Generic;

namespace Flexi.WebUI.Models
{
    public class DataManagementModel
    {
        public DataManagementColumns[] Columns { get; set; }
        public List<string[]> Data { get; set; }
        public List<DMColumnRelation> ColumnRelations { get; set; }
        public string QueryName { get; set; }
        public string Definition { get; set; }
    }
    public class DataManagementColumns
    {
        public string title { get; set; }
        public string DataType { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsEditable { get; set; }

    }
}