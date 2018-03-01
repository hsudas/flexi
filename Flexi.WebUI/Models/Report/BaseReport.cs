using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.WebUI.Models.Report
{
    public class BaseReport
    {
        public ReportDataColumn[] columns{get;set;}
        public List<string[]> data{get;set;}
        public GraphCollection ReportChart { get; set; }
    }

    public class ReportDataColumn
    {
        public string title { get; set; }
    }
   
}
