using Flexi.Shared.Helper;
using Flexi.Business.Business.DB;
using Flexi.Model.Application;
using Dapper;
using Flexi.WebUI.Models;
using Flexi.WebUI.Models.Report;
using Microsoft.AspNet.Identity;
using Npgsql;
using Royal.Flexi.WebUI.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;

namespace Flexi.WebUI.Controllers
{
    public class ReportDataController : ApiController
    {
        string conStr = ConfigHelper.Instance.GetDBContext();
        NpgsqlConnection con;
        [HttpPost]
        public GraphCollection GetRealData([FromBody]List<Criterias> criteria)
        {
            string userRestriction = Flexi.WebUI.Utility.UserRestriction.GetUserRestriction(User.Identity.GetUserName(), "SalesChart");

            GraphCollection gc = GetDataFromDb(criteria, userRestriction);
            //gc.SDM = LoadSummary(criteria,userRestriction);
            return gc;
        }
        [HttpPost]
        public SummaryDataModel GetSummaryData([FromBody]List<Criterias> criteria)
        {
            string userRestriction = Flexi.WebUI.Utility.UserRestriction.GetUserRestriction(User.Identity.GetUserName(), "SalesChart");
            return LoadSummary(criteria, userRestriction);

        }
        private GraphCollection GetDataFromDb(List<Criterias> criteria, string userRestriction)
        {
            List<Criterias> result = criteria;  //Newtonsoft.Json.JsonConvert.DeserializeObject<List<Criterias>>(command);
            GraphCollection gc = new GraphCollection();
            List<Graph> lst = new List<Graph>();
            //DateTime max = new DateTime(1900, 1, 1);
            //DateTime min = new DateTime(2050, 1, 1);
            string period = "";

            if (userRestriction == "")
            {
                return null;
            }

            string[] xArr = null;

            foreach (var item in result)
            {
                period = item.period;
                string sd = item.startdate;
                string ed = item.enddate;
                string fulfill = item.fulfill;
                DateTime max = Convert.ToDateTime(ed);
                max = new DateTime(max.Year, max.Month, max.Day, 23, 59, 59);

                DateTime min = Convert.ToDateTime(sd);
                min = new DateTime(min.Year, min.Month, min.Day, 00, 00, 00);


                if (result.Count > 1)
                {
                    if (item.xperiod == "Last Week")
                    {
                        min = min.AddDays(-7);
                        max = max.AddDays(-7);
                    }
                    else if (item.xperiod == "Last Month")
                    {
                        min = min.AddMonths(-1);
                        max = max.AddMonths(-1);
                    }
                    else if (item.xperiod == "Last Year")
                    {
                        min = min.AddYears(-1);
                        max = max.AddYears(-1);

                    }
                }

                using (con = new NpgsqlConnection(conStr))
                {
                    lock (con)
                    {
                        con.Open();
                        var qry = "";
                        string crt = "";
                        var dbArgs = new DynamicParameters();
                        dbArgs.Add("StartDate", min, DbType.DateTime, ParameterDirection.Input, null);
                        dbArgs.Add("EndDate", max, DbType.DateTime, ParameterDirection.Input, null);
                        dbArgs.Add("fulfill", item.fulfill, DbType.String, ParameterDirection.Input, null);

                        if (item.sku != null)
                        {
                            crt = crt + " AND f.SKU = @SKU ";
                            dbArgs.Add("SKU", item.sku, DbType.String, ParameterDirection.Input, null);

                        }
                        if (item.skutitle != null)
                        {
                            crt = crt + " AND s.Title Like '%' + @Title + '%' ";
                            dbArgs.Add("Title", item.skutitle, DbType.String, ParameterDirection.Input, null);

                        }
                        if (item.vendor != null)
                        {
                            crt = crt + " AND s.Vendor  = @Vendor ";
                            dbArgs.Add("Vendor", item.vendor, DbType.String, ParameterDirection.Input, null);

                        }
                        if (item.asin != null)
                        {
                            crt = crt + " AND s.Asin  = @ASIN ";
                            dbArgs.Add("Asin", item.asin, DbType.String, ParameterDirection.Input, null);

                        }
                        if (item.fulfill != null)
                        {
                            crt = crt + " AND s.FulfillmentBy  = @fulfill ";
                            dbArgs.Add("fulfill", item.fulfill, DbType.String, ParameterDirection.Input, null);

                        }
                        crt = crt + " AND (" + userRestriction + ")";

                        string dataType = GetDataTypeColumn(item.datatype);
                        if (period == "Monthly")
                        {
                            //qry = " Select date, " + dataType + " as val from" +
                            //   " (SELECT cast(varchar,datename(month,PostedDate)) + ' ' + cast(varchar,datepart(year,posteddate)) as date, f.SKU SKU, Sum(coalesce(AmountOrder, 0)) Order_Amount, sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity))   Order_Quantity" +
                            //   " , Sum(coalesce(AmountRefund, 0)) Refund_Amount, sum((sign(abs(coalesce(AmountRefund, 0))) * f.quantity)) 'Refund U Quantity', Sum(coalesce(AmountAdjustment, 0)) + Sum(coalesce(AmountChargeback, 0)) + Sum(coalesce(AmountServiceFee, 0)) + Sum(coalesce(AmountGuarantee, 0)) AmountOther" +
                            //   " , sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity))  + sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity)) QuantityOther, coalesce(max(s.Cost), 0) * -1   unitcost" +
                            //   " , (sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity))  + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity))) *" +
                            //   " coalesce(max(s.Cost), 0) * -1  TotalCost, Sum(coalesce(AmountOrder, 0)) + Sum(coalesce(AmountRefund, 0)) + Sum(coalesce(AmountAdjustment, 0))  + Sum(coalesce(AmountChargeback, 0))   + Sum(coalesce(AmountServiceFee, 0))  + Sum(coalesce(AmountGuarantee, 0))   + ((sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity))) * coalesce(max(s.Cost), 0) * -1) profit" +
                            //   " FROM dbo.FinancialReport f left join dbo.sku s  on  s.SKU = f.sku " +
                            //   " where PostedDate between @StartDate and @EndDate " +
                            //    crt + 
                            //   " group by datename(month,PostedDate),datepart(month,PostedDate),datepart(year,posteddate),f.sku   ) k  group by date order by cast(date,date)";

                            qry =
                               "Select date, " + dataType + "  as val" +
                               "  from (SELECT  extract(month from posteddate) || ' ' || extract(year from posteddate)   as date," +
                               " f.SKU SKU, Sum(coalesce(AmountOrder, 0)) Order_Amount, sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity))   Order_Quantity , Sum(coalesce(AmountRefund, 0)) Refund_Amount, sum((sign(abs(coalesce(AmountRefund, 0))) * f.quantity)) RefundUQuantity, " +
                               " Sum(coalesce(AmountAdjustment, 0)) + Sum(coalesce(AmountChargeback, 0)) + Sum(coalesce(AmountServiceFee, 0)) + Sum(coalesce(AmountGuarantee, 0)) AmountOther , " +
                               " sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity))  + sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity)) QuantityOther, coalesce(max(s.Cost), 0) * -1   unitcost , (sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity))  + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity))) * coalesce(max(s.Cost), 0) * -1  TotalCost, Sum(coalesce(AmountOrder, 0)) + Sum(coalesce(AmountRefund, 0)) + Sum(coalesce(AmountAdjustment, 0))  + Sum(coalesce(AmountChargeback, 0))   + Sum(coalesce(AmountServiceFee, 0))  + Sum(coalesce(AmountGuarantee, 0))   + ((sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity))) * coalesce(max(s.Cost), 0) * -1) profit " +
                               " FROM FinancialReport f left join sku s  on  s.SKU = f.sku  " +
                               "  where PostedDate between @StartDate and @EndDate " + crt + " group by  extract(month from posteddate), extract(year from posteddate) ,f.sku   ) k   group by k.date order by date ";



                        }
                        else if (period == "Weekly")
                        {
                            qry =
                                 "Select date,w,y,  " + dataType + "  as val" +
                                 " from  (SELECT  extract(week from posteddate) as w,extract(year from posteddate) as y ,   'Week ' ||  cast( extract(week from posteddate) as varchar(20)) || ' ' || cast(extract(year from posteddate) as varchar(4))  as date," +
                                 " f.SKU SKU, Sum(coalesce(AmountOrder, 0)) Order_Amount, sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity))   Order_Quantity , Sum(coalesce(AmountRefund, 0)) Refund_Amount, sum((sign(abs(coalesce(AmountRefund, 0))) * f.quantity)) RefundUQuantity, " +
                                 " Sum(coalesce(AmountAdjustment, 0)) + Sum(coalesce(AmountChargeback, 0)) + Sum(coalesce(AmountServiceFee, 0)) + Sum(coalesce(AmountGuarantee, 0)) AmountOther , " +
                                 " sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity))  + sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity)) QuantityOther, coalesce(max(s.Cost), 0) * -1   unitcost , (sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity))  + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity))) * coalesce(max(s.Cost), 0) * -1  TotalCost, Sum(coalesce(AmountOrder, 0)) + Sum(coalesce(AmountRefund, 0)) + Sum(coalesce(AmountAdjustment, 0))  + Sum(coalesce(AmountChargeback, 0))   + Sum(coalesce(AmountServiceFee, 0))  + Sum(coalesce(AmountGuarantee, 0))   + ((sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity))) * coalesce(max(s.Cost), 0) * -1) profit " +
                                 " FROM FinancialReport f left join sku s  on  s.SKU = f.sku  " +
                                 "  where PostedDate between @StartDate and @EndDate " + crt + " group by  extract(year from posteddate), extract(week from posteddate) ,f.sku   ) k   group by y,w,date order by y,w ";


                        }
                        else
                        {
                            qry = "Select date,  " + dataType + "  as val from " +
                            " (SELECT cast(PostedDate as date) as date, f.SKU SKU, Sum(coalesce(AmountOrder, 0)) Order_Amount, " +
                            " sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity))   Order_Quantity , Sum(coalesce(AmountRefund, 0)) Refund_Amount, " +
                            " sum((sign(abs(coalesce(AmountRefund, 0))) * f.quantity))  as RefundUQuantity, " +
                            " Sum(coalesce(AmountAdjustment, 0)) + Sum(coalesce(AmountChargeback, 0)) + Sum(coalesce(AmountServiceFee, 0)) + Sum(coalesce(AmountGuarantee, 0)) AmountOther , " +
                            " sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity))  + sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity)) QuantityOther, " +
                            " coalesce(max(s.Cost), 0) * -1   unitcost , " +
                            " (sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity))  + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity))) * coalesce(max(s.Cost), 0) * -1  TotalCost, " +
                            " Sum(coalesce(AmountOrder, 0)) + Sum(coalesce(AmountRefund, 0)) + Sum(coalesce(AmountAdjustment, 0))  + Sum(coalesce(AmountChargeback, 0))   + Sum(coalesce(AmountServiceFee, 0))  + Sum(coalesce(AmountGuarantee, 0))   + ((sum((sign(abs(coalesce(AmountOrder, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountAdjustment, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountChargeback, 0))) * f.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * f.quantity))+ sum((sign(abs(coalesce(AmountGuarantee, 0))) * f.quantity))) * coalesce(max(s.Cost), 0) * -1) profit" +
                             " FROM FinancialReport f left join sku s  on  s.SKU = f.sku  where PostedDate between @StartDate and @EndDate  " + crt + " group by cast(PostedDate as date),f.sku) k  group by date";

                        }
                        List<GraphData> gr = con.Query<GraphData>(qry, dbArgs).ToList<GraphData>();


                        // xArr = new string[gr.Count];
                        List<double> d = new List<double>();
                        List<string> dt = new List<string>();
                        GraphData grTmp = null;
                        DateTime xmin = min;


                        int ticks = 0;
                        if (period == "Daily")
                        {
                            ticks = Convert.ToInt32((max - min).TotalDays);
                        }
                        else if (period == "Weekly")
                        {
                            ticks = (Convert.ToInt32((max - min).TotalDays) / 7);
                        }
                        else
                        {
                            ticks = (Convert.ToInt32((max - min).TotalDays) / 30);
                        }
                        string dtStr;
                        for (int i = 0; i < ticks; i++)
                        {
                            dtStr = "";

                            if (period == "Monthly")
                            {
                                dt.Add(xmin.ToString("MMM yy"));

                            }
                            else if (period == "Weekly")
                            {
                                var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
                                dtStr = "Week " + cal.GetWeekOfYear(xmin, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Sunday).ToString() + " " + xmin.Year;

                                dt.Add(dtStr);

                            }
                            else
                            {
                                dt.Add(xmin.ToString().Replace(" 12:00:00 AM", string.Empty));

                            }
                            grTmp = null;
                            for (var idx = 0; idx < gr.Count; idx++)
                            {
                                var gg = gr[idx] as GraphData;
                                if (period == "Weekly")
                                {

                                    if (gg != null && gg.date == dtStr)
                                    {
                                        grTmp = gg;
                                    }

                                }
                                else
                                {
                                    if (gg != null && Convert.ToDateTime(gg.date) == xmin)
                                    {
                                        grTmp = gg;
                                    }
                                }

                            }

                            if (grTmp != null)
                            {
                                d.Add(grTmp.val);

                            }
                            else
                            {
                                d.Add(0);

                            }
                            if (period == "Daily")
                            {
                                xmin = xmin.AddDays(1);

                            }
                            else if (period == "Weekly")
                            {
                                xmin = xmin.AddDays(7);
                            }
                            else
                            {
                                xmin = xmin.AddMonths(1);

                            }

                        }
                        if (xArr == null)
                        {
                            xArr = dt.ToArray();

                        }

                        string strX = sd + "-" + ed;

                        if (item.xperiod != null)
                        {
                            strX = min.ToString("MM/dd/yyyy") + "-" + max.ToString("MM/dd/yyyy");
                            strX += "#" + item.xperiod;
                        }
                        if (item.datatype != null)
                        {
                            strX += "#" + item.datatype;
                        }
                        if (item.sku != null)
                        {
                            strX += "#" + item.sku;
                        }
                        if (item.vendor != null)
                        {
                            strX += "#" + item.vendor;
                        }
                        if (item.asin != null)
                        {
                            strX += "#" + item.asin;
                        }

                        lst.Add(new Graph { name = strX, data = d });

                    }


                }

            }


            gc.XAxis = xArr;
            gc.GraphList = lst;
            return gc;
        }

