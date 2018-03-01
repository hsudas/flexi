using Flexi.Shared.Helper;
using Flexi.Model.DM;
using Flexi.Business.Business.DB;
using Flexi.Model.DB;
using Flexi.WebUI.Utility;
using Microsoft.AspNet.Identity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Flexi.Model.DB;

namespace Flexi.WebUI.Controllers
{
    [System.Web.Mvc.Authorize(Roles = "administrator")]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Content()
        {
            return View();
        }

        public ActionResult Customer()
        {
            return View();
        }

        public ActionResult ServerPerformance()
        {
            return View();
        }
        public ActionResult AuditQuery()
        {

            if (MenuRestriction.CheckUserMenuAuth(User.Identity.GetUserId(), HttpContext) == false)
            {
                return RedirectToAction("NotAuthorized", "Home");
            }
            return View();
        }
        public ActionResult TableDashboard()
        {

            //if (MenuRestriction.CheckUserMenuAuth(User.Identity.GetUserId(), HttpContext) == false)
            //{
            //    return RedirectToAction("NotAuthorized", "Home");
            //}
            return View();
        }
        [AllowAnonymous]
        public ActionResult TableDashboardFullMode()
        {

            //if (MenuRestriction.CheckUserMenuAuth(User.Identity.GetUserId(), HttpContext) == false)
            //{
            //    return RedirectToAction("NotAuthorized", "Home");
            //}
            return View();
        }
        public ActionResult NotAuthorized()
        {
            return View();
        }


        public ActionResult SalesReport2()
        {
            if (MenuRestriction.CheckUserMenuAuth(User.Identity.GetUserId(), HttpContext) == false)
            {
                return RedirectToAction("NotAuthorized", "Home");
            }
            return View();
        }
        #region "Operation Menu"
        public ActionResult DataManagement(string dmId = "")
        {
            //if (MenuRestriction.CheckUserMenuAuth(User.Identity.GetUserId(), HttpContext) == false)
            //{
            //    return RedirectToAction("NotAuthorized", "Home");
            //}
            List<DMParameter> dmList = new List<DMParameter>();

            int rid = 0;
            if (dmId != "")
            {
                rid = Convert.ToInt32(dmId);
                ViewData["dataHidden"] = "block";
            }
            else
            {
                ViewData["dataHidden"] = "none";
            }
            QueryManager qm = new QueryManager();
            List<IDataParameter> paramlist = new List<IDataParameter>();
            paramlist.Add(new CustomParameter() { DbType = DbType.Int32, ParameterName = "dmid", Value = rid });
            dmList = qm.GetQueryResultDirect<DMParameter>("SELECT * FROM dmparameter WHERE dmid = @dmid", paramlist);
            ViewData["filters"] = dmList;
            if (dmList.Count == 0)
            {
                ViewData["criteriaHidden"] = "none";
            }
            else
            {
                ViewData["criteriaHidden"] = "block";
            }

            return View();
        }
        public ActionResult UploadFedexReport()
        {
            return View();
        }
        #endregion
        #region "Partial View"
        [HttpPost]
        public ActionResult UploadExcel(HttpPostedFileBase postedFile, string reportName, string dmId)
        {
            string filePath = string.Empty;
            if (string.IsNullOrEmpty(reportName))
            {
                TempData["ResponseCode"] = "Please enter a report type!";
                return View();
            }
            string tableName = reportName;
            if (postedFile != null)
            {
                int tableColumnCount = GetColumnCount();
                //string tableName = TableName;
                string path = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);

                string conString = string.Empty;
                switch (extension)
                {
                    case ".xls": //Excel 97-03.
                        conString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                        break;
                    case ".xlsx": //Excel 07 and above.
                        conString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                        break;
                }

                DataTable dt = new DataTable();
                conString = string.Format(conString, filePath);

                using (OleDbConnection connExcel = new OleDbConnection(conString))
                {
                    using (OleDbCommand cmdExcel = new OleDbCommand())
                    {
                        using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                        {
                            cmdExcel.Connection = connExcel;

                            //Get the name of First Sheet.
                            connExcel.Open();
                            DataTable dtExcelSchema;
                            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                            string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                            connExcel.Close();

                            //Read Data from First Sheet.
                            connExcel.Open();
                            cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                            odaExcel.SelectCommand = cmdExcel;
                            odaExcel.Fill(dt);
                            connExcel.Close();
                        }
                    }
                }

                using (NpgsqlConnection connection = new NpgsqlConnection(ConfigHelper.Instance.GetDBContext()))
                {
                    connection.Open();
                    using (NpgsqlTransaction tran = connection.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted))
                    {
                        string insertQuery = "";
                        try
                        {
                            foreach (DataRow item in dt.Rows)
                            {
                                insertQuery = GenerateIndexQuery(dt.Columns, item, tableName, tableColumnCount);
                                NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, connection, tran);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                        tran.Commit();
                        TempData["ResponseCode"] = "All rows of the report:" + tableName + "  are successfully inserted.";
                    }
                }
            }

            return RedirectToAction("UploadFedexReport");
        }
        #endregion
        private bool CheckUserMenuAuth()
        {

            string id = User.Identity.GetUserId();
            var rd = HttpContext.Request.RequestContext.RouteData;
            string currentAction = rd.Values["action"].ToString();
            QueryManager qm = new QueryManager(ConnectionStringManager.ProdConnectionString);
            List<IDataParameter> lstprm = new List<IDataParameter>();
            lstprm.Add(new CustomParameter("UserId", id));
            lstprm.Add(new CustomParameter("MenuName", currentAction));
            List<int> lst = qm.GetQueryResult<int>("CheckUserMenu", lstprm);
            if (lst[0] > 0)
            {
                return true;
            }
            return false;
        }
        private int GetColumnCount()
        {

            return new QueryManager(ConfigHelper.Instance.GetDBContext()).GetQueryResultDirect<byte>("select count(1) from information_schema.columns where table_name = 'fedexcustomreport' and table_schema = 'rpr' and column_name like '%col%'")[0];
        }
        private string GenerateIndexQuery(DataColumnCollection columnList, DataRow drow, string tableName, int tableColumnCount)
        {
            StringBuilder sb = new StringBuilder();
            string comma = ",";
            sb.Append("INSERT INTO ");
            sb.Append("rpr.fedexcustomreport(");
            StringBuilder sbValues = new StringBuilder();
            sbValues.Append(" VALUES(");
            int index = 0;
            int columnCount = columnList.Count;

            if (columnCount > tableColumnCount)
            {
                columnCount = tableColumnCount;
            }
            for (int i = 0; i < columnCount; i++)
            {
                if (index == columnCount - 1)
                {
                    comma = "";
                }
                sb.Append("col" + (i + 1).ToString().ToString() + comma);
                if (string.IsNullOrEmpty(drow[columnList[i]].ToString()))
                {
                    sbValues.Append("NULL" + comma);

                }
                else
                {
                    sbValues.Append("'" + drow[columnList[i]].ToString().Replace("'", "''") + "'" + comma);
                }

                index++;
            }
            sb.Append(",reporttype");
            sb.Append(") ");
            sbValues.Append(",'" + tableName + "'");
            sbValues.Append(") ");
            return sb.ToString() + sbValues.ToString();
        }

    }
}