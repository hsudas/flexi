using Flexi.Model.Enum.Walmart;
using System;

namespace Flexi.Model.Poco.Walmart
{
    public class AllOrdersUrlPoco
    {
        public string sku { get; set; }
        public string customerOrderId { get; set; }
        public string purchaseOrderId { get; set; }
        public OrderStatus? orderStatus { get; set; }
        public DateTime? createdStartDate { get; set; }
        public DateTime? createdEndDate { get; set; }
        public int? limit { get; set; }
        public int? nextCursor { get; set; }
    }
}