        private SummaryDataModel LoadSummary(List<Criterias> criteria, string userRestriction)
        {
            SummaryDataModel sdm = new SummaryDataModel();
            ReportController rc = new ReportController();
            //Loading MainSummary
            OrderSummary result = rc.GetReportDataWithSummary(criteria, userRestriction);
            sdm.MainSummary = result;
            //Loading This Week So Far
            //First day of selected week is :
            System.Globalization.CultureInfo ci = System.Threading.Thread.CurrentThread.CurrentCulture;
            DayOfWeek fdow = ci.DateTimeFormat.FirstDayOfWeek;
            DayOfWeek today = DateTime.Now.DayOfWeek;
            DateTime sow = DateTime.Now.AddDays(-(today - fdow)).Date;

            foreach (var item in criteria)
            {
                item.startdate = sow.Month + "/" + sow.Day + "/" + sow.Year;
                item.enddate = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
            }
            result = rc.GetReportDataWithSummary(criteria, userRestriction);
            sdm.ThisWeekSoFar = result;

            //Last Week
            DateTime lw = sow.AddDays(-7);
            foreach (var item in criteria)
            {
                item.startdate = lw.Month + "/" + lw.Day + "/" + lw.Year;
                item.enddate = sow.Month + "/" + sow.Day + "/" + sow.Year;
            }
            result = rc.GetReportDataWithSummary(criteria, userRestriction);
            sdm.LastWeek = result;
            //This Week Last Year
            DateTime lys = sow.AddYears(-1);
            DateTime lye = DateTime.Now.AddYears(-1);
            foreach (var item in criteria)
            {
                item.startdate = lys.Month + "/" + lys.Day + "/" + lys.Year;
                item.enddate = lye.Month + "/" + lye.Day + "/" + lye.Year;
            }
            result = rc.GetReportDataWithSummary(criteria, userRestriction);
            sdm.ThisWeekLastYear = result;


            OrderSummary changefrLw = new OrderSummary();
            if (sdm.ThisWeekSoFar.UnitsOrdered > 0)
            {
                changefrLw.UnitsOrderedPercent = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.UnitsOrdered - sdm.LastWeek.UnitsOrdered) / Convert.ToDecimal(sdm.ThisWeekSoFar.UnitsOrdered) * 100), 3);

            }
            if (sdm.ThisWeekSoFar.TotalOrderItems > 0)
            {
                changefrLw.TotalOrderItemsPercent = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.TotalOrderItems - sdm.LastWeek.TotalOrderItems) / Convert.ToDecimal(sdm.ThisWeekSoFar.TotalOrderItems) * 100), 3);
            }
            if (sdm.ThisWeekSoFar.OrderedProductSales > 0)
            {
                changefrLw.OrderedProductSales = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.OrderedProductSales - sdm.LastWeek.OrderedProductSales) / Convert.ToDecimal(sdm.ThisWeekSoFar.OrderedProductSales) * 100), 3);

            }
            if (sdm.ThisWeekSoFar.AvgUnitsOrderItem > 0)
            {
                changefrLw.AvgUnitsOrderItem = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.AvgUnitsOrderItem - sdm.LastWeek.AvgUnitsOrderItem) / Convert.ToDecimal(sdm.ThisWeekSoFar.AvgUnitsOrderItem) * 100), 3);

            }
            if (sdm.ThisWeekSoFar.AvgSalesOrderItem > 0)
            {
                changefrLw.AvgSalesOrderItem = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.AvgSalesOrderItem - sdm.LastWeek.AvgSalesOrderItem) / Convert.ToDecimal(sdm.ThisWeekSoFar.AvgSalesOrderItem) * 100), 3);
            }

            sdm.ChangeFromLastWeek = changefrLw;



            OrderSummary changefrLy = new OrderSummary();
            if (sdm.ThisWeekSoFar.UnitsOrdered > 0)
            {
                changefrLy.UnitsOrderedPercent = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.UnitsOrdered - sdm.ThisWeekLastYear.UnitsOrdered) / Convert.ToDecimal(sdm.ThisWeekSoFar.UnitsOrdered) * 100), 3);

            }

            if (sdm.ThisWeekSoFar.TotalOrderItems > 0)
            {
                changefrLy.TotalOrderItemsPercent = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.TotalOrderItems - sdm.ThisWeekLastYear.TotalOrderItems) / Convert.ToDecimal(sdm.ThisWeekSoFar.TotalOrderItems) * 100), 3);

            }
            if (sdm.ThisWeekSoFar.OrderedProductSales > 0)
            {
                changefrLy.OrderedProductSales = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.OrderedProductSales - sdm.ThisWeekLastYear.OrderedProductSales) / Convert.ToDecimal(sdm.ThisWeekSoFar.OrderedProductSales) * 100), 3);

            }
            if (sdm.ThisWeekSoFar.AvgUnitsOrderItem > 0)
            {
                changefrLy.AvgUnitsOrderItem = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.AvgUnitsOrderItem - sdm.ThisWeekLastYear.AvgUnitsOrderItem) / Convert.ToDecimal(sdm.ThisWeekSoFar.AvgUnitsOrderItem) * 100), 3);

            }
            if (sdm.ThisWeekSoFar.AvgSalesOrderItem > 0)
            {
                changefrLy.AvgSalesOrderItem = Math.Round((Convert.ToDecimal(sdm.ThisWeekSoFar.AvgSalesOrderItem - sdm.ThisWeekLastYear.AvgSalesOrderItem) / Convert.ToDecimal(sdm.ThisWeekSoFar.AvgSalesOrderItem) * 100), 3);

            }
            sdm.ChangeFromLastYear = changefrLy;


            return sdm;


        }
        public string GetDataTypeColumn(string datatype)
        {
            string dtc = "";
            switch (datatype)
            {
                case "OrderUAmount":
                    dtc = " sum(Order_Amount) ";
                    break;
                case "OrderUQuantity":
                    dtc = " sum(Order_Quantity) ";
                    break;
                case "RefundUAmount":
                    dtc = " sum(Refund_Amount)*-1 ";
                    break;
                case "AmountOther":
                    dtc = "  sum(AmountOther) ";
                    break;
                case "UnitCost":
                    dtc = " sum(unitcost) *-1  ";
                    break;
                case "TotalCost":
                    dtc = " sum(TotalCost)*-1  ";
                    break;
                case "Profit":
                    //   dtc = "Sum(coalesce(AmountOrder, 0))  + Sum(coalesce(AmountRefund, 0))   + Sum(coalesce(AmountAdjustment, 0))   + Sum(coalesce(AmountChargeback, 0))  + Sum(coalesce(AmountServiceFee, 0)) + Sum(coalesce(AmountGuarantee, 0)) + (  (sum((sign(abs(coalesce(AmountOrder, 0))) * fr.quantity))  + sum((sign(abs(coalesce(AmountAdjustment, 0))) * fr.quantity))  + sum((sign(abs(coalesce(AmountChargeback, 0))) * fr.quantity)) + sum((sign(abs(coalesce(AmountServiceFee, 0))) * fr.quantity)) + sum((sign(abs(coalesce(AmountGuarantee, 0))) * fr.quantity)))  * coalesce(max(sk.Cost), 0)) ";
                    dtc = "  sum(profit)  ";
                    break;
                default:
                    dtc = "0";
                    break;
            }

            return dtc;
        }
        #region Base Report Methods
        [HttpPost]
        public BaseReport GetBaseReportData([FromBody]List<ReportParameter> param, string reportId)
        {

            DataTable dt = new DataTable();
            DataTable dtChart = new DataTable();
            ReportManager rm = new ReportManager(conStr);
            int id = 0;
            if (reportId != "")
            {
                id = int.Parse(reportId);
            }
            ReportDefinition rd = rm.GetReportObj(id);
            List<ReportDataColumn> lst = new List<ReportDataColumn>();
            QueryManager qm = new QueryManager(conStr);
            //connenct to parameters

            List<IDataParameter> dbp = null;
            if (param != null)
            {
                if (param.Count > 0)
                {
                    dbp = new List<IDataParameter>();
                    foreach (var item in param)
                    {
                        if (item.Type == "date")
                        {
                            if (item.Value == "")
                            {
                                item.Value = DateTime.Now.ToString();
                            }
                            dbp.Add(new NpgsqlParameter(item.ParameterKey, DateTime.Parse(item.Value)));
                        }
                        else
                        {
                            dbp.Add(new NpgsqlParameter(item.ParameterKey, item.Value));

                        }
                    }
                }
            }

            dt = qm.GetQueryResultDataTable(Convert.ToInt32(rd.QueryId), dbp);
            if (rd.ChartQueryId != null && rd.ChartQueryId > 0)
            {
                dtChart = qm.GetQueryResultDataTable((int)rd.ChartQueryId, dbp);

            }
            foreach (DataColumn column in dt.Columns)
            {
                lst.Add(new ReportDataColumn { title = column.ColumnName });

            }

            BaseReport br = new BaseReport();
            List<string[]> dataStrList = new List<string[]>();
            foreach (DataRow item in dt.Rows)
            {
                string[] str = new string[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    str[i] = item[i].ToString();
                }
                dataStrList.Add(str);
            }
            br.columns = lst.ToArray<ReportDataColumn>();
            br.data = dataStrList;
            br.ReportChart = GenereateChartData(dtChart);
            return br;
        }
        private GraphCollection GenereateChartData(DataTable chartTable)
        {
            if (chartTable == null)
            {
                return null;
            }
            GraphCollection graphCol = new GraphCollection();
            graphCol.XAxis = new string[chartTable.Rows.Count];
            graphCol.GraphList = new List<Graph>();
            int index = 0;
            for (int i = 0; i < chartTable.Columns.Count; i++)
            {
                if (i == 0)
                {
                    foreach (DataRow item in chartTable.Rows)
                    {
                        graphCol.XAxis[index] = item[0].ToString();
                        index++;
                    }
                }
                else
                {
                    Graph graphItem = new Graph();
                    graphItem.data = new List<double>();
                    graphItem.name = chartTable.Columns[i].ColumnName;
                    foreach (DataRow drow in chartTable.Rows)
                    {
                        try
                        { graphItem.data.Add(Convert.ToDouble(drow[i])); }
                        catch
                        { graphItem.data.Add(0); }

                    }
                    graphCol.GraphList.Add(graphItem);
                }
            }

            return graphCol;
        }
        #endregion
    }

    public class Criterias
    {
        public string startdate { get; set; }
        public string enddate { get; set; }

        public string period { get; set; }
        public string fulfill { get; set; }
        public string sku { get; set; }
        public string vendor { get; set; }
        public string skutitle { get; set; }
        public string datatype { get; set; }
        public string xperiod { get; set; }
        public string asin { get; set; }

    }

    public class GraphData
    {
        public string date { get; set; }
        public double val { get; set; }
    }


}
