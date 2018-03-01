using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class PriceRetrieval
    {
        public List<FulfillmentNodePrice> fulfillment_nodes { get; set; }
        public decimal price { get; set; }
        public string price_last_update { get; set; }
    }

    public class FulfillmentNodePrice
    {
        public string fulfillment_node_id { get; set; }
        public decimal fulfillment_node_price { get; set; }
    }
}
