
namespace Flexi.Model.Poco.Walmart.Response3
{
    public class WalmartOrderList
    {
        public List List { get; set; }
    }

    public class Meta
    {
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public string NextCursor { get; set; }
    }

    public class Elements
    {
        public System.Collections.Generic.List<Order> order { get; set; }
    }

    public class OrderRoot
    {
        public Order OrderList { get; set; }
    }

    public class List
    {
        public Meta Meta { get; set; }
        public Elements Elements { get; set; }
    }


}
