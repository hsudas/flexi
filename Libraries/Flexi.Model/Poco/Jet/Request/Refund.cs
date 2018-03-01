using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Request
{

    public class Refund
    {
        public string merchant_order_id { get; set; }
        public string alt_order_id { get; set; }
        public List<RefundItem> items { get; set; }
        public bool agree_to_return_charge { get; set; }
    }

    public class RefundAmount
    {
        public decimal principal { get; set; }
        public int tax { get; set; }
        public decimal shipping_cost { get; set; }
        public int shipping_tax { get; set; }
    }

    public class RefundItem
    {
        public string order_item_id { get; set; }
        public string alt_order_item_id { get; set; }
        public int total_quantity_returned { get; set; }
        public int order_return_refund_qty { get; set; }
        public string refund_reason { get; set; }
        public string refund_feedback { get; set; }
        public string notes { get; set; }
        public RefundAmount refund_amount { get; set; }
    }

    public class RefundRootObject
    {
        public List<RefundItem> items { get; set; }
    }



}
