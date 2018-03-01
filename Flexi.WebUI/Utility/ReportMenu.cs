using Flexi.Business.Business.DB;
using Flexi.Model.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flexi.WebUI.Utility
{
    public static class ReportMenu
    {
        public static List<ReportDefinition> ReportList()
        {
            List<ReportDefinition> lst = new List<ReportDefinition>();
            ReportManager rm = new ReportManager(ConnectionStringManager.ProdConnectionString);
            lst = rm.GetReportList();
            return lst;

        }
        public static List<string> GetCategories()
        {
            ReportManager rm = new ReportManager(ConnectionStringManager.ProdConnectionString);
            return rm.GetCategories();
        }
        public static List<ReportDefinition> ReportListByCategory(string category, List<ReportDefinition> reportList)
        {
            ReportManager rm = new ReportManager(ConnectionStringManager.ProdConnectionString);
            return rm.GetReportsByCategory(category, reportList);
        }

    }
}
