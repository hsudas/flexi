using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Request
{
    public class AcceptedRejectedOrder
    {
        public string acknowledgement_status { get; set; }
        public string alt_order_id { get; set; }
        public List<OrderItemReq> order_items { get; set; }
    }

    public class OrderItemReq
    {
        public string order_item_acknowledgement_status { get; set; }
        public string order_item_id { get; set; }
        public string alt_order_item_id { get; set; }
    }



}
