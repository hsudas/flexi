
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flexi.Model.Entity.Dashboard;
using Dapper.Contrib.Extensions;

namespace Flexi.Model.DM
{
    /// <summary>
    /// Base table of Royal.Dashboard > DataManagement module
    /// </summary>
    public class DMDefinition
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string QueryName { get; set; }
        public int Status { get; set; }
    }
    /// <summary>
    /// Related with Royal.Dashboard > DataManagement module
    ///  Stores the relations between table unique key column and unique column of specific query
    /// </summary>
    public class DMColumnRelation
    {
        public int Id { get; set; }
        public int DMId { get; set; }
        public string TableName { get; set; }
        public string TableColumnName { get; set; }
        public string QueryColumnName { get; set; }
        [Computed]
        public string QueryKeyValue { get; set; }
        [Computed]
        public List<TableStructure> TableColumns { get; set; }
    }
    /// <summary>
    /// Related with Royal.Dashboard > DataManagement module
    /// Stores the fields of Criteria section
    /// </summary>
    public class DMParameter
    {
        public int Id { get; set; }
        public int DMId { get; set; }
        public string ParameterKey { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string DefaultValue { get; set; }
        public string DataType { get; set; }
    }

    public class TableStructure
    {
        public string data_type { get; set; }
        public string column_name { get; set; }
        public string is_nullable { get; set; }
        public string column_default { get; set; }
        [Computed]
        public List<AppEnum> enum_values { get; set; }
    }



}
