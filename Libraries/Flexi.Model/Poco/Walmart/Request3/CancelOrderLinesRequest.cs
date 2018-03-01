
namespace Flexi.Model.Poco.Walmart.Request3
{
    public class CancelOrderLinesRequest
    {
        public OrderCancellation orderCancellation { get; set; }
    }

    public class OrderCancellation
    {
        public OrderLines orderLines { get; set; }
    }


}
