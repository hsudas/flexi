using Dapper;
using Flexi.WebUI;
using Flexi.WebUI.Controllers;
using Flexi.WebUI.Models.Report;
using Flexi.WebUI.Utility;
using Dynamite.Extensions;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using Npgsql;
using Flexi.Business.Business.DB;
using Flexi.Model.Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;

namespace Royal.Flexi.WebUI.Controllers
{
    [System.Web.Mvc.Authorize]
    public class ReportController : Controller
    {
        string conStr = ConnectionStringManager.ProdConnectionString;
        NpgsqlConnection con = new NpgsqlConnection();
        // GET: Report
        
        public ActionResult GenericReport()
        {
            if (MenuRestriction.CheckUserMenuAuth(User.Identity.GetUserId(), HttpContext) == false)
            {
                return RedirectToAction("NotAuthorized", "Home");
            }
            return View();
        }
        public ActionResult InventoryReport()
        {
            return View();
        }
        public ActionResult BaseReport(string ReportId = "",string ReportName = "")
        {
            if (MenuRestriction.CheckUserMenuAuth(User.Identity.GetUserId(), HttpContext) == false)
            {
                return RedirectToAction("NotAuthorized", "Home");
            }
            List<ReportParameter> rpList = new List<ReportParameter>();
            ReportManager rm = new ReportManager(conStr);
            int rid = 0;
            if (ReportId != "")
            {
                rid = Convert.ToInt32(ReportId);
                
            }
            rpList = rm.GetReportParameters(rid);
            ReportDefinition report = rm.GetReportObj(rid);
            if (report != null && report.ChartQueryId != null && report.ChartQueryId > 0)
            {
                ViewData["chartHidden"] = "block";
            }
            else
            {
                ViewData["chartHidden"] = "none";
            }
            if (rpList.Count > 0)
            {
                ViewData["filterHidden"] = "block";
            }
            else
            {
                ViewData["filterHidden"] = "none";
            }
            ViewData["filters"] = rpList;
            return View();
        }

