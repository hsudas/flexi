using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class VariationRetrieval
    {
        public string relationship { get; set; }
        public List<int> variation_refinements { get; set; }
        public List<int> children_skus { get; set; }
        public string group_title { get; set; }

    }
}
