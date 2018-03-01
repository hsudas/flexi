using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Request
{

    public class ShippingExceptionUpload
    {
        public List<FulfillmentNodeShipping> fulfillment_nodes { get; set; }
    }

    public class ShippingException
    {
        public string service_level { get; set; }
        public string shipping_exception_type { get; set; }
        public string override_type { get; set; }
        public double? shipping_charge_amount { get; set; }
    }

    public class FulfillmentNodeShipping
    {
        public string fulfillment_node_id { get; set; }
        public List<ShippingException> shipping_exceptions { get; set; }
    }


}
