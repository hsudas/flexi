using Flexi.WebUI.Models.Report;
using System.Collections.Generic;

namespace Flexi.WebUI.Models
{
    public class Graph
    {
        public Graph()
        {
            data = new List<double>();
        }
        public string name { get; set; }
        public List<double> data { get; set; }

        
    }
    public class GraphCollection
    {
        public List<Graph> GraphList { get; set; }
        public string[] XAxis { get; set; }

        public SummaryDataModel SDM { get; set; }
    }
     public class SummaryDataModel
    {
        public OrderSummary MainSummary { get; set; }
        public OrderSummary ThisWeekSoFar { get; set; }

        public OrderSummary LastWeek { get; set; }

        public OrderSummary ThisWeekLastYear { get; set; }
        public OrderSummary ChangeFromLastWeek { get; set; }

        public OrderSummary ChangeFromLastYear { get; set; }

    }
}