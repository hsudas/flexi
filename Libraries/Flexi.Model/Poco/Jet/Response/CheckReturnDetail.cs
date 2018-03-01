using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class CheckReturnDetail
    {
        public string merchant_return_authorization_id { get; set; }
        public string reference_return_authorization_id { get; set; }
        public string return_status { get; set; }
        public bool refund_without_return { get; set; }
        public string merchant_order_id { get; set; }
        public string reference_order_id { get; set; }
        public string alt_order_id { get; set; }
        public string return_date { get; set; }
        public List<ReturnMerchantSKU> return_merchant_SKUs { get; set; }
        public string shipping_carrier { get; set; }
        public string tracking_number { get; set; }
        public double merchant_return_charge { get; set; }
    }

    public class RequestedRefundAmount
    {
        public double principal { get; set; }
        public double tax { get; set; }
        public double shipping_cost { get; set; }
        public double shipping_tax { get; set; }
    }

    public class ReturnMerchantSKU
    {
        public string order_item_id { get; set; }
        public string alt_order_item_id { get; set; }
        public string merchant_sku { get; set; }
        public string merchant_sku_title { get; set; }
        public int return_quantity { get; set; }
        public string reason { get; set; }
        public RequestedRefundAmount requested_refund_amount { get; set; }
    }


}
