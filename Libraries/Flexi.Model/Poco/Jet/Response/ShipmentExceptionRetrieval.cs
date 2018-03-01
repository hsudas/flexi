using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class ShipmentExceptionRetrieval
    {
        public string fulfillment_node_id { get; set; }
        public List<ShippingException> shipping_exceptions { get; set; }
    }

    public class ShippingException
    {
        public string service_level { get; set; }
        public string shipping_exception_type { get; set; }
        public string shipping_method { get; set; }
        public string override_type { get; set; }
        public double? shipping_charge_amount { get; set; }
    }

}
