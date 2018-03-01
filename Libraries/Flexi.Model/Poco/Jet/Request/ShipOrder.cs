using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Request
{

    public class ShipOrder : IShipOrderRequest
    {
        public string alt_order_id { get; set; }
        public List<IShipment> shipments { get; set; }
    }

    public class ReturnLocation
    {
        public string address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
    }

    public class ShipmentItem
    {
        public string alt_shipment_item_id { get; set; }
        public string merchant_sku { get; set; }
        public int response_shipment_sku_quantity { get; set; }
        public int response_shipment_cancel_qty { get; set; }
        public string RMA_number { get; set; }
        public int days_to_return { get; set; }
        public ReturnLocation return_location { get; set; }
    }

    public class Shipment : IShipOrderRequest, IShipment
    {
        public string alt_shipment_id { get; set; }
        public string shipment_tracking_number { get; set; }
        public string response_shipment_date { get; set; }
        public string response_shipment_method { get; set; }
        public string expected_delivery_date { get; set; }
        public string ship_from_zip_code { get; set; }
        public string carrier_pick_up_date { get; set; }
        public string carrier { get; set; }
        public List<ShipmentItem> shipment_items { get; set; }
    }

    public class ShipmentCancel : IShipment
    {
        public string alt_shipment_id { get; set; }
        public List<ShipmentItem> shipment_items { get; set; }
    }

    public interface IShipOrderRequest
    {

    }

    public interface IShipment
    {

    }

}
