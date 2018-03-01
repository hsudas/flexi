using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class OrderDetailResponse : IRawOrder
    {
        public string merchant_order_id { get; set; }
        public string reference_order_id { get; set; }
        public string fulfillment_node { get; set; }
        public string order_placed_date { get; set; }
        public string order_transmission_date { get; set; }
        public string order_ready_date { get; set; }
        public string order_acknowledge_date { get; set; }
        public string status { get; set; }
        public string hash_email { get; set; }
        public Buyer buyer { get; set; }
        public ShippingTo shipping_to { get; set; }
        public OrderTotals order_totals { get; set; }
        public List<OrderItemResp> order_items { get; set; }
        public OrderDetail order_detail { get; set; }
    }

    public class Buyer
    {
        public string name { get; set; }
        public string phone_number { get; set; }
    }

    public class Recipient
    {
        public string name { get; set; }
        public string phone_number { get; set; }
    }

    public class Address
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
    }

    public class ShippingTo
    {
        public Recipient recipient { get; set; }
        public Address address { get; set; }
    }

    public class ItemPrice
    {
        public decimal base_price { get; set; }
        public decimal? item_tax { get; set; }
        public decimal item_shipping_cost { get; set; }
        public decimal? item_shipping_tax { get; set; }
    }

    public class FeeAdjustment
    {
        public string adjustment_name { get; set; }
        public string adjustment_type { get; set; }
        public string commission_id { get; set; }
        public decimal value { get; set; }
    }

    public class OrderTotals
    {
        public ItemPrice item_price { get; set; }
        public double item_fees { get; set; }
        public List<FeeAdjustment> fee_adjustments { get; set; }
        public double? regulatory_fees { get; set; }
    }

    public class ItemPrice2
    {
        public decimal base_price { get; set; }
        public decimal? item_tax { get; set; }
        public decimal item_shipping_cost { get; set; }
        public decimal? item_shipping_tax { get; set; }
    }

    public class FeeAdjustment2
    {
        public string adjustment_name { get; set; }
        public string adjustment_type { get; set; }
        public string commission_id { get; set; }
        public double value { get; set; }
    }

    public class OrderItemResp
    {
        public string order_item_id { get; set; }
        public string merchant_sku { get; set; }
        public int request_order_quantity { get; set; }
        public string item_tax_code { get; set; }
        public ItemPrice2 item_price { get; set; }
        public double item_fees { get; set; }
        public List<FeeAdjustment2> fee_adjustments { get; set; }
        public double? regulatory_fees { get; set; }
        public string product_title { get; set; }
        public string url { get; set; }
    }

    public class OrderDetail
    {
        public string request_shipping_carrier { get; set; }
        public string request_shipping_method { get; set; }
        public string request_service_level { get; set; }
        public string request_ship_by { get; set; }
        public string request_delivery_by { get; set; }
    }

}
