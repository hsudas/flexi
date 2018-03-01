using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Application
{
    public class ReportDefinition
    {
        public int ReportId { get; set; }

        public string ReportName { get; set; }

        public int? QueryId { get; set; }
        public int? ChartQueryId { get; set; }

        public int? ReportType { get; set; }

        public int Status { get; set; }
        public string Category { get; set; }

    }
    public class ReportParameter
    {
        public int ReportParameterId { get; set; }

        public string ParameterKey { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }

        public string Type { get; set; }

        public string DefaultValue { get; set; }

        public int ReportId { get; set; }

    }



}
