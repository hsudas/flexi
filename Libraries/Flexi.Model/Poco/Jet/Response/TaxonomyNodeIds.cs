using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class TaxonomyNodeIds
    {
        public int jet_node_id { get; set; }
        public string jet_node_name { get; set; }
        public string jet_node_path { get; set; }
        public List<int> amazon_node_ids { get; set; }
        public int parent_id { get; set; }
        public int jet_level { get; set; }
        public string suggested_tax_code { get; set; }
    }
}
