using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using Flexi.Model.Application;
using Npgsql;
namespace Flexi.Business.Business.DB
{
    public class ReportManager
    {
        NpgsqlConnection con;
        string conStr = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="conStr">Db Connection String</param>
        public ReportManager(string conStr)
        {
            this.conStr = conStr;
        }

        public ReportDefinition GetReportObj(int reportId)
        {

            ReportDefinition rp = null;
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                string queryText = "Select * From ReportDefinition Where ReportId = @ReportId And Status = 1";
                var result =  con.Query<ReportDefinition>(queryText, new { ReportId = reportId }).ToList<ReportDefinition>();
                if (result.Count > 0)
                {
                    rp = result[0];
                }
                
            }
            return rp;
        }
        public List<ReportDefinition> GetReportList()
        {
            List<ReportDefinition> rp = new List<ReportDefinition>();
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                string queryText = "Select * From ReportDefinition Where Status = 1";
                rp = con.Query<ReportDefinition>(queryText).ToList<ReportDefinition>();


            }
            return rp;
        }
        public List<ReportDefinition> GetReportList(string email)
        {
            List<ReportDefinition> rp = new List<ReportDefinition>();
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("select distinct r.* from reportdefinition r inner join appmenu m on r.reportname = m.name ");
                sb.Append(" inner join appmenuuser mu on mu.menuid = m.menuid inner join aspnetusers u on mu.userid = u.id");
                sb.Append(" where r.status = 1 and u.email = @email;");
                rp = con.Query<ReportDefinition>(sb.ToString(),new { email = email}).ToList<ReportDefinition>();


            }
            return rp;
        }
        public List<string> GetCategories()
        {
            List<string> rp = new List<string>();
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                string queryText = "Select distinct category From ReportDefinition Where Status = 1 order by category NULLS LAST";
                rp = con.Query<string>(queryText).ToList<string>();


            }
            return rp;
        }
        public List<ReportDefinition> GetReportsByCategory(string categoryName,List<ReportDefinition> reportList)
        {
           
            return reportList.Where<ReportDefinition>(rep => rep.Category == categoryName).ToList<ReportDefinition>();
        }
        public List<ReportParameter> GetReportParameters(int reportId)
        {
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                string queryText = "Select * From ReportParameter rp  Where rp.ReportId = @ReportId order by reportparameterid";
                return con.Query<ReportParameter>(queryText,new {ReportId = reportId}).ToList<ReportParameter>();


            }
        }
    }
}
