using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.WebUI.Models.Report
{
    public class OrderReport
    {
        public string Vendor { get; set; }
        public string Asin { get; set; }
        public string SKU { get; set; }
        public string MarketplaceName { get; set; }
    
        public int Quantity { get; set; }
        public decimal OrderUAmount { get; set; }
        public int OrderUQuantity { get; set; }

        public decimal RefundUAmount { get; set; }
        public int RefundUQuantity { get; set; }
        public decimal TotalCost { get; set; }

        public decimal AmountOther { get; set; }

        public decimal Profit { get; set; }

        public int OrderItem { get; set; }//Sum(isnull(f.quantity,0))
        public int UnitsOrdered { get; set; }//Count(isnull(f.quantity,0))

        /*
         * 
         Date
Quantity
OrderAmount
OrderQuantity
RefundAmount
RefundQuantity
TotalCost
AmountOther
Profit
         * */
    }
}
