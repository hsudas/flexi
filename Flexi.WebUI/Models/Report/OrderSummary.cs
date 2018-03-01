using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flexi.WebUI.Models.Report
{
    public class OrderSummary
    {
        public long TotalOrderItems { get; set; }
        public long UnitsOrdered { get; set; }
        public decimal TotalOrderItemsPercent { get; set; }
        public decimal UnitsOrderedPercent { get; set; }
        public decimal OrderedProductSales { get; set; }//Sum(isnull(AmountOrder, 0)) as OrderUAmount

        public decimal AvgUnitsOrderItem { get; set; }

        public decimal AvgSalesOrderItem { get; set; }

        public decimal RefundAmount { get; set; }//sum((sign(abs(isnull(AmountRefund, 0))) * f.quantity))  as RefundUQuantity

        public decimal Profit { get; set; }

        

    }
}