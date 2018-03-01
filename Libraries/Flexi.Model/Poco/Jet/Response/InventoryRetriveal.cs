using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class InventoryRetriveal
    {
        public List<FulfillmentNode> fulfillment_nodes { get; set; }
        public string inventory_last_update { get; set; }
    }

    public class FulfillmentNode
    {
        public string fulfillment_node_id { get; set; }
        public int quantity { get; set; }
    }
}
