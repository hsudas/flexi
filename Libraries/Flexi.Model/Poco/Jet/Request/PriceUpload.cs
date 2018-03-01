using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Request
{
    public class PriceUpload
    {
        public decimal price { get; set; }
        public List<FulfillmentNode> fulfillment_nodes { get; set; }
    }

    public class FulfillmentNode
    {
        public string fulfillment_node_id { get; set; }
        public decimal fulfillment_node_price { get; set; }
    }


}