        OrderSummary os;
        public OrderSummary GetReportDataWithSummary(List<Criterias> criteria,string userRestriction)
        {
            List<OrderReport> lst = new List<OrderReport>();
            OrderSummary os = new OrderSummary();
            
            using (con = new NpgsqlConnection(conStr))
            {
                string query = "salesreport";
                con.Open();
               
                string prQuery = "";

                if (criteria.Count > 0)
                {
                    prQuery = prQuery + "(1 = 0 ";
                }
                foreach (var item in criteria)
                {
                    prQuery = prQuery + " OR (1=1";

                    if (item.startdate != null)
                    {
                        prQuery = prQuery + " AND f.PostedDate >= '" + item.startdate + " 12:00:00 AM'";

                    }
                    if (item.enddate != null)
                    {
                        prQuery = prQuery + " AND f.PostedDate <= '" + item.enddate + " 11:59:59 PM'";

                    }
                    if (item.asin != null)
                    {
                        prQuery = prQuery + " AND s.asin = '" + item.asin + "'";
                    }
                    if (item.sku != null)
                    {
                        prQuery = prQuery + " AND s.sku = '" + item.sku + "'";
                    }
                    if (item.vendor != null)
                    {
                        prQuery = prQuery + " AND s.vendor = '" + item.vendor + "'";
                    }
                    if (item.skutitle != null)
                    {
                        prQuery = prQuery + " AND s.title like '%" + item.skutitle + "%'";
                    }
                    if (item.fulfill != null)
                    {
                        prQuery = prQuery + " AND s.fulfillmentby = '" + item.fulfill + "'";
                    }
                    prQuery = prQuery + ") ";
                }
                prQuery = prQuery + ")";
                if (userRestriction != "")
                {
                    prQuery = "(" + userRestriction + " AND " + prQuery + ")";
                }
                lst = con.Query<OrderReport>(query, new { parameterquery = prQuery }, commandType: CommandType.StoredProcedure).ToList<OrderReport>();

                long orderItems = 0;
                long unitsOrdered = 0;
                decimal orderProductSales = 0;
                decimal avgUnitsOrderedItem = 0;
                decimal avgSalesOrderedItem = 0;
                decimal refundAmount = 0;
                decimal profit = 0;
                foreach (var item in lst)
                {
                    orderItems = orderItems + item.OrderItem;
                    unitsOrdered = unitsOrdered + item.UnitsOrdered;
                    orderProductSales = orderProductSales + item.OrderUAmount;
                    refundAmount = refundAmount + item.RefundUAmount;
                    profit = profit + item.Profit;
                }
                if (lst.Count > 0)
                {
                    avgUnitsOrderedItem = Convert.ToDecimal(orderItems) / Convert.ToDecimal(unitsOrdered);
                    avgSalesOrderedItem = Math.Round(orderProductSales / orderItems, 3);
                    os.AvgSalesOrderItem = Math.Round(avgSalesOrderedItem, 3);
                    os.AvgUnitsOrderItem = Math.Round(avgUnitsOrderedItem, 3);
                    os.OrderedProductSales = orderProductSales;
                    os.TotalOrderItems = orderItems;
                    os.UnitsOrdered = unitsOrdered;
                    os.RefundAmount = refundAmount;
                    os.Profit = profit;
                }
                else
                {
                    os.AvgSalesOrderItem = 0;
                    os.AvgUnitsOrderItem = 0;
                    os.OrderedProductSales = 0;
                    os.Profit = 0;
                    os.RefundAmount = 0;
                    os.TotalOrderItems = 0;
                    os.UnitsOrdered = 0;
                }

                //TODO :  diğer alanlarda konacak.

              


            }
        
            return os;
        }
        private List<OrderReport> GetReportData(string jtSorting, List<Criterias> criteria)
        {
            List<OrderReport> lst = new List<OrderReport>();
            os = new OrderSummary();
            string userRestriction = UserRestriction.GetUserRestriction(User.Identity.GetUserName(), "OrderReport");
            if (userRestriction == "")
            {
                return lst;
            }
            string conStr = ConnectionStringManager.ProdConnectionString;
            using (con = new NpgsqlConnection(conStr))
            {
                
                string query = "salesreport";
                con.Open();

                //ToDo : sorgu dinamik hale getirilecek.
              
                string prQuery = "";
                
                if (criteria.Count > 0)
                {
                    prQuery = prQuery + "(1 = 0 ";
                }
                foreach (var item in criteria)
                {
                    prQuery = prQuery + " OR (1=1"; 
                    
                    if (item.startdate != null)
                    {
                        prQuery = prQuery + " AND f.PostedDate >= '" + item.startdate + " 12:00:00 AM'";
                        
                    }
                    if (item.enddate != null)
                    {
                        prQuery = prQuery + " AND f.PostedDate <= '" + item.enddate + " 11:59:59 PM'";

                    }
                    if (item.asin != null)
                    {
                        prQuery = prQuery + " AND s.asin = '" + item.asin + "'";
                    }
                    if (item.sku != null)
                    {
                        prQuery = prQuery + " AND s.sku = '" + item.sku + "'";
                    }
                    if (item.vendor != null)
                    {
                        prQuery = prQuery + " AND s.vendor = '" + item.vendor + "'";
                    }
                    if (item.skutitle != null)
                    {
                        prQuery = prQuery + " AND s.title like '%" + item.skutitle + "%'";
                    }
                    if (item.fulfill != null)
                    {
                        prQuery = prQuery + " AND s.FulfillmentBy = '" + item.fulfill + "'";
                        
                    }
                    prQuery = prQuery + ") ";
                }
                prQuery = prQuery + ")";
                if (userRestriction != "")
                {
                    prQuery = "(" + userRestriction + " AND " + prQuery + ")";
                }
                DbString str = new DbString();
                str.Value = prQuery;
                lst = con.Query<OrderReport>(query, new { parameterquery = str }, commandType: CommandType.StoredProcedure).ToList<OrderReport>();
              
                long orderItems = 0;
                long unitsOrdered = 0;
                decimal orderProductSales = 0;
                decimal avgUnitsOrderedItem = 0;
                decimal avgSalesOrderedItem = 0;
                decimal refundAmount = 0;
                decimal profit = 0;
                foreach (var item in lst)
                {
                    orderItems = orderItems + item.OrderItem;
                    unitsOrdered = unitsOrdered + item.UnitsOrdered;
                    orderProductSales = orderProductSales + item.OrderUAmount;
                    refundAmount = refundAmount + item.RefundUAmount;
                    profit = profit + item.Profit;
                }
                if (lst.Count>0)
                {
                    avgUnitsOrderedItem = Convert.ToDecimal(orderItems) / Convert.ToDecimal(unitsOrdered);
                    avgSalesOrderedItem = Math.Round(orderProductSales / orderItems, 3);
                    os.AvgSalesOrderItem = Math.Round(avgSalesOrderedItem, 3);
                    os.AvgUnitsOrderItem = Math.Round(avgUnitsOrderedItem, 3);
                    os.OrderedProductSales = orderProductSales;
                    os.TotalOrderItems = orderItems;
                    os.UnitsOrdered = unitsOrdered;
                    os.RefundAmount = refundAmount;
                    os.Profit = profit;
                }
                else
                {
                    os.AvgSalesOrderItem = 0;
                    os.AvgUnitsOrderItem = 0;
                    os.OrderedProductSales = 0;
                    os.Profit = 0;
                    os.RefundAmount = 0;
                    os.TotalOrderItems = 0;
                    os.UnitsOrdered = 0;
                }
                
                //TODO :  diğer alanlarda konacak.

                if (jtSorting != null&& jtSorting !="")
                {
                    lst.Sort(jtSorting);
                }


               
            }
            return lst;
        }
        public JsonResult GetOrderReportDate(string criteria = null, int jtStartIndex = 0, int jtPageSize = 0, string jtSorting = null)
        {

           
            List<OrderReport> lst = new List<OrderReport>();

            List<OrderReport> pagedLst = new List<OrderReport>();
            List<Criterias> criteriaList =  JsonConvert.DeserializeObject<List<Criterias>>(criteria);
            try
            {

                lst = GetReportData(jtSorting, criteriaList);

                if (((lst.Count - jtStartIndex) / jtPageSize) < 1)
                {
                    jtPageSize = lst.Count - jtStartIndex;
                }
                for (int i = jtStartIndex; i < jtStartIndex + jtPageSize; i++)
                {

                    pagedLst.Add(lst[i]);

                }

                return Json(new { Result = "OK", Records = pagedLst, TotalRecordCount = lst.Count,Summary = os }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { Result = "ERROR", Message = ex.Message }, JsonRequestBehavior.AllowGet);
            }

           
        }

        public void ExportClientsListToExcel(string criteria)
        {
            var grid = new System.Web.UI.WebControls.GridView();
            List<Criterias> criteriaList = JsonConvert.DeserializeObject<List<Criterias>>(criteria);
            List<OrderReport> lst = GetReportData("", criteriaList);
            grid.DataSource = lst;
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=Report_Data_"+DateTime.Now.ToString("yyyy")+ DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss") + ".xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            grid.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();

        }

        public void GetQueryResultAsExcel(int queryid)
        {
            var grid = new System.Web.UI.WebControls.GridView();
            QueryManager qm = new QueryManager(conStr);
            DataTable dt = qm.GetQueryResultDataTable(queryid, null);
            
            grid.DataSource = dt;
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=Report_Data_" + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss") + ".xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            grid.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();

        }
        #region INVENTORY REPORT

        #endregion
    }
}
